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

