﻿//Задача 2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*
Console.Write("Введите первое число: ");
double Num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double Num2 = Convert.ToDouble(Console.ReadLine());
if (Num1 != Num2){
    if (Num1 > Num2){
        Console.WriteLine($"Первое число -- {Num1} больше второго числа -- {Num2} ");
    }
    else {
        Console.WriteLine($"Второе число -- {Num2} больше первого числа -- {Num1}");
    }
}
else {
    Console.WriteLine("Числа равны");
}
*/
//----------------------------------------------------------------------------------------
//Задача 4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*
Console.Write("Введите первое число: ");
double Num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double Num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double Num3 = Convert.ToDouble(Console.ReadLine());
double Max = Num1;

if (Num2 > Max) {
     Max = Num2;
}
if (Num3 > Max) {
    Max = Num3;
}
Console.WriteLine($"максимальное число из введенных = {Max}");
*/

//----------------------------------------------------------------------------------------
//Задача 6
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

/*
Console.Write("Введите число: ");
double Num = Convert.ToDouble(Console.ReadLine());
if (Num % 2 == 0){
    Console.Write("Введенное число четное" );
}
else {
    Console.Write("Введенное число нечетное ");
}
*/

//----------------------------------------------------------------------------------------
//Задача 8
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

/*
Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= Num){
    if (i % 2 == 0){
        Console.Write($"{i}, ");
        i++;
    }
    else {
        i++;
    }
}
*/
