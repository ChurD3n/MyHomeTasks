//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int a)
{
    Console.Write(a + " ");
    if(a>1) ShowNums(a-1);
}
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
ShowNums(a);
*/
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfLine(int a, int b)
{
    if(b>=a) return SumOfLine(a,b-1)+b;
    else return 0;

}
Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfLine(a,b));
*/
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int Ackerman(int m, int n )
{
    if(m ==0){return n+1;}
    if (m>0 && n==0) {return Ackerman(m-1,1);}
    return  (Ackerman(m-1,Ackerman(m,n-1)));
}
Console.WriteLine(Ackerman(2,3));
*/

