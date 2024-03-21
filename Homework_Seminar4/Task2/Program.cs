// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRndArray(int numArrayNumbers, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] array = new int[numArrayNumbers];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
    }
    return array;
}

void ShowArray(int[] array)
{
Console.Write("[ "); 
for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    } 
Console.WriteLine(']');   
}

int NumEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int[] arr = CreateRndArray(10, 100, 1000);
ShowArray(arr);
int numEvenDigits = NumEven(arr);
Console.WriteLine("Количество четных элементов: " + numEvenDigits);