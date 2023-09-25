// цикл  for

/*
for (int i = 0; i <= 5; i++)
    {
        Console.Write($"{i}, ");
    }
Console.Write("\b\b ");
*/

//---------------------------------------------------------

// Напишите программу,
// которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10, 100);

// int a1 = num / 10;
// int a2 = num % 10;

// int max = a1;

// if (max < a2)
// {
//     max = a2;
// }
// Console.WriteLine($" Наибольшая цифра числа {num} -> {max}");

//---------------------------------------------------------

// Задача №11. Работа в группах
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(10, 1000);
// int a1 = num / 100;
// int a3 = num %10;

// Console.WriteLine($"{num} - {a1}{a3}");

//---------------------------------------------------------

//Задача №12. Работа в группах
//Напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

// Console.WriteLine ("Enter your first number ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( "Enter your second number");
// int b1 = Convert.ToInt32(Console.ReadLine());
// if (b1%a1 == 0){
//     Console.WriteLine ("Your numbers are multiples");
// } else {
//     Console.WriteLine ($"Your numbers are not multiples, your remainder is {a1 % b1}");
//     Console.WriteLine ("Your numbers are not multiples");
// }

//---------------------------------------------------------

//&&
// Задача №14. Работа в группах
// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine ("Enter your first number ");
// int a1 = Convert.ToInt32(Console.ReadLine());

// if (a1 % 7 == 0 && a1 % 23 == 0) {
//     Console.WriteLine ("число кратно 7 и 23");
// }
// else Console.WriteLine ("число не кратно условию задачи");

// Задача №16. Работа в группах
// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.WriteLine ("Enter your first number ");
// int a1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine( "Enter your second number");
// int b1 = Convert.ToInt32(Console.ReadLine());

// if (a1 * a1 == b1 || b1 * b1 == a1)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }