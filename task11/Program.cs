// Напишите программу, которая выводит любое
// трёхзначное число и на выходе удаляет вторую
// цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);
int number1 = number/100;
int number3 = number%10;
int number4 = number1*10+number3;
System.Console.Write(number4); //System.Console.Write($"{number1}{number3}");