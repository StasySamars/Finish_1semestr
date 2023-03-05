/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длинна которого меньше либо равна 3 символа. 
Первоначальный массив можно внести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами */
string[] randomStringArray = { "Hello", "2", "world", ":-)", "43", "j34h" };

string[] LimitSymbolArray(string[] array, int numberOfSymbols)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < numberOfSymbols + 1)
        {
            j++;
        }
    }

    string[] newArray = new string[j];
    j = 0;  
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < numberOfSymbols + 1)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{{{array[i]}}}, ");
    }
}

string[] arrayСhoiceLength = LimitSymbolArray(randomStringArray, 3);
ShowArray(randomStringArray);
Console.WriteLine();
ShowArray(arrayСhoiceLength);
