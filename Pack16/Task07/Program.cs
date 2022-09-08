// Пусть дана без ошибок формула, имеющая следующий синтаксис: 
//<формула>::=<цифра> | max(<формула>, < формула >) | min (<формула>,< формула >)
//<цифра>::=0 1 2 3 4 5 6 7 8 9
//Например, 8 или max(4, min(3, 5)) или min(min(3, 5), max(2, max(3, 4))).
//Вычислить значение формулы, используя структуру данных стек.


using System.Data;

bool IsFunction(string str)
{
    return str is "max" or "min";
}

bool IsNum(string str)
{
    return str.All(char.IsDigit); //предложил так сделать rider ;)
}

int Max(int valueA, int valueB)
{
    return valueA > valueB ? valueA : valueB;
}

int Min(int valueA, int valueB)
{
    return valueA < valueB ? valueA : valueB;
}

Stack<string> CreateStack(string input)
{
    var tempStack = new Stack<string>();
    if (input.Length == 1)
    {
        tempStack.Push(input);
        return tempStack;
    }
    for (var item = 0; item < input.Length; item++)
    {
        if (char.IsDigit(input[item]))
        {
            var tempStr = string.Empty;
            while (char.IsDigit(input[item]))
            {
                tempStr += input[item];
                item++;
                if (item < 0)
                {
                    break;
                }
            }
            tempStack.Push(tempStr);
            item--;
        }
        else if (char.IsLetter(input[item]))
        {
            var tempStr = string.Empty;
            while (char.IsLetter(input[item]))
            {
                tempStr += input[item];
                item++;
                if (item < 0)
                {
                    break;
                }
            }
            tempStack.Push(tempStr);
            item--;
        }
    }
    return tempStack;
}

int Calculation(string input)
{
    var tempStack = CreateStack(input);
    if (tempStack.Count == 1 && IsNum(tempStack.Peek()))
    {
        return int.Parse(tempStack.Pop());
    }
    var valueA = 0;
    var valueB = 0;
    var stackCount = tempStack.Count;
    for (var item = 0; item < stackCount; item++)
    {
        var tempItem = tempStack.Pop();
        if (IsFunction(tempItem))
        {
            if (tempItem == "max")
            {
                tempStack.Push(Max(valueA, valueB).ToString());
                stackCount++;
            }
            else if (tempItem == "min")
            {
                tempStack.Push(Min(valueA, valueB).ToString());
                stackCount++;
            }
            
        }
        else if (IsNum(tempItem))
        {
            valueB = valueA;
            valueA = int.Parse(tempItem);
        }
    }
    return tempStack.Count == 1 ? int.Parse(tempStack.Pop()) : valueA;
}

void PrintResult(string input)
{
    Console.WriteLine($"Выражение: {input}");
    Console.WriteLine($"Результат выполнения: {Calculation(input)}\n");
}

const string str1 = "min(min(3,5), max(2,max(3,4))";
const string str2 = "max(4, min(3, 5))";
const string str3 = "8";

PrintResult(str1);
PrintResult(str2);
PrintResult(str3);

