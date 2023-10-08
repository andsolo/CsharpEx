//Задача 41. Пользователь вводит с клавиатуры M чисел.
//Посчитайте сколько чисел болльше нуля ввел пользователь.
// Console.Write("Введите числа")
// void FillArray (int[] array)
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// void PrintArray (int[] array)
// {
//     for (int i =0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}\t");
//     }
//     Console.WriteLine();
// }

// void NumbersGreaterThanZero (int[] array) //Метод получения количества чисел больше нуля
// {
//   int result = 0;
//   for(int i = 0; i < array.Length; i++)
//   {
//     if (array[i] > 0) result++;
//   }
//   Console.WriteLine($"Вы ввели {result} чисел больше нуля");
// }

// int[] Mass = new int[5];
// Console.WriteLine("Введите пять чисел: ");
// FillArray (Mass);
// PrintArray (Mass);
// NumbersGreaterThanZero (Mass);




//--------------------------------------------------
//Задача 43. Напишите программу которая найдет точку пересечения двух прямых, 
//заданных уравнениями y=k1*x+b1, y=k2*X+b2;
//Значения b1, k1, b2, k2 задаются пользователем.
// double FillParam (double a, double b, double c, double d)
// {
//     Console.WriteLine("Введите переменную b1: ");
//     double b1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите переменную k1: ");
//     double k1 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите переменную b2: ");
//     double b2 = Convert.ToDouble(Console.ReadLine());
//     Console.WriteLine("Введите переменную k2: ");
//     double k2 = Convert.ToDouble(Console.ReadLine());
// }
// double x = (b1 - b2 )/ (k2 - k1);
// double y = (k2 * x) + b1;
// Console.WriteLine($"Точка пересечения двух прямых: [{x},{y}]");
//--------------------------------------------------

/////////////   Способ решения через методы:

// void FillArray (double[] array) // Вводим b1, k1, b2, k2
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = Convert.ToDouble(Console.ReadLine());
//     }
// }

// void LineIntersecrion (double[] array)
// {
//     double x = (array[0] - array[2])/ (array[3] - array[1]);
//     double y = (array[3] * x) + array[2];
//     Console.WriteLine($"Точка пересечения двух прямых: [{x},{y}]");
// }

// double[] Lines = new double[4]; // массив хранения переменных b1, k1, b2, k2
// Console.WriteLine ("Введите b1, k1, b2, k2:");
// FillArray (Lines);
// LineIntersecrion (Lines);
