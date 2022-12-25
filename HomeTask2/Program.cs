/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int CutNumber(int number)
{
    int sot = number / 100;
    int edi = number % 10;
    int result = (number - ((sot * 100)+(edi)))/10; 
    return result;
}
Console.Write("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int NewNumber = CutNumber(number);

Console.WriteLine($"new version of a number {number} is {NewNumber}" );
*/



//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
string numberT =Convert.ToString(number);

if( (number / 100) > 0 )
{
    Console.WriteLine($"третья цифра:{numberT[2]}"); 
}
else
{
    Console.WriteLine("третей цифры нет" );
}
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Напишите порядковый номер дня недели:" );
int dayNumber = Convert.ToInt32(Console.ReadLine());

if  (dayNumber == 6 || dayNumber == 7)
{
 Console.WriteLine("выходной" );   
}
else 
{
    Console.WriteLine("будний день" );
}
