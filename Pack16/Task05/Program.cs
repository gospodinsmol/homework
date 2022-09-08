//Строка состоит из целых чисел бинарных арифметических операций и пробелов.
//Определить является ли строка арифметическим выражением. Например: 34 + 56 * 4 арифметическое выражение.
//Например: 34 + * 56 не является арифметическим выражением. Например: 56 56 + не является арифметическим выражением.

bool CheckExpression(string input)
{
    var tempStack = AddToStack(input);
    var count = tempStack.Count;
    for (var item = 0; item < count; item++)
    {
        if (item % 2 == 0)
        {
            if (IsOperator(tempStack.Pop()))
            {
                return false;
            }
        }
        else if(item % 2 != 0)
        {
            if (!IsOperator(tempStack.Pop()))
            {
                return false;
            }
        }
    }
    return true;
}

bool IsOperator(string str)
{
    return "+-/*^".IndexOf(str, StringComparison.Ordinal) != -1;
}

Stack<string> AddToStack(string input)
{
    var tempStack = new Stack<string>();
    for (var item = 0; item < input.Length; item++)
    {
        if(char.IsDigit(input[item]))
        {
            var tempString = string.Empty;
            while (char.IsDigit(input[item]))
            {
                tempString += input[item];
                item++;
                if (item == input.Length)
                {
                    break;
                }
            }
            tempStack.Push(tempString);
            item--;
        }
        else if (!Char.IsSeparator(input[item]))
        {
            tempStack.Push(input[item].ToString());
        }
    }

    return tempStack;
}

var str1 = "34 + * 56";
var str2 = "34 + 45 * 2";
var str3 = "56 56 +";
Console.WriteLine(CheckExpression(str1));
Console.WriteLine(CheckExpression(str2));
Console.WriteLine(CheckExpression(str3));