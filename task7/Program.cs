System.Console.Write("Введите число ");
int number = Convert.ToInt32(System.Console.ReadLine());
if(number >= 100 && number <= 999)
{
    int digitlast = number % 10;
    System.Console.Write(digitlast);
}
else
{
    System.Console.WriteLine("Введите трехзначное число");
}