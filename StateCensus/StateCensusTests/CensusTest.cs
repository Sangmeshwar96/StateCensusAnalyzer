using StateCensus;
namespace StateCensusTests
{
    public class Tests
    {
        public static string stateDataFilePath = "C:\\Users\\hp\\source\\repos\\StateCensus\\StateCensus\\Files\\IndiaStateCensusData.csv";
        CSVStateCensus csvStateCensus = new CSVStateCensus();


        [Test]
        public void GivenStateCensusData_ShouldMatchNumberOfReturnMatch()
        {
            Assert.AreEqual(29, csvStateCensus.ReadStateCensusData(stateDataFilePath));
        }
    }
}