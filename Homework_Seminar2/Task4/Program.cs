// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.
// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
{
    Console.WriteLine("Некорректный ввод");
}
else
{
    if (number < 10)
    {
        Console.WriteLine(number);
    }
    else
    {
        int rank = 10;
        while (number / rank >= 10)
        {
            rank = rank *10;
        }
        int digit = number / rank;
        while (rank >= 10)
        {
            Console.Write(digit + ",");
            rank = rank / 10;
            digit = number / rank % 10;
        }
        Console.Write(digit);
    }
}