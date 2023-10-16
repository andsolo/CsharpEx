// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// void Print (int M, int N)
// {
//      if(M!=N+1) 
//      {
//           Console.Write($"{M} ");
//           Print(M + 1, N);
//      }
// }

// System.Console.Write("Введите M: ");
// int M=Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите N: ");
// int N=Convert.ToInt32(Console.ReadLine());

// Print(M,N);4
//-----------------------------------------------------------------------------
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int SumNum(int N)
// {
//      if (N == 0) return N;
//      return N%10+SumNum(N/10);
// }

// System.Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// N=SumNum(N);
// System.Console.WriteLine(N);

//-----------------------------------------------------------------------------
// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

// Console.Write("Ввидите число a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввидите число b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Pow(int a, int b)
// {
//     if (b == 0) return 1;
//     if (b == 1) return a;
//     return a*Pow(a, b-1);
    
// }

// Console.WriteLine(Pow(a, b));
//-----------------------------------------------------------------------------