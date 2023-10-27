﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

        Console.WriteLine("Введите 8 целых чисел:");

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Массив: [");

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);

            if (i < array.Length - 1)
            {
                Console.Write(", ");
            }
        }

        Console.WriteLine("]");