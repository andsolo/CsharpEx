// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.Write("Введите число X: ");
// int x = int.Parse(Console.ReadLine());
// Console.Write("Введите число Y: ");
// int y = int.Parse(Console.ReadLine());

// if (x > 0 && y > 0){
//     Console.WriteLine(1);
// }
// else if (y > 0 && x < 0){
//     Console.WriteLine(2);
// }
// else if (x < 0 && y < 0){
//     Console.WriteLine(3);
// }
// else if (x > 0 && y < 0){
//     Console.WriteLine(4);
// }
// else {
//     Console.WriteLine("Введены нули");
// }

//---------------------------------------------------------
// Задача №18. Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int x = int.Parse(Console.ReadLine());
// if (x == 1){
//     Console.WriteLine("x > 0 && y > 0");
// }
// else if (x == 2){
//     Console.WriteLine("x < 0 && y > 0");
// }
// else if (x == 3){
//     Console.WriteLine("x < 0 && y < 0");
// }
// else if (x == 4){
//     Console.WriteLine("x > 0 && y < 0");
// }
// else {
//     Console.WriteLine("Число не в диапазоне");
// }

///// ЧЕРЕЗ SWITCH

// Console.Write("Введите номер четверти, по которой хотите получить координаты: ");
// int number = int.Parse(Console.ReadLine());

// switch (number)
// {
//     case 1:
//     {
//        Console.WriteLine("В первой четверти значения х > 0, y > 0");
//        break; 
//     }
//     case 2:
//     {
//         Console.WriteLine("В первой четверти значения х < 0, y > 0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("В первой четверти значения х < 0, y < 0");
//         break;
//     }
//     case 4:
//     {
//        Console.WriteLine("В первой четверти значения х > 0, y < 0");
//        break;
//     }
    
//     default:
//     {
//         Console.WriteLine("Значение не верное");
//         break; 
//     }
// }

//---------------------------------------------------------
// Задача №20. Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Введите координаты Х, точки А: ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты Y, точки А: ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты Х, точки B: ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координаты Y, точки B: ");
// int y2 = int.Parse(Console.ReadLine());

// double c = Math.Sqrt (Math.Pow((x1 - y1), 2) + Math.Pow((x2 - y2), 2));

// System.Console.WriteLine($"Расстояние между координатами: {c}");

//---------------------------------------------------------
// Задача №22. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++)
// {
//     double powI = Math.Pow(i, 2);
//     Console.Write($"{powI}, ");
// }
// Console.Write("\b\b ");