﻿// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2


Console.WriteLine("Insert number: ");
int num = Convert.ToInt32(Console.ReadLine());
int(num > 0)
{
    int i = -num;
    while (i <= num)
    {
        Console.Write(i + " ");
        //    Console.Write(" ");
        i = i + 1;
    }
}
else
{
    Console.WriteLine("Incorrect");
}

