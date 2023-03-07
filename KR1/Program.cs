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
        Console.Write($"{array[i]}"+ "  ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine();
}
//пункт 3) метод анализирующий массив
void CreateSub4Array(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}


string[] UsersArray = CreateArray();
string[] array2 = new string[UsersArray.Length];
ShowArray(UsersArray);
CreateSub4Array(UsersArray, array2);
ShowArray(array2);


