using System;
using System.Security.Cryptography.X509Certificates;

namespace StateCensus
{
    public class Program
    {
        public static string stateDataFilePath = "C:\\Users\\hp\\source\\repos\\StateCensus\\StateCensus\\Files\\IndiaStateCensusData.csv";
        public static string stateCodeFilePath = "C:\\Users\\hp\\source\\repos\\StateCensus\\StateCensus\\Files\\IndiaStateCode.csv";
        public CSVStateCensus csvStateCensus = new CSVStateCensus();
        public static void Main(string[] args)
        {
            //CSVStateCensus.ReadStateCensusData(stateDataFilePath);
            CSVStateCensus.ReadStateCensusCode(stateCodeFilePath);

        }
    }
}