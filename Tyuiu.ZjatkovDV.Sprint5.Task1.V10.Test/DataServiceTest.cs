using Tyuiu.ZjatkovDV.Sprint5.Task1.V10.Lib;

namespace Tyuiu.ZjatkovDV.Sprint5.Task1.V10.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckSaveToFileTextData()
        {
            var result = new DataService();
            Assert.Equal(true, new FileInfo($@"{Path.GetTempPath()}\OutPutFileTask1.txt").Exists);
        }
    }
}