
//Домашка 4
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Stepen(int num, int pokazatel)
{
    int sum = 1;
    for(int current = 1 ; current <= pokazatel; current++)
    
        sum = sum * num;
    
     return sum;
}
Console.Write("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("input a pokazatel: ");
int pokazatel = Convert.ToInt32(Console.ReadLine());

int result = Stepen(num, pokazatel);
Console.WriteLine(result);
*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
int num = number % 10;
number = number / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
*/

//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int CreateOwnArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("input a number");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array ;
}
void showArray(int[] array)
{
    for(int i  = 0; i < array.Length ; i++)
    
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateOwnArray(length);
showArray(newArray);

