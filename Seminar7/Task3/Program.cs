// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.
// Пример
// “hello” => h l l 
// “World” => W r l d 
// “Hello world!” => l d

void PrintOnlyConsonauts(string line) // hello > ello > llo > lo > o > ""
{
    if (line.Length == 0) return;
    string chars = "aeiouy";
    if(char.IsAsciiLetter(line[0]) && !chars.Contains(line[0])) // h l l
    {
        Console.Write($"{line[0]} "); // h l l
    }
    PrintOnlyConsonauts(line.Substring(1));
}

Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();
PrintOnlyConsonauts(str);