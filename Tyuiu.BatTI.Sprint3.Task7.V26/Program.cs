using Tyuiu.BatTI.Sprint3.Task7.V26.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнил: Бат Т.И. | ПИНб-25-1";
Console.WriteLine("****************************************************************************");
Console.WriteLine("* Спринт #3                                                                *");
Console.WriteLine("* Тема: Итоговый проект                                                    *");
Console.WriteLine("* Задание #7                                                               *");
Console.WriteLine("* Вариант #26                                                              *");
Console.WriteLine("* Выполнил: Бат Трофим Иванович | ПИНб-25-1                                *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                 *");
Console.WriteLine("* Написать программу, которая выводит таблицу значений функции             *");
Console.WriteLine("*                                                                          *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
Console.WriteLine("****************************************************************************");

int startValue = -5;
int stopValue = 5;

Console.WriteLine("Начало шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

int len = 11;
double[] valueArray;
valueArray = new double[len];
valueArray = ds.GetMassFunction(startValue, stopValue);

Console.WriteLine("****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
Console.WriteLine("****************************************************************************");

Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    X     |    f(x)   |");
Console.WriteLine("+----------+-----------+");

for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine("|{0,5:d}     |  {1,5:f2}    |", startValue, valueArray[i]);
    startValue++;
}
Console.WriteLine("+----------+-----------+");
Console.ReadKey();
