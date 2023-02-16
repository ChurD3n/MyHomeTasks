//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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


void Poradok(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1);j++)
        {
            for(int k = 0; k< array.GetLength(1) - 1; k++ )
            {
                 if (array[i, k] < array[i,k + 1])
            
                {
                int move = array[i, k +1];
                array[i, k + 1] = array[i, k];
                array[i, k] = move;
                }
            }             
        }
    }

}
void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
  }
}


Console.WriteLine("Отсортированный массив: ");
Poradok(newArray);

Show2dArray(newArray);
*/
//Задача 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
void ShowFirstArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

int[,] FirstArray = CreateRandom2dArray();
ShowFirstArray(FirstArray);

int SumOfString(int[,] FirstArray)
{
    int sum=0;
    for(int i = 0; i < FirstArray.GetLength(0);i++)
    {
        sum= sum + FirstArray[i,0];    
    }

    return sum;
}
int summa = SumOfString(FirstArray);
Console.WriteLine(summa);




//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
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
void ShowFirstArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

int[,] FirstArray = CreateRandom2dArray();
ShowFirstArray(FirstArray);


 int[,] CreateRandom2d1Array()
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
void ShowSecondArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

int[,] SecArray = CreateRandom2d1Array();
ShowSecondArray(SecArray);

int[,] Multiplication(int[,] FistArray, int[,] SecArray)
{
    int[,] array = new int[FirstArray.GetLength(0), SecArray.GetLength(1)];
    for (int k = 0;k < FirstArray.GetLength(0) - 1 ; k++ )
    {
        for(int c = 0; c < SecArray.GetLength(1) - 1 ;c++ )
        {
            array[k,c] = FirstArray[k,c] * SecArray[k,c] + FirstArray[k,c+1]*SecArray[k+1,c]; 
        }
    }
    return array;
}
void ShowItog(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + " \t");
        Console.WriteLine();    
    }
    Console.WriteLine();
}

int[,] Itog = Multiplication(FirstArray,SecArray);
ShowItog(Itog);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] TriDArray()
{
int[,,] array = new int[2,2,2];
for(int i=0;i<array.GetLength(0);i++)
{
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int k=0;k<array.GetLength(2);k++)
            {
                array[i,j,k] = Convert.ToInt32(Console.ReadLine()); 
            }
        }
    }
    
}
return array;
}
void ShowArray(int[,,] array)
{
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            for(int k=0;k<array.GetLength(2);k++)
            {
             Console.WriteLine(array[i,j,k]  + " \t");      
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
int[,,] TriD = TriDArray();
ShowArray(TriD);
*/
//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,] array = new int[3,3];
int s = 1;
for (int y =0; y < 3; y++) {array[0,y] = s; s++;}
//for(int x = 0; x < 3; x++) {array[x,3] = s; s++ ;}
//for (int y = 3; y >= 1; y--) {array[3, y] = s;s++;}
//for (int x = 3; x >= 1; x--) {array[x, 0] = s;s++;}

Console.WriteLine(array);
*/
