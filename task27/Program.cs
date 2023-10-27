// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sumOfDigits = 0;

        int originalNumber = number;

        while (number > 0)
        {
            int digit = number % 10;
            sumOfDigits += digit;
            number /= 10;
        }

        Console.WriteLine($"Сумма цифр числа {originalNumber} = {sumOfDigits}");