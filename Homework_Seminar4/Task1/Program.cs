// Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.




using System;
using System.Globalization;
using Internal;


int SumOfDigits(number)
{
    int sum = 0;
    while(number > 1)
    {
        sum = sum + number%10;
        number /=10;
    }
    return sum;
}


while (true)
{
    string str = Console.ReadLine();
    if(str =='q')
    {
        Console.WriteLine("Введен символ 'q'");
        break;
    }
    
    if (введено число)
    {
        int number = Convert.ToInt32(str);
        int sum = SumOfDigits(number); 
    }
    if (введено не число)
    {
        Console.WriteLine("Некорректный ввод");
    }
}