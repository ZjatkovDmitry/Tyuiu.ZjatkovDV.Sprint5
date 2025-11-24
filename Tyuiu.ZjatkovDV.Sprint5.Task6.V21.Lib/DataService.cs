using System.Globalization;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.ZjatkovDV.Sprint5.Task6.V21.Lib
{
    public class DataService : ISprint5Task6V21
    {
        public int LoadFromDataFile(string path)
        {
            return Regex.Matches(File.ReadAllText(path).ToLower(), "тт").Count;
        }
    }
}
