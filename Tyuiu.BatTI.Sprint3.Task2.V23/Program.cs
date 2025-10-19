using Tyuiu.BatTI.Sprint3.Task2.V23.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #3                                                                *");
Console.WriteLine("* Тема: Цикл do/While                                                      *");
Console.WriteLine("* Задание #2                                                               *");
Console.WriteLine("* Вариант #23                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая считает сумму ряда                           *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

double value = Convert.ToDouble(Console.ReadLine());
int startValue = Convert.ToInt32(Console.ReadLine());
int stopValue = Convert.ToInt32(Console.ReadLine());

double res = ds.GetSumSeries(value, startValue, stopValue);

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Результат = " + res);
Console.ReadKey();
