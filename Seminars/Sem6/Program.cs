// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Console.Write("Введите размер массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение массива ");
// int minArr = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение массива ");
// int maxArr = Convert.ToInt32(Console.ReadLine());

// void PrintArr(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}\t");
//     }
//     Console.Write("\b\b\b\b\b\b]");
//     Console.WriteLine();
// }

// int[] GenArr(int n, int min, int max)
// {
//     int[] arr = new int[n];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(min, max + 1);
//     }
//     return arr;
// }

// int[] ReversArry(int[] arr)
// {
//     for (int i = 0; i < arr.Length / 2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = temp;
//     }
//     return arr;
// }

// int[] arry = GenArr(n, minArr, maxArr);
// PrintArr(arry);

// int[] arry_revers = ReversArry(arry);
// PrintArr(arry_revers);

////-----------------------------------------------------------------------------------------------
// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,         //переделать!!!
// может ли существовать треугольник с сторонами такой длины

// bool CheckTriangle(int a, int b, int c)
// {
//     if (a < b + c && b < c + a && c < b + a)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

////-----------------------------------------------------------------------------------------------
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число:" );
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// double newn = 0;
// while (n >= 1)
// {
//  newn=n%2*Math.Pow(10, count) + newn;
//  n=n/2;
//  count++;
// }
// Console.WriteLine(newn);

////---------------------------------------------------

// Console.WriteLine("Введите число:" );
// int n = Convert.ToInt32(Console.ReadLine());

// string n2 = "";

// while (n > 0)
// {
//     n2 += Convert.ToString(n % 2);
//     n /= 2;
// }

// for (int i = n2.Length - 1; i >= 0; i--)
// {
//     Console.Write(n2[i]);
// }

////-----------------------------------------------------------------------------------------------
// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[n];
// arr[0] = 0;
// arr[1] = 1;
// for (int i = 2; i < n; i++)
// {
//     arr[i] = arr[i-1] + arr[i-2];
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

// PrintArray(arr);

////-----------------------------------------------------------------------------------------------
// Задача 45: Напишите программу, которая будет создавать копию заданного массива
// с помощью поэлементного копирования.

// int [] CopyArray(int [] array){
// int [] arrayCopy = new int [array.Length];
// for (int i = 0; i < array.Length; i++)
// {
//     arrayCopy[i] = array[i];
//     Console.Write ($"{arrayCopy[i]} ");
// }
// return arrayCopy;
// }    

// int numberForArray = Convert.ToInt32(Console.ReadLine());
// int [] array1 = new int [numberForArray];
// for (int i = 0; i < numberForArray; i++)
// {
//     array1[i] = new Random().Next(0,10);
//     Console.Write($"{array1[i]},");
// }
// Console.Write("\n");

// CopyArray (array1);