/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите число.");
int num = int.Parse(Console.ReadLine()!);
if (num>7) Console.WriteLine($"{num} - Число не верно!");
else if (num <1) Console.WriteLine($"{num} - ЧИСЛО  НЕ ВЕРНО!!!");
else if (num==1) Console.WriteLine("Понедельник");
else if (num==2) Console.WriteLine("Вторник");
else if (num==3) Console.WriteLine("Среда");
else if (num==4) Console.WriteLine("Четверг");
else if (num==5) Console.WriteLine("Пятница");
else if (num==6) Console.WriteLine("Суббота");
else if (num==7) Console.WriteLine("Воскресенье");
