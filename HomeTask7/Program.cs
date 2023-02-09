/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);

        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/
//1)каждый элемент находится по формуле a+j 


/*
int[,] Create2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

     int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            array[i,j] = i + j ;

        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

int[,] newArray = Create2dArray();
Show2dArray(newArray);
*/
//2)найти элементы на четных позициях  и заменить их на собственные квадраты
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);

        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}
int[,] ChangeArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
    {
        for(int j = 0; j < array.GetLength(1);j+=2)
        array[i,j] *= array[i,j]; 
        
    }
return array;    
}
Console.Write("input a number of rows: "); 
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(newArray);
int[,] NEWarray = ChangeArray(newArray);
Console.WriteLine();
Show2dArray(NEWarray);
*/
//3) Сумма элементов диагонали 
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);

        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}
int SumOfDiag(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0) && i < array.GetLength(1) ; i++)
    {
     sum+= array[i,i];
        
    }

    return sum;    
}
Console.Write("input a number of rows: "); 
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("input a min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("input a max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] newArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(newArray);
Console.WriteLine("sum: " + SumOfDiag(newArray));
*/
//ДЗ7 
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min value: ");


    double[,] array = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(-100, 100)/10.0;

        }
    }
    return array;
}
void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

double[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);

        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}
int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
Console.WriteLine("enter i");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter j");
int b = Convert.ToInt32(Console.ReadLine());


if (a > newArray.GetLength(0) || b >newArray.GetLength(1)) Console.WriteLine("элемента с такими индексами в массиве нет");
else Console.WriteLine(newArray[a,b]);
*/
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] CreateRandom2dArray()
{
    Console.Write("input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for ( int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue +1);

        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}
int AverageSum(int[,] newArray)
{
    int sum = 0;
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1);j++)
        {
            

        }
    }



}