System.Console.Write("Введите число ");
int number = Convert.ToInt32(System.Console.ReadLine());
if(number < 0)
{
    number = -number;
}
int numberNegative = -number;
while(numberNegative <= number)
{
    System.Console.Write($"{numberNegative} ");
    numberNegative++;
}