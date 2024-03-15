// Задача 2: Напишите программу, которая принимает
// на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
// 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.
// 2, 3 => 1
// -5, 3 => 2
// -3, -2 => 3
// 4, -2 => 4

Console.WriteLine("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X == 0 || Y == 0)
{
    Console.WriteLine("Число расположено на координатной оси");
}
if (X > 0 && Y > 0)
{
    Console.WriteLine("Первая четверть");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine("Вторая четверть");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine("Третья четверть");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine("Четвертая четверть");
}