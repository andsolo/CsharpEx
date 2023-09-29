//Внутри класса Answer напишите метод DistanceBetweenPoints,
//который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
//и возвращает расстояние между ними в 3D пространстве

using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
        int[] args = new int[6];
        int x1 = args[0];
        int x2 = args[1];
        int x3 = args[2];
        int y1 = args[3];
        int y2 = args[4];
        int y3 = args[5];

        double result = Math.Sqrt (Math.Pow((x1 - y1), 2) + Math.Pow((x2 - y2), 2)+ Math.Pow((x3 - y3), 2));
        return result;

    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}

//------- простой вариант решения:------------

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









































//----------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------
//----------------------------------------------------------------------------------------------------------------------------

// Задача 19. Напишите программу, которая принимает на вход
// пятизначное число и проверяет является ли оно полиндромом // a, b, c, d, e

// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//       if (number > 9999 && number < 100000){
//         int a = number / 10000;
//         int b = (number / 1000) % 10;
//         //int c = ((number / 100) % 100) % 10;
//         int d = (number / 10) % 10;
//         int e = number % 10;
//         if (a == e && b == d){
//             return true;
//         }
//         else {
//             return false;
//         }
//       }
//       else {
//         Console.WriteLine("Число не пятизначное");
//         return false;
//       }
//     }
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 234322;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }

//------- простой вариант решения:------------
// Console.Write("Введите пятизначное число: ");
// int Num = Convert.ToInt32(Console.ReadLine());

// int a = number / 10000;
// int b = (number / 1000) % 10;
// int c = ((number / 100) % 100) % 10;
// int d = (number / 10) % 10;
// int e = number % 10;

//if (a == e && b == d) return true;
//{
//     Console.Write(" да ");
// }
//else return false;
//     Console.Write(" нет ");
// }

//----------------------------------------------------------------------------------------------------------------------------

// Внутри класса Answer напишите метод ShowCube,
// который принимает на вход число (N) 
// и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

// using System;

// public class Answer
// {
//    static void ShowCube(int N)
//     {
//       // Введите свое решение ниже
//         int count = 1;
//         while (count <= N){
//         Console.WriteLine($"{Math.Pow(count, 3)}");
//         count++;
//         }  
//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 5;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }

//------- простой вариант решения:------------
// Console.Write("Введите число: ");
// int Num = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= Num){
//     Console.Write($"{Math.Pow(count, 3)}, ");
//     count++;
// }
// Console.Write("\b\b ");