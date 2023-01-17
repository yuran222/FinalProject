// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateArray(int lenght) //просит указать размер базового массива и заполняет его элементами, вводимыми пользователем
{
    string[] array = new string[lenght];
    Console.WriteLine($"Введите {lenght} текстовых или символьных сообщения");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}



void ShowArray(string[] array) //выводит любой одномерный массив на экран
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\"" + " ");
    }
    Console.WriteLine();
}

int NewArraySize(string[] array) //определяет размер нового массива для заполнения сообщениеями длинной менее 4 символов
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

string[] NewArrayLessThan3(int lenght, string[] array) //создает новый массив из старого, заполняя его элементами старого массива размером менее 4 символов
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


//запрос на кол-во сообщений в массиве
Console.WriteLine("Сколько сообщений вы бы хотели ввести?");
int lenght = Convert.ToInt32(Console.ReadLine());

//создание базового массива
string[] array1 = CreateArray(lenght);
Console.WriteLine("Введеные вами сообщения:");
ShowArray(array1);

//создание требуемого масссива и вывод на экран его элементов
string[] ArrayLessThan3 = NewArrayLessThan3(NewArraySize(array1), array1);
Console.WriteLine("Сообщения с длинной 3 или меньше:");
ShowArray(ArrayLessThan3);