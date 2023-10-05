// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

// int[] GerArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//         Console.Write($"{res[i]} ");
//     }
//     Console.WriteLine();
//     return res;
// }

// Console.Write("Введите число элементов массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент массива ");
// int minArr = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива ");
// int maxArr = Convert.ToInt32(Console.ReadLine());

// int[] arr =GerArray(n, minArr, maxArr);

// int sumPos = 0;
// int sumNeg = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0) sumPos += arr[i];
//     else sumNeg += arr[i];
// }

// Console.WriteLine($"Сумма положительных элементов массива равна {sumPos}");
// Console.WriteLine($"Сумма отрицательных элементов массива равна {sumNeg}");

//----------------------------------------------------------------------------------------
// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] GerArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//         Console.Write($"{res[i]} ");
//     }
//     Console.WriteLine();
//     return res;
// }

// Console.Write("Введите число элементов массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный элемент массива ");
// int minArr = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный элемент массива ");
// int maxArr = Convert.ToInt32(Console.ReadLine());

// int[] arr =GerArray(n, minArr, maxArr);

// for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i]*=-1;
//         Console.Write($"{arr[i]} ");
//     }



//----------------------------------------------------------------------------------------
// Задача 33: Задайте массив. Напишите программу, которая определяет,
//  присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да

// int[] GenerateArray(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(-10, 11);
//     }
//     return array;
// }

// bool CheckArray(int num, int[] array) {
//     // bool result;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (Math.Abs(array[i]) == Math.Abs(num))
//         {
//             return true;
//         }
//     }

//     return false;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write("\b\b]\n");
// }
// Console.Write("Generate an array with length: ");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] array = GenerateArray(length);
// PrintArray(array);
// System.Console.WriteLine(CheckArray(-3, array));

//----------------------------------------------------------------------------------------
// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void FillArray (int[] Mass)
// {
//     int length = Mass.Length;
//     int index = 0;
//     while (index < length) 
//     {
//         Mass[index] = new Random().Next(0, 300);   // до 300
//         //Console.Write($"{Mass[index]} ");
//         index++;
//     }
//     Console.WriteLine();
// }

// void PointsInRules (int[] Massive)
// {
//     int Size = Massive.Length;
//     int index = 0;
//     int result = 0;
//     while (index < Size)
//     {
//         if (Massive[index] > 9 && Massive[index] < 100)
//         {
//             result++;
//         }
//         index++;
//     }
// Console.WriteLine(result);
// }

// int[] array = new int[123];
// FillArray(array);
// PointsInRules(array);





//----------------------------------------------------------------------------------------
// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

// int[] GetArrayNew(int minValue, int maxValue, int size = 4)
// {
//     int[] result = new int[size];

//     if (minValue > maxValue)
//     {
//         int temp = minValue;
//         minValue = maxValue;
//         maxValue = temp;
//     }

//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//         Console.Write($"{result[i]} ");
//     }
//     Console.WriteLine();
//     return result;
// }

// void NewArray(int[] array)
// {
//     int sizeNew = array.Length / 2 + array.Length % 2;    
//     int[] newArray = new int[sizeNew];

//     if(sizeNew % 2 == 1)
//     {
//         newArray[sizeNew - 1] = array[sizeNew - 1];
//     }

//     for (int i = 0; i < newArray.Length - sizeNew % 2; i++)
//     {
//         int temp = array[i] * array[array.Length - 1 - i];
//         newArray[i] = temp;
//     }

//     for (int i = 0; i < newArray.Length; i++)
//     {
//         Console.Write($"{newArray[i]} ");
//     }
//     Console.WriteLine();

// }

// Console.Write("Введите минимальный элемент массива: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите максимальный элемент массива: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] array = GetArrayNew(minValue, maxValue);
// NewArray(array);
