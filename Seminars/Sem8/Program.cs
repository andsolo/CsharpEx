//Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите размер m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(-9,10);
//     }
// }

// void PrintArr(int[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArr(arr);

// int [,] Change (int [,] array)
// {   
//     int temp;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         temp = array[0, i];
//         array [0, i] = array [array.GetLength(0) - 1, i];
//         array [array.GetLength(0) - 1, i] = temp;
//     }
//     return array;
// }

// int[,] array = Change(arr);

// Console.WriteLine();
// PrintArr(array);

//--------------------------------------------------------------------------------
// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

// Console.Write("Введите размер m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размер n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[m, n];

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i, j] = new Random().Next(-9,10);
//     }
// }

// int[,] TranspArray(int[,] array) 
// {
//     // int[,] result = new int[array.GetLength(1),array.GetLength(0)];
    
//     int temp = Int32.MaxValue;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = i; j < array.GetLength(1); j++)
//         {
//             temp = array[i,j];
//             array[i,j] = array[j,i];
//             array[j,i] = temp;
//         }
//     }
//     return array;
// }

// void PrintArr(int[,] arry)
// {
//     for (int i = 0; i < arry.GetLength(0); i++)
//     {
//         for (int j = 0; j < arry.GetLength(1); j++)
//         {
//             Console.Write($"{arry[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// PrintArr(arr);
// Console.WriteLine();


// if (n == m)
// {
//     PrintArr(TranspArray(arr));
// }
// else
// {
//     Console.WriteLine("m != n");
// }

//--------------------------------------------------------------------------------

Console.Write("Введите min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[5, 2];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(min, max);
    }
}

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void ReadSum (int[,] arr, int min, int max)
{
    int coll = 0;
    for (int count = min; count <= max; count++)
    { 
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
               if (arr[i,j] == count) coll++;
            }               
        }
    Console.WriteLine($"Число {count} встретилось {coll} раз");
    }
}
 
 PrintArr(arr);
 ReadSum(arr);