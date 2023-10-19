// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
System.Console.Write("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    System.Console.WriteLine("Точка находиться в первой четверти");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Точка находиться во второй четверти");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Точка находиться в третьей четверти");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Точка находиться в четвертой четверти");
}
else
{
    System.Console.WriteLine("Точка находиться на оси");
}

// // Write date
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// //Coordinate point
// int QuterTest(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }
// // Print result
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int x = ReadData("Write coordinate X: ");
// int y = ReadData("Write coordinate Y: ");
// int res = QuterTest(x, y);
// PrintResult("Point return" + res);