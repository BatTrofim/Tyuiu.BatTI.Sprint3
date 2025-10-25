using Tyuiu.BatTI.Sprint3.Task4.V19.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #3                                                                *");
Console.WriteLine("* Тема: Использование оператов break и continue в циклах                   *");
Console.WriteLine("* Задание #4                                                               *");
Console.WriteLine("* Вариант #19                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая считает значение функции y=x/(cos(x) + x)+0.5*");
Console.WriteLine("* в цикле и полученные значения перемножает                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

int startValue = 5;
int stopValue = -5;

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Результат = " + ds.Calculate(startValue, stopValue));
Console.ReadKey();
