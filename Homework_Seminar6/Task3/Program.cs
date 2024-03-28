//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.Write("Введите произвольну строку: ");
string str = Console.ReadLine();

bool IsPolyndrom = true;

for (int i = 0; i < str.Length / 2; i++)
{
    if (str[i] != str[str.Length - 1 - i])
    {
        IsPolyndrom = false;
    }
}

if (IsPolyndrom) Console.WriteLine("Указанная строка является полиндромом");
else Console.WriteLine("Указанная строка не является полиндромом");