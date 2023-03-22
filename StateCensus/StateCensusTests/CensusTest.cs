using StateCensus;
namespace StateCensusTests
{
    public class Tests
    {
        public static string stateDataFilePath = "C:\\Users\\hp\\source\\repos\\StateCensus\\StateCensus\\Files\\IndiaStateCensusData.csv";
        public static string stateDataFileIncorrectPath = "C:\\Users\\hp\\source\\repos\\StateCensus\\StateCensus\\Files\\IndiaStateCensusData2.csv";
        CSVStateCensus csvStateCensus = new CSVStateCensus();


        [Test]
        public void GivenStateCensusData_ShouldMatchNumberOfReturnMatch()
        {
            Assert.AreEqual(29, csvStateCensus.ReadStateCensusData(stateDataFilePath));
        }
        [Test]
        public void GivenIncorrectFilePath_ShouldReturnCustomeException()
        {
            try
            {
                csvStateCensus.ReadStateCensusData(stateDataFileIncorrectPath);
            }
            catch (CensusCustomException ex)
            {
                Assert.AreEqual("Incorrect file Path", ex.Message);
            }
        }
    }
}