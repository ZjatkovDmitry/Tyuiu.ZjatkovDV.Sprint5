using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZjatkovDV.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble(File.ReadAllText(path).Replace('.', ','));
            
            return Math.Round(1 / Math.Cos(x) + Math.Pow(x, 3) , 3);
        }
    }
}
