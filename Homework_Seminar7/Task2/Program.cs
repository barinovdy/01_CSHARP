// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkerFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkerFunction(m - 1, 1);
    else return AkkerFunction(m - 1, AkkerFunction(m, n - 1));
}

Console.WriteLine("Вычисление функции Аккермана A(m,n).");
Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Функция Аккермана A({m},{n}): {AkkerFunction(m, n)}");