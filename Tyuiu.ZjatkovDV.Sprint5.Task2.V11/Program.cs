using System.IO;
using System.Text;
using Tyuiu.ZjatkovDV.Sprint5.Task2.V11.Lib;

Console.OutputEncoding = Encoding.UTF8;

Console.Title = "Спринт #5 | Выполнил: Зятьков Д. В. | ПИНб-25-1";
Console.WriteLine(new string('*', 75));
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Зятьков Дмитрий Владимирович | ПИНб-25-1                      *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 3 на 3 элементов,           *");
Console.WriteLine("* заполненный значениями с клавиатуры. Заменить нечетные элементы массива *");
Console.WriteLine("* на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на       *");
Console.WriteLine("* консоль.                                                                *");
Console.WriteLine(new string('*', 75));
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine(new string('*', 75));

var result = new DataService();

string path = $@"{Path.GetTempPath()}\OutPutFileTask2.csv";

int[,] x = new int[3, 3];

for (int i = 0; i < x.GetLength(0); i++)
{
    for (int j = 0; j < x.GetLength(1); j++)
    {
        Console.Write($"Введите {j + 1}-ый (из 3) элемент {i + 1}-ой (из 3) строки массива: ");
        x[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine(result.SaveToFileTextData(x).ToString());

foreach (string line in File.ReadLines(path))
{
    Console.WriteLine(line);
}

Console.WriteLine(new string('*', 75));
Console.ReadKey();