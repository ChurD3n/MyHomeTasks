// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите 1 число:\t");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число:\t");
int b = Convert.ToInt32(Console.ReadLine());


if(a > b)
{
  Console.Write($"max= {a}");
}
  else if (b > a)
{ 
  Console.Write($"max= {b}");
}
  else
{
  Console.WriteLine("числа равны");
}  
*/

//Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Введите 1 число:\t");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число:\t");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3 число:\t");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b & a > c )
{
  Console.Write($"max= {a}");
}
else if ( b > a & b > c)
{
  Console.Write($"max= {b}");
}
else if (c > a & c > b)
{
  Console.Write($"max= {c}");
}
else 
Console.Write("числа равны");
*/

//Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число:\t");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 ==0)
{
  Console.Write("четное");
}
else Console.Write("нечетное");
*/

// Задача 8.Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите число:\t");
int a = Convert.ToInt32(Console.ReadLine());

int count = 0;
while( count < (a - 1) )
{
  count = count + 2;
  Console.WriteLine($"{count}");
  
}
*/