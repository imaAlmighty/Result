//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меьнше лиюо равна 3 символа. Первоначальный массив можно ввести  с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
//Примеры:
//["hello", "2", "world", ":-)"] -> ["2", ":-)"];

int AskNumber(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine()!);
}

string AskString(string msg)
{
    Console.WriteLine(msg);
    string result = Console.ReadLine()!;
    return result;
}

string[] FillArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = AskString("Введите элемент массива: ");
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int CountElementsLess3(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string index = array[i];
        if (index.Length < 4)
        {
            count++;
        }
    }
    return count;
}

string[] PrintElementsLess3(string[] array, int count)
{
    int j = 0;
    string[] arrayNew = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        string index = array[i];
        if (index.Length < 4)
        {
            arrayNew[j] = array[i];
            j = j + 1;
        }
    }
    return arrayNew;
}

int lenght = AskNumber("Введите длинну массива: ");
string[] array = FillArray(lenght);
Console.WriteLine("Заданный вами массив : ");
PrintArray(array);
Console.WriteLine();
int count = CountElementsLess3(array);
Console.WriteLine($"Элементов в заданном Вами массиве с колличеством символов <=3 : {count}");
string[] newArray = PrintElementsLess3(array, count);
Console.WriteLine("Массив со всеми элементами у которых количество символов <=3 : ");
PrintArray(newArray);