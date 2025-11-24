using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using Tyuiu.ZjatkovDV.Sprint5.Task6.V21.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #5 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Обработка текстовых файлов                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #21                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан файл С:\\DataSprint5\\InPutDataFileTask6V21.txt, в котором   *");
Console.WriteLine("* есть набор символьных данных. Найти количество удвоенных букв \"тт\" в    *");
Console.WriteLine("* заданной строке.                                                        *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

string x = "C:\\DataSprint5\\InPutDataFileTask6V21.txt";

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.LoadFromDataFile(x).ToString());

Console.WriteLine(new string('*', 75));
Console.ReadKey();