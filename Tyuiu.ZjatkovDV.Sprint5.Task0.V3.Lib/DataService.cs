using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZjatkovDV.Sprint5.Task0.V3.Lib
{
    public class DataService : ISprint5Task0V3
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            File.WriteAllText(path, Math.Round(-1.0 / 4.0 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4), 3).ToString());
            return path;
        }
    }
}
