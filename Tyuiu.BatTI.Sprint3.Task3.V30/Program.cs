using Tyuiu.BatTI.Sprint3.Task3.V30.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #3                                                                *");
Console.WriteLine("* Тема: Оператор цикла Foreach                                             *");
Console.WriteLine("* Задание #3                                                               *");
Console.WriteLine("* Вариант #30                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая считает максимальное кол-во стоящих рядом    *");
Console.WriteLine("* букв у                                                                   *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

string value = "fyyklbtyn ygrc vfyyyyh";
char chr = 'y';

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Результат = " + ds.GetMaxCharCount(value, chr));
Console.ReadKey();
