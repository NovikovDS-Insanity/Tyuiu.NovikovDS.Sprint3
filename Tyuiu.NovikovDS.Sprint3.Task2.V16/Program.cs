using Tyuiu.NovikovDS.Sprint3.Task2.V16.Lib;

DataService ds = new();

Console.Title = "Спринт #3 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла do-while                                           *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет         *");
Console.WriteLine("* произведение ряда по формуле, при n=2.                                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int x, y, n, temp;

do
{
    Console.WriteLine("Введите начальное значение:");
    x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите конечное значение:");
    y = Convert.ToInt32(Console.ReadLine());

    temp = 0;
    for (int i = x; i < y; i++)
    {
        if (i == 0)
        {
            temp = 1;
            break;
        }
    }
    if (temp == 1) Console.WriteLine("Неверный промежуток, встречается деление на ноль.");
    if (x > y) Console.WriteLine("Неверный промежуток, начальное значение больше конечного.");
} while ((temp == 1) || (x > y));

Console.WriteLine("Введите значение N:");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.GetMultiplySeries(n, x, y));
Console.ReadLine();
