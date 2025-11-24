using Tyuiu.ZjatkovDV.Sprint5.Task7.V13.Lib;

namespace Tyuiu.ZjatkovDV.Sprint5.Task7.V13.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckLoadFromDataFile()
        {
            var result = new DataService();
            Assert.Equal(true, new FileInfo($@"{Path.GetTempPath()}\OutPutDataFileTask7V13.txt").Exists);
        }
    }
}