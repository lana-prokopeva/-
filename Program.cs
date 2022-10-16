// Метод определения строк состоящих из 3-x и менее символов
string[] GetArrayOfSpecifiedElements(string[] array)
{
    Console.WriteLine();
    Console.WriteLine("Массив, чьи элементы равны или меньше 3-x символов:");
    string[] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
            {
            newArray[count] = array[i];
            count++;
            }
    }
    return newArray;
}

// Метод вывода массива на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }  
}

// Определяем входные данные
string[] initialArray = new string[6] {":)", "Column", "run", "0", "56-C", "OK123"};
Console.WriteLine("Первоначальный массив:");
PrintArray(initialArray);
string[] newArray = GetArrayOfSpecifiedElements(initialArray);
PrintArray(newArray);