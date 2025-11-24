using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZjatkovDV.Sprint5.Task1.V10.Lib
{
    public class DataService : ISprint5Task1V10
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            if (new FileInfo(path).Exists)
            {
                File.Delete(path);
            }

            int length = stopValue - startValue + 1;

            for (int i = 0; i < length; i++)
            {
                int x = startValue + i;

                if (2 * x - 1 == 0)
                {
                    File.AppendAllText(path, "0\n");
                }
                else
                {
                    File.AppendAllText(path, Math.Round(((2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x + 3, 2) + "\n");
                }
            }

            return path;
        }
    }
}
