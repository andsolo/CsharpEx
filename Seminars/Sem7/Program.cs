 //Задача 46: Задайте двумерный массив размером m x n, заполненный случайными целыми числами.
 // m = 3; n = 4.

// Console.Write("Введите размер м: ");            //строки
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");            //столбцы
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(-9, 10);
//     }
// }

// void PrintArr (int[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArr(arr);

//--------------------------------------------------------------------------------

// Console.Write("Введите размер м: ");            //строки
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");            //столбцы
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] arr = new double[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(-9, 10) + Math.Round(new Random().NextDouble(), 2);
//     }
// }

// void PrintArr (double[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArr(arr);

//--------------------------------------------------------------------------------

// Console.Write("Введите размер м: ");            //строки
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");            //столбцы
// int n = Convert.ToInt32(Console.ReadLine());

// double[,] arr = new double[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(-9, 10) + new Random().NextDouble();
//     }
// }

// void PrintArr (double[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write(string.Format("{0:0.00}\t", arry[i,j]));   //вывод числа в нужном формате 0.00
//         }                       //или: ($"{arry[i,j]:f2}\t");
//         Console.WriteLine();
//     }
// }

// PrintArr(arr);

//--------------------------------------------------------------------------------
//Задача 48: Задайте двумерный массив размера М на Н, каждый элемент которого 
//находится по формуле Амн = М + Н.
//Выведете полученный массив на экран

// Console.Write("Введите размер м: ");            //строки
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");            //столбцы
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = i + j;
//     }
// }

// void PrintArr (int[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArr(arr);

//--------------------------------------------------------------------------------
//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса четные
//и замените эти элементы на их квадраты 

// Console.Write("Введите размер м: ");            //строки
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");            //столбцы
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(4, 10);
//     }
// }

// void PrintArr (int[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void Sqr (int[,] mass)
// {
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for(int j = 0; j < mass.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             { 
//                 mass[i,j] *= mass[i,j];
//             }
//         }
//     }
// }

// Sqr(arr);
// PrintArr(arr);

//--------------------------------------------------------------------------------
//Задача 51: Задайте двумерный массив. Найдите сумму элементов,
//находящихся на главной диагонали (с индексами(0,0); (1;1) и т.д.)

// Console.Write("Введите размер м: ");            //строки
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");            //столбцы
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(1, 10);
//     }
// }

// void PrintArr (int[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i,j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void FindDia (int [,] mass)
// {
//     int res = 0;
//     for (int i = 0; i < mass.GetLength(0); i++)
//     {
//         for (int j = 0; j < mass.GetLength(1); j++)
//         {
//             if (i == j) res += mass[i,j];
//         }
//     }
//     Console.WriteLine($"Сумма элементов по главной диаганали = {res}.");
// }

// PrintArr(arr);
// FindDia(arr);