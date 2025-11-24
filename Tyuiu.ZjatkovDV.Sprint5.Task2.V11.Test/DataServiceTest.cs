using Tyuiu.ZjatkovDV.Sprint5.Task2.V11.Lib;

namespace Tyuiu.ZjatkovDV.Sprint5.Task2.V11.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckSaveToFileTextData()
        {
            var result = new DataService();
            Assert.Equal(true, new FileInfo($@"{Path.GetTempPath()}\OutPutFileTask2.csv").Exists);
        }
    }
}