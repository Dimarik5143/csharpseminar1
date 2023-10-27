//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите число A: ");
        double A = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите степень B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        double result = 1;

        if (B > 0)
        {
            for (int i = 1; i <= B; i++)
            {
                result *= A;
            }
        }
        else if (B < 0)
        {
            for (int i = 1; i <= -B; i++)
            {
                result /= A;
            }
        }

        Console.WriteLine($"{A}^{B} = {result}");