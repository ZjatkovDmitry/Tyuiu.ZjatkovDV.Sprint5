using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using Tyuiu.ZjatkovDV.Sprint5.Task5.V9.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #5 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #9                                                              *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан файл С:\\DataSprint5\\InPutDataFileTask5V9.txt, в котором    *");
Console.WriteLine("* есть набор значений. Найти максимальное целое число в файле. Полученный *");
Console.WriteLine("* результат вывести на консоль. У вещественных значений округлить до трёх *");
Console.WriteLine("* знаков после запятой.                                                   *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

string x = "C:\\DataSprint5\\InPutDataFileTask5V9.txt";

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.LoadFromDataFile(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();