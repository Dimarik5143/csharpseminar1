﻿// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int quontaty(string num)
{
int count = num.Length;
if (num[0] == '-')
{
count -= 1;
}

return count;
}

System.Console.Write("Введите число: ");
string number = Console.ReadLine();
if (int.TryParse(number, out int num))
{
System.Console.WriteLine(quontaty(number));
}
else
{
System.Console.WriteLine("Ошибка. Введите число!");
}