//Напишите программу, которая определит, правильно ли расставлены скобки в выражении,
//если оно состоит из скобок типа: ( ) [ ] { }. (использовать структуру данных стек)



bool CheckExpression(string input)
{
    var stackBrackets = new Stack<char>();
    foreach (var item in input)
    {
        if (IsOpenBracket(item))
        {
            stackBrackets.Push(item);
        }
        else if (IsCloseBracket(item))
        {
            if (IsMatchBracket(stackBrackets.Pop(), item))
            {
                continue;
            }
            
            return false;
        }
    }

    return stackBrackets.Count == 0;

}

bool IsOpenBracket(char ch)
{
    return "([{".IndexOf(ch) != -1;
}
bool IsCloseBracket(char ch)
{
    return ")]}".IndexOf(ch) != -1;
}

bool IsMatchBracket(char openBr, char closeBr)
{
    switch (openBr)
    {
        case '(' when closeBr == ')':
        case '{' when closeBr == '}':
        case '[' when closeBr == ']':
            return true;
        default:
            return false;
    }
}

void PrintAnswer(string input)
{
    Console.WriteLine("Выражение имеет вид:");
    Console.WriteLine(input);
    if (CheckExpression(input))
    {
        Console.WriteLine("Скобки расставлены верно\n");
    }
    else
    {
        Console.WriteLine("Скобки расставлены неверно\n");
    }
}

var str1 = "(5*6*{5-8}+5*[3-4])";
var str2 = "(5*6*{5-8+5*[3-4]})";
var str3 = "(5*6*{5-8)}+5*[3-4]";
var str4 = "(5*6*{5-8}+5*[3-4]";

PrintAnswer(str1);
PrintAnswer(str2);
PrintAnswer(str3);
PrintAnswer(str4);