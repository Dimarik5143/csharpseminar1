// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
static bool IsPalindrome(int number)
    {
        if (number < 10000 || number > 99999)
        {
            Console.Write("Число не пятизначное");
            //Console.WriteLine("False");
            return false;
        }

        int originalNumber = number;
        int reversedNumber = 0;

        while (number > 0)
        {
            int digit = number % 10;
            reversedNumber = reversedNumber * 10 + digit;
            number = number / 10;
        }

        return originalNumber == reversedNumber;
    }

        Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPalindrome = IsPalindrome(number);

        if (isPalindrome)
        {
            Console.Write("True.");
        }
        else
        {
            Console.Write("False.");
        }