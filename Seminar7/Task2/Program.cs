// Задание 2
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Указание
// Использовать рекурсию.
// Пример
// 123 => 6
// 63 => 9

int SumOfDigitNum(int num) // 123 > 12 > 1 > 0
{
    if (num == 0) return 0;
    return num % 10 + SumOfDigitNum(num / 10); // 123 > 12 > 1
    //1 % 10 + 12 % 10 + 123 % 10 + 0 = 1 + 2 + 3 + 0 = 6
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfDigitNum(number));