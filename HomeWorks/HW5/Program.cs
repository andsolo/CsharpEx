// //Подсчет количества четных чисел в массиве

// using System;

// public class Answer
// {
//     public static int CountEvenElements(int[] array)
//     { 
//     // Введите свое решение ниже
//       int result = 0;
//       for (int i = 0; i < array.Length; i++)
//       {
//           if (array[i] % 2 == 0)
//           {
//             result++;
//           }
//        }
//        return result;
//     }

//     public static void PrintArray(int[] array)
//     {
//     // Введите свое решение ниже
//     for (int i = 0; i < array.Length; i++)
//     {
//       Console.Write($"{array[i]}\t");
//     }
//     Console.WriteLine();
//     }


// // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         // Не удаляйте строки ниже
//         Console.WriteLine("Массив:");
//         PrintArray(array);
//         int evenCount = CountEvenElements(array);
//         Console.WriteLine($"Количество четных элементов: {evenCount}");
//     }
// }
//--------------------------------------------------

//Сумма элементов с нечетными индексами 
/*
public static int Sum0ddElements (int[] array)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 == 0)
    {
      result = result + array[i];
    }
  }
  return result;
}

public static void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}/t");
  }
}
*/
//--------------------------------------------------

//Программа для работы с массивом из вещественных чисел

// using System;

// public class Answer
// {
//     public static double FindMax(double[] array)
//     {     // Введите свое решение ниже
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//       if (array[i] > max)
//       {
//         max = array[i];
//       }
//     }
//     return max;   
//     }

//     public static double FindMin(double[] array)
//     {     // Введите свое решение ниже
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//       if (array[i] < min)
//       {
//         min = array[i];
//       }
//     }
//     return min;
//     }

//     public static double CalcDifferenceBetweenMaxMin(double[] array)
//     {// Введите свое решение ниже
    
//     double result = FindMax(array) - FindMin(array);
//     return result;
      
//     }

//     public static void PrintArray(double[] array)
//     {// Введите свое решение ниже
//     for (int i = 0; i < array.Length; i++)
//     {
//       Console.Write($"{array[i]}\t");
//     }
//     Console.WriteLine();
//     }
//  // Не удаляйте и не меняйте метод Main! 


//     public static void Main(string[] args)
//     {
//         double[] array;
//         if (args.Length == 0)
//         {
//             array = new double[] { 3, 7.4, 22.3, 2, 78 };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в массив чисел
//             string[] argStrings = args[0].Split(", ");
//             array = new double[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (double.TryParse(argStrings[i], out double number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         Console.WriteLine("Массив:");
//         PrintArray(array);
//         double diff = CalcDifferenceBetweenMaxMin(array);
//         Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
//     }
// }

