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