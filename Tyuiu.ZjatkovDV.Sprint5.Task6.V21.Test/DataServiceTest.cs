using Tyuiu.ZjatkovDV.Sprint5.Task6.V21.Lib;

namespace Tyuiu.ZjatkovDV.Sprint5.Task6.V21.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckLoadFromDataFile()
        {
            var result = new DataService();
            Assert.Equal(3, result.LoadFromDataFile("C:\\DataSprint5\\InPutDataFileTask6V21.txt"));
        }
    }
}