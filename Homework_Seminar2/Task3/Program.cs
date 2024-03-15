// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 40 => 4
// 96 => 9
// 72 => 7

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10 || number > 99)
{
    Console.WriteLine("некорректный ввод");
}
else
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    int max = firstDigit;
    if (secondDigit > max)
    {
        max = secondDigit;
    }
    Console.WriteLine(max);
}