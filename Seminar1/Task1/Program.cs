// Напишите   программу,   которая   на   вход принимает  два  
// целых  числа  и  проверяет, является ли 
// первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10         => нет
// a = 9, b = -3         => да
// a = -3, b = 9         => нет

Console.WriteLine("Insert first number: ");
string num1str = Console.ReadLine();
int num1 = Convert.ToInt32(num1str);

Console.WriteLine("Insert second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 * num2 == num1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
