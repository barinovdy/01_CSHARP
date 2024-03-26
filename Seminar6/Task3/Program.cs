// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

int CountVowels(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        string chars = "aeiouy";
        for (int j = 0; j < chars.Length; j++)
        {
            if (str[i] == chars[j])
            {
                count++;
            }
        }
    }
    return count;
}

Console.WriteLine("Введите строку из латинских букв в нижнем регистре: ");
string str = Console.ReadLine();

Console.WriteLine(CountVowels(str));


