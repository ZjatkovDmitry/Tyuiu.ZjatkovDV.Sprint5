using System.Text;
using Tyuiu.ZjatkovDV.Sprint5.Task0.V3.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #5 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дано выражение вычислить его значение при x = 3, результат     *");
Console.WriteLine("* сохранить в текстовый файл OutPutFileTask0.txt и вывести на консоль.    *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: y = -1/4 * (x^3 - 3x^2 +4), x = 3                      *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

int x = 3;

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.SaveToFileTextData(x).ToString());

Console.WriteLine(File.ReadAllText("OutPutFileTask0.txt"));

Console.WriteLine(new string('*', 75));
Console.ReadKey();