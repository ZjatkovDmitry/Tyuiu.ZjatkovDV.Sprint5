using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using Tyuiu.ZjatkovDV.Sprint5.Task4.V7.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #5 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан файл С:\\DataSprint5\\InPutDataFileTask4V0.txt, в котором    *");
Console.WriteLine("* есть вещественное значение. Прочитать значение из файла и подставить    *");
Console.WriteLine("* вместо Х в формуле y = 1 / cos(x) + x^3. Вычислить значение по формуле  *");
Console.WriteLine("* (Полученное значение округлить до трёх знаков после запятой) и вернуть  *");
Console.WriteLine("* полученный результат на консоль.                                        *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: y = 1 / cos(x) + x^3                                   *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

string x = "C:\\DataSprint5\\InPutDataFileTask4V7.txt";

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.LoadFromDataFile(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();