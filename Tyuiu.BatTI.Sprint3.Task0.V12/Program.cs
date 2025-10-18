using Tyuiu.BatTI.Sprint3.Task0.V12.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #3                                                                *");
Console.WriteLine("* Тема: Цикл For                                                           *");
Console.WriteLine("* Задание #0                                                               *");
Console.WriteLine("* Вариант #12                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая считает произведение ряда                    *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

int value = Convert.ToInt32(Console.ReadLine());
int startValue = Convert.ToInt32(Console.ReadLine());
int stopValue = Convert.ToInt32(Console.ReadLine());

double res = ds.GetMultiplySeries(value, startValue, stopValue);

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("Результат = " + res);
Console.ReadKey();
