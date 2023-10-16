// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
System.Console.WriteLine($"Наше случайное число = {number}");
int digit1 = number/10; // 78/10 = 7,8 -> 7
int digit2 = number%10; // 78%10 = 78/10 = 7.8 остается 8
if(digit1 > digit2)
{
    System.Console.WriteLine(digit1);
}
else if(digit1 < digit2)
{
    System.Console.WriteLine(digit2);
}
else
{
    System.Console.WriteLine("Цтфры равны");
}