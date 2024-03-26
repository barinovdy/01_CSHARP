// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.
//“aBcD1ef!-” => “abcd1ef!-” 

string StrToLower(string str)
{
    string result = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].ToString() == str[i].ToString().ToLower())
        {
            result = result + str[i];
        }
        else
        {
            result = result + str[i].ToString().ToLower();
        }
    }
    return result;
}


string str = "aBcD1ef!-";

string result = StrToLower(str);

Console.WriteLine(result);

