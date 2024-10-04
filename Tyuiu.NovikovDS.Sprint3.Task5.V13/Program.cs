using Tyuiu.NovikovDS.Sprint3.Task5.V13.Lib;

DataService ds = new();

Console.Title = "Спринт #3 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #13                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Решить уравнение, изображенное на картинке, при X = 5.                  *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите значение a1:");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение a2:");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение X:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Результат произведения: " + ds.GetSumSumSeries(x, a1, a2, b1, b2));
Console.ReadLine();
