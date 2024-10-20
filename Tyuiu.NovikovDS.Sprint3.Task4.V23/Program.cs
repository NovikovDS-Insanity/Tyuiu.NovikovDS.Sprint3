﻿using Tyuiu.NovikovDS.Sprint3.Task4.V23.Lib;

DataService ds = new();

Console.Title = "Спринт #3 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Использование операторов continue и break в циклах                *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение     *");
Console.WriteLine("* функции y=(cos(x)/x)+3. При х = 0 прервать цикл.                        *");
Console.WriteLine("* Полученные значения перемножать.                                        *");
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

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Результат произведения: " + ds.Calculate(x, y));
Console.ReadLine();
