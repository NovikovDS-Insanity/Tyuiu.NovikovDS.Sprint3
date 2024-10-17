using Tyuiu.NovikovDS.Sprint3.Task1.V6.Lib;

DataService ds = new();

Console.Title = "Спринт #3 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #6                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
Console.WriteLine("* по формуле, при a=4.                                                    *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x, y;

do
{
    Console.WriteLine("Введите начальное значение:");
    x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите конечное значение:");
    y = Convert.ToInt32(Console.ReadLine());

    if (x > y) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
} while (x > y);

Console.WriteLine("Введите значение A:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.GetSumSeries(a, x, y));
Console.ReadLine();
