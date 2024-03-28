// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

void ReverseArray(int[] array)
{
    PrintArrayElm(array, array.Length);
}

void PrintArrayElm(int[] array, int index)
{
    if (index == 0) return;
    Console.Write($"{array[index - 1]} ");
    PrintArrayElm(array, index - 1);
}

int[] arr = CreateArrayRndInt(10, 1, 20);
PrintArray(arr);
ReverseArray(arr);