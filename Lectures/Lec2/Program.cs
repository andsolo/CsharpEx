 /*
 int Max (int arg1, int arg2, int arg3)
 {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
 }

 int a1 = 15;
 int b1 = 20;
 int c1 = 39;
 
 int a2 = 12;
 int b2 = 2311;
 int c2 = 33;
 
 int a3 = 13;
 int b3 = 23;
 int c3 = 313;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine (max);
*/
//----------------------------------------------------------------

//  Массивы
//  -------

/*
 int Max (int arg1, int arg2, int arg3)
 {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
 }

int [] array ={11, 52, 83, 64, 35, 56, 37, 58, 69};
//array[0] = 12; -- присвоение индексу массива нового значения
//Console.WriteLine(array[4]); -- вывод индекса массива
 int result = Max(
    Max(array[0], array[1], array[3]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );

    Console.WriteLine(result);
*/
//------------------------------------------------------------------

/*
int [] array = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19};
int n = array.Length;
int find = 10;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;    
}
*/

//------------------------------------------------------------------
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)

{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int indexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}


int [] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = indexOff(array, 4);
Console.WriteLine(pos);
