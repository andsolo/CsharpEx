// Задача1. Построчная сортировка матрицы по убыванию

// using System;

// public class Answer
// {
//     public static void PrintMatrix(int[,] matrix)
//     {
//         // Введите свое решение ниже
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i,j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }
//     public static void SortRowsDescending(int[,] matrix)
//     {
//         // Введите свое решение ниже
        
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 for (int w = j + 1; w < matrix.GetLength(1); w++)
//                 {
//                     if (matrix[i,j] < matrix[i,w])
//                     {
//                         int temp = matrix[i,j];
//                         matrix[i,j] = matrix[i,w];
//                         matrix[i,w] = temp;
//                     }
//                 }
//             }
//         }   
//     }


// // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,] {
//                 {5, 2, 9},
//                 {8, 1, 4},
//                 {6, 7, 11}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 if (elements.Length != matrix.GetLength(1))
//                 {
//                     Console.WriteLine($"Ошибка: Неправильное количество элементов в строке {i + 1}.");
//                     return;
//                 }
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         PrintMatrix(matrix);

//         SortRowsDescending(matrix);

//         Console.WriteLine("\nМатрица с упорядоченными по убыванию строками:");
//         PrintMatrix(matrix);
//     }
// }

//------------------------------------------------------------------------------------------------
//задача 2
//using System;

// public class Answer
// {
//     public static int SumOfRow(int[,] matrix, int row)
//     {
// // Введите свое решение ниже
//     int Sum = 0;
//     for (int j = 0; j < matrix.GetLength(0); j++) Sum += matrix[row,j];
//     Sum /= matrix.GetLength(0);
//     return Sum;
//     }

//     public static int[] MinimumSumRow(int[,] matrix)
//     {
//     // Введите свое решение ниже
//         int[] SumOfString = new int[matrix.GetLength(1)];
        
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             int Sum = 0;
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Sum += matrix[i,j];
//             }
//             SumOfString[i] = Sum;
//             Console.WriteLine(SumOfString[i]);
//         }

//         int[] PositionAndSum = new int[2];
        
//         PositionAndSum[0] = 0;
//         PositionAndSum[1] = SumOfString[0];
        
//         int min = SumOfString[0];
//         int k = 0;
//         while (k < matrix.GetLength(0))
//         {
//             if (SumOfString[k] < min)
//             {
//                 min = SumOfString[k];
//                 PositionAndSum[0] = k;
//                 PositionAndSum[1] = SumOfString[k];
//                 k++;
//             }
//             else k++;
//         }
//         return PositionAndSum;
//     }
//  // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[,] matrix;
//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,]
//             {
//                 {9, 0, 0},
//                 {2, 1, 2},
//                 {0, 0, 1}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 Console.Write($"{matrix[i, j]}\t");
//             }
//             Console.WriteLine();
//         }

//         int[] minSumRow = MinimumSumRow(matrix);

//         Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");
//     }
// }

//------------------------------------------------------------------------------------------------
//задача 3

// using System;

// public class Answer
// {
//     public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
//     {
//         int numColsA = matrixA.GetLength(1);
//         int numRowsB = matrixB.GetLength(0);

//         if (numColsA != numRowsB)
//         {
//             Console.WriteLine("It is impossible to multiply.");
//         }
//         else
//         {
//             int[,] result = MatrixMultiplication(matrixA, matrixB);
//             PrintMatrix(result);
//         }
//     }

//     public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
//     {
//         int numRowsA = matrixA.GetLength(0);
//         int numColsA = matrixA.GetLength(1);
//         int numColsB = matrixB.GetLength(1);

//         int[,] result = new int[numRowsA, numColsB];

//         for (int i = 0; i < numRowsA; i++)
//         {
//             for (int j = 0; j < numColsB; j++)
//             {
//                 int sum = 0;

//                 for (int k = 0; k < numColsA; k++)
//                 {
//                     sum += matrixA[i, k] * matrixB[k, j];
//                 }

//                 result[i, j] = sum;
//             }
//         }

//         return result;
//     }

//     public static void PrintMatrix(int[,] matrix)
//     {
//         int numRows = matrix.GetLength(0);
//         int numCols = matrix.GetLength(1);

//         for (int i = 0; i < numRows; i++)
//         {
//             for (int j = 0; j < numCols; j++)
//             {
//                 Console.Write(matrix[i, j] + "\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     public static void Main(string[] args)
//     {
//         int[,] matrix;

//         if (args.Length == 0)
//         {
//             // Если аргументы не переданы, используем матрицу по умолчанию
//             matrix = new int[,]
//             {
//                 {5, 2},
//                 {8, 1}
//             };
//         }
//         else
//         {
//             // Иначе, парсим аргументы в двумерный массив
//             string[] rows = args[0].Split(';');
//             matrix = new int[rows.Length, rows[0].Split(',').Length];
//             for (int i = 0; i < rows.Length; i++)
//             {
//                 string[] elements = rows[i].Split(',');
//                 for (int j = 0; j < elements.Length; j++)
//                 {
//                     if (int.TryParse(elements[j], out int number))
//                     {
//                         matrix[i, j] = number;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
//                         return;
//                     }
//                 }
//             }
//         }

//         Console.WriteLine("Исходная матрица:");
//         PrintMatrix(matrix);

//         int[,] matrixB = {
//             {5, 6},
//             {7, 8}
//         };

//         Console.WriteLine("\nMatrix B:");
//         PrintMatrix(matrixB);

//         Console.WriteLine("\nMultiplication result:");

//         MultiplyIfPossible(matrix, matrixB);
//     }
// }