// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray(int lenght)
{
    string[] array = new string[lenght];
    Console.WriteLine($"Введите {lenght} текстовых или символьных сообщения");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"" + " ");
    }
    Console.WriteLine();
}

int NewArraySize(string[] array)
{
    int newsize = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newsize++;
        }
    }
    return newsize;
}

string[] NewArrayLessThan3(int lenght, string[] array)
{
    string[] array2 = new string[lenght];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}

Console.WriteLine("Сколько сообщений вы бы хотели ввести?");
int lenght = Convert.ToInt32(Console.ReadLine());
string[] array1 = CreateArray(lenght);
Console.WriteLine("Введеные вами сообщения:");
ShowArray(array1);
string[] ArrayLessThan3 = NewArrayLessThan3(NewArraySize(array1),array1);
Console.WriteLine("Сообщения с длинной 3 или меньше:");
ShowArray(ArrayLessThan3);