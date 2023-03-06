//решение задачи
//пункт 1) метод создающий массив
string[] CreateArray()
{
    Console.Write("Кол-во элементов: ");
    int countString = Convert.ToInt32(Console.ReadLine());
    string[] newArray = new string[countString];
     for (int i = 0; i < countString; i++)
        {
            Console.Write($"Введите элемент №{i + 1}: ");
            newArray[i] += Console.ReadLine();
        }
    return newArray;
}
//пункт 2) метод выводящий массив на экран
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

