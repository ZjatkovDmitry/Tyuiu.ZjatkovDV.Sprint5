using Tyuiu.ZjatkovDV.Sprint5.Task0.V3.Lib;

namespace Tyuiu.ZjatkovDV.Sprint5.Task0.V3.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckSaveToFileTextData()
        {
            var result = new DataService();
            Assert.Equal(true, new FileInfo(@"D:\Projects\“»”\Tyuiu.ZjatkovDV.Sprint5\Tyuiu.ZjatkovDV.Sprint5.Task0.V3\bin\Debug\net8.0\OutPutFileTask0.txt").Exists);
        }
    }
}