// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array = {"Hello", "2", "world", ":-)"};
int length = array.Length;
List<string> NewArray = new List<string>();


for (int i = 0; i < length; i++)
{
    if (array[i].Length <= 3){
        NewArray.Add(array[i]);
    }
}

foreach (var count in NewArray)
{
    Console.Write($"'{count}' ");
}
Console.WriteLine();