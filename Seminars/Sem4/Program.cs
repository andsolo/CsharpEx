// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write($"Введите чило А: ");
// int a = int.Parse(Console.ReadLine());

// int Sum(int limit)
// {
//     int sum = 0;
//     for (int i = 1; i <= limit; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");

// ----------------------------------------------------------------
// Console.Write($"Введите чило А: ");
// int a = int.Parse(Console.ReadLine());

// int Sum(int limit)
// {
//     int sum = 0;
//     for (int i = 1; i <= limit; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine($"Сумма чисел от 1 до {a} равна {Sum(a)}");

// ----------------------------------------------------------------
// void Mass(int col)
// {
//     int[] arry = new int[col];

//     for (int i = 0; i < arry.Length; i++)
//     {
//         arry[i] = Convert.ToInt32(Console.ReadLine());
//     }

//     Console.WriteLine("_________________");

//     for (int i = 0; i < arry.Length; i++)
//     {
//         Console.Write($"{arry[i]} ");
//     }
// }
// Console.Write("Ввести длину массива ");
// int n = Convert.ToInt32(Console.ReadLine());
// Mass(n);

// ----------------------------------------------------------------
// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Пожалуйста, введите число: ");
// int number = int.Parse(Console.ReadLine());

// int CountNumber (int number)
// {
//     int count = 1;
//     while (number > 10)
//     {
//         number /= 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine($"Количество цифр в числе {number} равно {CountNumber(number)}");

// ----------------------------------------------------------------
// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Пожалуйста, введите число: ");
// int number = int.Parse(Console.ReadLine());

// int CountNumber (int number)
// {
//     int count = 1;
//     while (number > 10)
//     {
//         number /= 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine($"Количество цифр в числе {number} равно {CountNumber(number)}");

// ----------------------------------------------------------------
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void MassRandom(int col)
// {
//     int[] array = new int[col];
//     Console.Write($"[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 2);
//         Console.Write($"{array[i]}, ");
//     }
//     Console.Write($"\b\b]");
// }

// Console.Write("Введите длину массива: ");
// int arrayLength = Convert.ToInt32(Console.ReadLine());
// MassRandom(arrayLength);
// Console.WriteLine();