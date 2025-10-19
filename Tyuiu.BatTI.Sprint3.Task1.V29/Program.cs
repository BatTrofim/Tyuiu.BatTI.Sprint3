using Tyuiu.BatTI.Sprint3.Task1.V29.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #3                                                                *");
Console.WriteLine("* Тема: Цикл While                                                         *");
Console.WriteLine("* Задание #1                                                               *");
Console.WriteLine("* Вариант #29                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая считает произведение ряда                    *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

double value = Convert.ToDouble(Console.ReadLine());
int startValue = Convert.ToInt32(Console.ReadLine());
int stopValue = Convert.ToInt32(Console.ReadLine());

double res = ds.GetMultiplySeries(value, startValue, stopValue);

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Результат = " + res);
Console.ReadKey();
