// Задача 19. Напишите программу, которая принимает на вход
// пятизначное число и проверяет является ли оно полиндромом // a, b, c, d, e

// Console.Write("Введите пятизначное число: ");
// int Num = Convert.ToInt32(Console.ReadLine());

// int a = Num / 10000;
// int b = (Num / 1000) % 10;
// int c = ((Num / 100) % 100) % 10;
// int d = (Num / 10) % 10;
// int e = Num % 10;

// if (a == e && b == d){
//     Console.Write(" да ");
// }
// else {
//     Console.Write(" нет ");
// }

//------------------------------------------------------------
// Задача 23. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// Console.Write("Введите координаты Х, точки А: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Y, точки А: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Z, точки А: ");
// int zA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты Х, точки B: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Y, точки B: ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты Z, точки B: ");
// int zB = Convert.ToInt32(Console.ReadLine());

// double c = Math.Sqrt (Math.Pow((xA - xB), 2) + Math.Pow((yA - yB), 2)+ Math.Pow((zA - zB), 2));
// System.Console.WriteLine(c);

//------------------------------------------------------------
// Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.

// Console.Write("Введите число: ");
// int Num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= Num){
//     Console.Write($"{Math.Pow(count, 3)}, ");
//     count++;
// }
// Console.Write("\b\b ");