// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 
// a b c => “abcdef”
// d e f 

char[,] CharArray = new char[,] { { 'a', 'b', 'c' },{ 'd', 'e', 'f' } };
string str = "";

for (int i = 0; i < CharArray.GetLength(0); i++)
{
    for (int j = 0; j < CharArray.GetLength(1); j++)
    {
        str = str + CharArray[i, j];
    }
}

Console.WriteLine(str);
