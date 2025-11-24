using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZjatkovDV.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            double[] numbers = File.ReadAllText(path)
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                      .Select(s => double.Parse(s, CultureInfo.InvariantCulture))
                      .ToArray();

            return Math.Round(numbers.Max(), 3);
        }
    }
}
