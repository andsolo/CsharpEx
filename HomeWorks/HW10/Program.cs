//Задача 64: Задайте значение N. Напишите программу, которая
//выведет все натуральные числа в промежутке от N до единицы.

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// string NumberRec(int a)
// {
//   if (a >= 1) return $"{a} " + NumberRec(a - 1);
//   else return String.Empty;
// }

// Console.WriteLine(NumberRec(a));

// NumberRec(a);

//------------------------------------------------------------------
//Задача 66: Задайте значения М и Н. Напишите программу, которая
//найдет сумму натуральных элементов в промежутке от М до Н.

// Console.Write("Введите начальное число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите конечное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int SumNumbers (int m, int n)
// {
//   if (m <= n) return m + SumNumbers(m+1, n);
//   else return 0;
// }

// Console.WriteLine(SumNumbers(m,n));

//------------------------------------------------------------------
// Задача 68: Напишите программу функций вычисления Аккермана с помощью рекурсии.
// Даны два неотрицательных числа М и Н.

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int akkerman(int m, int n)
// {
// if (m == 0) return n + 1;
// else if (n == 0) return akkerman(m - 1, 1);
// else return akkerman(m - 1, akkerman(m, n - 1));
// }

// Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");
