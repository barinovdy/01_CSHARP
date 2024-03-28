// Задача 4*(не обязательная): Задайте строку, состоящую из слов, 
// разделенных пробелами. Сформировать строку, 
// в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.

int WordsNumberInString(string str)
{
    //Считаем количество слов в строке
    int wordsNum = 1;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].ToString() == " ") wordsNum++;
    }
    return wordsNum;
}

string DelStringSpace(string str)
{
    //Формируем строку без пробелов
    string strCor = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].ToString() != " ") strCor = strCor + str[i];
    }
    return strCor;
}

int[] FirstWordLetterIndex(int wordsNum, string str, string strCor)
{
    //Записываем индексы первых символов строки
    int[] wordsIndex = new int[wordsNum + 1];
    int index = 1;
    wordsIndex[0] = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].ToString() == " ")
        {
            wordsIndex[index] = i - index + 1;//0 3 7 10
            index++;
        }
    }
    wordsIndex[index] = strCor.Length;
    return wordsIndex;
}

string ReverseString(string str)
{
    //Считаем количество слов в строке:
    int WordsNumber = WordsNumberInString(str);
    //Формируем строку без пробелов:
    string strCorr = DelStringSpace(str);
    //Формируем строку без пробелов    
    int[] wordsLetterIndex = FirstWordLetterIndex(WordsNumber, str, strCorr);
    //Записываем строку наоборот
    string strNew = "";
    for (int i = wordsLetterIndex.Length - 1; i > 0; i--)
    {
        int firstLetter = wordsLetterIndex[i - 1];
        int secondLetter = wordsLetterIndex[i];
        for (int j = firstLetter; j < secondLetter; j++)
        {
            strNew = strNew + strCorr[j];
        }
        if (firstLetter != 0) strNew = strNew + " ";
    }
    return strNew;
}

Console.Write("Введите произвольну строку: ");
string str = Console.ReadLine();

Console.Write(ReverseString(str));