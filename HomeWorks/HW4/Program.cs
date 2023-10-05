// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write ("Введите число: ");
// int NumA = Convert.ToInt32(Console.ReadLine());
// Console.Write ("Введите его степень: ");
// int NumB = Convert.ToInt32(Console.ReadLine());
// int count = 2;
// int result = NumA;
// while (count <= NumB){
//     result = result * NumA;
//     count ++;
// }
// Console.Write ($"Число {NumA} в степени {NumB} равно {result}");

//----------------------------------------------------------------------------------------
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write ("Введите число: ");
// String StrNum = Console.ReadLine(); // Считывает число в строку StringNumber
// Char[]ChrNum = StrNum.ToCharArray(); // Переводим строку StringNumber в Массив символов CharNumber[]
// int sum = 0;
// for (int i = 0; i < StrNum.Length; i++)
//     {
//         sum += Convert.ToInt32(StrNum[i]-'0');    // Convert.ToInt32 переводит символ в число (точней сказать в юникод числа, 
//                                                         // поэтому мы отнимаем -'0' для того чтобы из юникода получить число)            
//     }
// Console.WriteLine($"Сумма цифр равна {sum}");

//----------------------------------------------------------------------------------------
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Write("Введите минимальное возможное число в массиве: ");
// int Num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное возможное число в массиве: ");
// int Num2 = Convert.ToInt32(Console.ReadLine());

// void FillArray (int[] Massive)
// {
//     int length = Massive.Length;
//     int index = 0;
//     while (index < length) 
//     {
//         Massive[index] = new Random().Next(Num1, Num2); 
//         index++;
//     }
// }

// void PrintArray (int[] Mas)
// {
//     int Size = Mas.Length;
//     int position = 0;
//     while (position < Size) 
//     {
//         Console.Write($"{Mas[position]} ");
//         position++;
//     }
// }

// int[] array = new int[8];
// FillArray (array);
// PrintArray (array);