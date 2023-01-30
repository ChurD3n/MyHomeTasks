
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//Пример [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
void ShowArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
     {
     Console.Write(array[i] + " ");
     }
     Console.WriteLine();
}
int FindEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    if (count == 0) Console.WriteLine("четных чисел не обнаружено");
    return count;
}
Console.Write("input a length of array:");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(length);
ShowArray(newArray);
Console.WriteLine(FindEven(newArray));
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
 
void ShowArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
     {
     Console.Write(array[i] + " ");
     }
     Console.WriteLine();
}


int SumOfArray(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i=i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.Write("input a length of array:");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min value of array:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max value:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, minValue, maxValue);
ShowArray(newArray);

Console.WriteLine(SumOfArray(newArray));
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
 
void ShowArray(int[] array)
{
     for(int i = 0; i < array.Length; i++)
     {
     Console.Write(array[i] + " ");
     }
     Console.WriteLine();
}

int FindMax(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}
int FindMin(int[] array)
{
    int min = 999999;
    for (int i = 0; i < array.Length;i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
Console.Write("input a length of array:");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min value of array:");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max value:");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(length, minValue, maxValue);
ShowArray(newArray);

int a = FindMax(newArray);
int b = FindMin(newArray);
int c = a - b;
Console.WriteLine($"Разница между максимумом и минимумом равна: {c}");
*/