//Напишите программу, 
//которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
/*
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int str = number * number;

// Вывод построчно
Console.Write("Квадрат числа ");
Console.Write(number);
Console.Write(" равен = ");
Console.Write(str);
Console.WriteLine();

//Вывод с использованием $
Console.WriteLine($"Квадрат числа {number} равен {str}");

//Вывод с обращением к переменным 
Console.WriteLine("Квадрат числа {0} равен = {1} ", number, str);

//Вывод с использованием библиотеки Math
int sqr = Convert.ToInt32(Console.ReadLine());
double sqrt_2 = Math.Pow(sqr, 2);
Console.WriteLine("Квадрат числа {0} равен = {1} ", sqr, sqrt_2 );
*/
//______________________________________________________________________

/*
//Задача №1. Напишите программу,
//которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет

Console.Write("Введите число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());

if (Num1 * Num1 == Num2) {
    Console.WriteLine("Число 2 является квадратом 1 числа");
}
else {
    Console.WriteLine("Число 2 не является квадратом 1 числа");
}
*/
//______________________________________________________________________
/*
//Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите число от 1 до 7 ");
int Num = Convert.ToInt32(Console.ReadLine());

if (Num == 1){
    Console.WriteLine("Это понедельник");
}
if (Num == 2){
    Console.WriteLine("Это вторник");
}
if (Num == 3){
    Console.WriteLine("Это среда");
}
if (Num == 4){
    Console.WriteLine("Это четверг");
}
if (Num == 5){
    Console.WriteLine("Это пятнница");
}
if (Num == 6){
    Console.WriteLine("Это суббота");
}
if (Num == 7){
    Console.WriteLine("Это воскресенье");
}
else {
    Console.WriteLine("число не в интервале");
}
*/
//______________________________________________________________________
/*
//Задача №5. Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"

Console.WriteLine("Введите число");
int Num = Convert.ToInt32(Console.ReadLine());
int i = -Num;
while (i <= Num) {
    Console.WriteLine(i);
    i++;
}
*/
//______________________________________________________________________

//Задача №7. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
//	456 -> 6
//	782 -> 2
//	918 -> 8

/*
//решение 1
System.Console.WriteLine("Введите число: ");
int N=Convert.ToInt32(Console.ReadLine());
int ostatok=N%10;

System.Console.WriteLine(ostatok);
*/
//решение 2
/*
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
int amount = number.Length;

if (amount != 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(number.Substring(amount-1));
}
*/
