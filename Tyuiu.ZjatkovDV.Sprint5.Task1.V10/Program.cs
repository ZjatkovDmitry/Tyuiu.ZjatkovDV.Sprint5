using System.IO;
using System.Text;
using Tyuiu.ZjatkovDV.Sprint5.Task1.V10.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #5 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дана функция:                                                  *");
Console.WriteLine("* F(x) = (2*cos(x) + 2) / (2*x - 1) + cos(x) - 5*x + 3 Произвести         *");
Console.WriteLine("* табулирование f(x) на диапазоне [-5; 5] с шагом 1. Произвести проверку  *");
Console.WriteLine("* деления на ноль. При делении на ноль вернуть значение 0. Результат      *");
Console.WriteLine("* сохранить в файл OutPutFileTask1.txt и вывести на консоль в виде        *");
Console.WriteLine("* таблицы. Значения округлить до двух знаков после запятой.               *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: F(x) = (2*cos(x) + 2) / (2*x - 1) + cos(x) - 5*x + 3   *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

string path = $@"{Path.GetTempPath()}\OutPutFileTask1.txt";

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.SaveToFileTextData(-5, 5).ToString());

string[] lines = File.ReadAllLines(path);
List<double> numbers = new List<double>();

foreach (string line in lines)
{
    if (double.TryParse(line.Trim(), out double number))
    {
        numbers.Add(number);
    }
}

Console.WriteLine($"[{string.Join(", ", numbers)}]");

Console.WriteLine(new string('*', 75));
Console.ReadKey();