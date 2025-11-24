using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;
using Tyuiu.ZjatkovDV.Sprint5.Task3.V13.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #5 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дано выражение вычислить его значение при x = 3, результат     *");
Console.WriteLine("* сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль.     *");
Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: y(x) = x / (x^3 + 2)                                   *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

string path = $@"{Path.GetTempPath()}\OutPutFileTask3.bin";

int x = 3;

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.SaveToFileTextData(x).ToString());

using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
{
    byte[] bytes = reader.ReadBytes(sizeof(double));
    double value = BitConverter.ToDouble(bytes, 0);
    Console.WriteLine(value.ToString());
}

Console.WriteLine(new string('*', 75));
Console.ReadKey();