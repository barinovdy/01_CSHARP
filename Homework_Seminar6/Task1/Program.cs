// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 
// a b c => “abcdef”
// d e f 

string ArrayToString(char[,] array)
{
    string str = "";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str = str + array[i, j];
        }
    }
    return str;
}

char[,] CharArray = new char[,] { { 'a', 'b', 'c' }, { 'd', 'e', 'f' } };

Console.WriteLine(ArrayToString(CharArray));
