// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.
// Примеры
// [1 3 4 19 3] => 2
// [4 3 4 1 9 5 21 13] => 3

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
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

int CountPrime(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsPrime(array[i])) count++;
    }


    return count;
}

// 2 3 4 5 6 7 8 9 10 11 12 13 14
bool IsPrime(int num)
{
    //for (int i = 2; i < num; i++)
    for (int i = 2; i <= Math.Sqrt(num); i++) //математически эквивалентно вышестоящему
    {
        if (num % i == 0) return false;
    }
    return true;
}

int[] arr = CreateArrayRndInt(10, 1, 1000);
PrintArray(arr);

int result = CountPrime(arr);
Console.WriteLine(result);