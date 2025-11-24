using Tyuiu.ZjatkovDV.Sprint5.Task5.V9.Lib;

namespace Tyuiu.ZjatkovDV.Sprint5.Task5.V9.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckLoadFromDataFile()
        {
            var result = new DataService();
            Assert.Equal(19.51, result.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask5V9.txt"));
        }
    }
}