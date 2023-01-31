

//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2


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
int[] CreateArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        Console.Write("введите число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}
int HowManyNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.Write("input a length of array:");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArray(length);
ShowArray(newArray);
int itog = HowManyNum(newArray);
Console.WriteLine("Колличество чисел больше нуля: " + itog);
*/
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
decimal Calculate(int b1, int k1, int b2, int k2)
{
    decimal y = 0;
    for (decimal x = decimal.MinValue; x < decimal.MaxValue; x= x +      )
    {
       decimal y1 = k1 * x + b1;
       decimal y2 = k2 * x + b2;
       if ( y1 == y2 )  y = y1 ;
    }
    return y;
}

Console.WriteLine("введите значения переменных для уравнений: y = k1 * x + b1, y = k2 * x + b2 ");
Console.Write(" введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write(" введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
bool res = Calculate(b1, k1, b2,  k2);
Console.WriteLine($"result:" + res );
*/