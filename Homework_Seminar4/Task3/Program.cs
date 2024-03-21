// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        ReverseArrayNumbers(array, i);
    }
}

void ReverseArrayNumbers(int[] array, int pos)
{
    int temp = 0;
    temp = array[pos];
    array[pos] = array[array.Length - pos - 1];
    array[array.Length - pos - 1] = temp;
}

int[] CreateRndArray(int num, int min, int max)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void ShowArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine(']');
}

int[] arr = CreateRndArray(10, 1, 10);
ShowArray(arr);
ReverseArray(arr);
ShowArray(arr);