using Tyuiu.NovikovDS.Sprint3.Task3.V30.Lib;

DataService ds = new();

Console.Title = "Спринт #3 | Выполнил: Новиков Д. С. | РППб-24-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнил: Новиков Д. С. | РППб-24-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y,       *");
Console.WriteLine("* находящихся на соседних позициях в строке: fyyklbtyn ygrc vfyyyyh.      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "fyyklbtyn ygrc vfyyyyh";
char chr = 'y';

Console.WriteLine("* Исходная строка - " + value);
Console.WriteLine("* Исходный символ - " + chr);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Максимальное повторение символа " + chr + ": " + ds.GetMaxCharCount(value, chr));
Console.ReadLine();
