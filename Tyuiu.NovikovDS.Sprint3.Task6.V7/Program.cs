using Tyuiu.NovikovDS.Sprint3.Task6.V7.Lib;

DataService ds = new();

Console.Title = "Спринт #3 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих       *");
Console.WriteLine("* числовому отрезку [17, 26] сумму всех делителей.                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int a1, a2;

do
{
    Console.WriteLine("Введите начальное значение:");
    a1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите конечное значение:");
    a2 = Convert.ToInt32(Console.ReadLine());

    if (a1 > a2) Console.WriteLine("Начальное значение не может быть больше конечного, попробуйте ещё раз.");
    if ((a1 < 1) || (a2 < 2)) Console.WriteLine("Значения должны быть положительными.");

} while (a1 > a2);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма всех делителей чисел, пренадлежащих отрезку [" + a1 + ", " + a2 + "]: " + ds.GetSumTheDivisors(a1, a2));
Console.ReadLine();
