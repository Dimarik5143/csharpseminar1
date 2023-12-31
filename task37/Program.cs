﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int size = GetNumber("Введите размер массива: ");
//         int[] array = new int[size];

//         FillArray(array);
//         Console.WriteLine($"Сгенерированный массив: [{string.Join(", ", array)}]");

//         int[] productArray = new int[array.Length / 2 + array.Length % 2];

//         for (int i = 0; i < array.Length / 2; i++)
//         {
//             productArray[i] = array[i] * array[array.Length - 1 - i];
//         }

//         if (array.Length % 2 != 0)
//         {
//             productArray[productArray.Length - 1] = array[array.Length / 2];
//         }

//         Console.Write("Произведения пар: [");

//         for (int i = 0; i < productArray.Length; i++)
//         {
//             Console.Write(productArray[i]);

//             if (i < productArray.Length - 1)
//             {
//                 Console.Write(" ");
//             }
//         }

//         Console.WriteLine("]");

//     static void FillArray(int[] arr)
//     {
//         Random random = new Random();
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = random.Next(-9, 10);
//         }
//     }

//     static int GetNumber(string msg)
//     {
//         Console.Write(msg);
//         return Convert.ToInt32(Console.ReadLine());
//     }

// int[] FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 10);
//     }

//     return arr;
// }

// int GetNumber(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int[] array = new int[GetNumber("Введите количество элементов массива: ")];

// array = FillArray(array);
// System.Console.WriteLine($"[{string.Join(", ", array)}]");

// if (array.Length%2 == 0)
// {
//     int newLength = array.Length/2;
//     int[] newArr = new int[newLength];
//     int index1 = 0;
//     int index2 = array.Length - 1;
//     for (int i = 0; i < newLength; i++)
//     {
//         newArr[i] = array[index1]*array[index2];
//         index1++;
//         index2--;
//     }
//     System.Console.WriteLine($"[{string.Join(", ", newArr)}]");
// }
// else
// {
//     int newLength = array.Length/2 + 1;
//     int[] newArr = new int[newLength];
//     int index1 = 0;
//     int index2 = array.Length - 1;
//     for (int i = 0; i < newLength; i++)
//     {
//         newArr[i] = array[index1]*array[index2];
//         index1++;
//         index2--;
//     }
//     newArr[newLength - 1] = array[newLength - 1];
//     System.Console.WriteLine($"[{string.Join(", ", newArr)}]");
// }

int[] FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }

    return arr;
}

int GetNumber(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] array = new int[GetNumber("Введите количество элементов массива: ")];

array = FillArray(array);
System.Console.WriteLine($"[{string.Join(", ", array)}]");

int newLength = array.Length / 2 + array.Length % 2;
int[] newArr = new int[newLength];

for (int i = 0; i < array.Length / 2; i++)
{
    newArr[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length % 2 == 1)
{
    newArr[newArr.Length - 1] = array[array.Length / 2];
}

System.Console.WriteLine($"[{string.Join(", ", newArr)}]");