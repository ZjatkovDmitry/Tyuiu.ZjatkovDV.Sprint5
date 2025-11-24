using Tyuiu.ZjatkovDV.Sprint5.Task3.V13.Lib;

namespace Tyuiu.ZjatkovDV.Sprint5.Task3.V13.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckSaveToFileTextData()
        {
            var result = new DataService();
            Assert.Equal(true, new FileInfo($@"{Path.GetTempPath()}\OutPutFileTask3.bin").Exists);
        }
    }
}