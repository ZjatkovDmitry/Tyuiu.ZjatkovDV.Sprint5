using Tyuiu.ZjatkovDV.Sprint5.Task4.V7.Lib;

namespace Tyuiu.ZjatkovDV.Sprint5.Task4.V7.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckLoadFromDataFile()
        {
            var result = new DataService();
            Assert.Equal(2.876, result.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask4V7.txt"));
        }
    }
}