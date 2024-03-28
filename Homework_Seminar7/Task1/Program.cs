// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNumbersBetweenMN(int numM, int numN)
{
    if (numM == numN) Console.Write($"{numM} ");
    if (numM < numN) 
    {
        int num = numM;
        if (num == numN + 1) return;
        Console.Write($"{num} ");
        PrintNumbersBetweenMN(num + 1, numN);
    }
    if (numM > numN)
    {
        int num = numM;
        if (num == numN - 1) return;
        Console.Write($"{num} ");
        PrintNumbersBetweenMN(num - 1, numN);
    }
}

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

PrintNumbersBetweenMN(numberM, numberN);

