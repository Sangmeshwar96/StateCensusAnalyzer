using CsvHelper;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateCensus
{
    public class CSVStateCensus
    {
        public int ReadStateCensusData(String stateDataFilePath)
        {
            using (var reader = new StreamReader(stateDataFilePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusAnalyzerModel>().ToList();
                    foreach (var record in records)
                    {
                        Console.WriteLine($"{record.State} {record.Population}{record.AreaInSqKm}{record.DensityPerSqKm}");
                    }
                    return records.Count();
                }
            }
        }
        public static void ReadStateCensusCode(String stateCodeFilePath)
        {
            using (var reader = new StreamReader(stateCodeFilePath))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<StateCensusCode>().ToList();
                    foreach (var record in records)
                    {
                        Console.WriteLine($"{record.SrNo} {record.State}{record.TIN}{record.StateCode}");
                    }
                }
            }
        }
    }
}
