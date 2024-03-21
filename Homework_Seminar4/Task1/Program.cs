// Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе 
// символа ‘q’ или при вводе числа, сумма цифр которого чётная.

int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)//457
    {
        sum = sum + number % 10;
        number /= 10;
    }
    return sum;
}

bool IsNumber(string str)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsAsciiDigit(str[i]) == false)
        {
            return false;
        }
    }
    return true;
}

while (true)
{
    string str = Console.ReadLine();
    if (str == "q")
    {
        Console.WriteLine("Введен символ 'q'");
        break;
    }
    if (IsNumber(str) == true)
    {
        int number = Convert.ToInt32(str);
        int sum = SumOfDigits(number);
        if (sum % 2 == 0)
        {
            Console.WriteLine("Сумма цифр четная: " + sum);
            break;
        }
        else
        {
            Console.WriteLine("Сумма цифр нечетная: " + sum);
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Введите символ 'q' или число.");
    }
}