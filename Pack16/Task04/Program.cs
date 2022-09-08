//Строка представляет собой арифметическое бесскобочное выражение,
//состоящее из операндов и арифметических бинарных операций(+, -,*, /).
//Вывести операции.
//Вывести операнды.
//Вычислить значение выражения.

using System.Xml;

var str = "8*8+2+4*8/2+5*66-28+64/2";

bool IsOperator(char с)
{
    return "+-/*^".IndexOf(с) != -1;
}

int GetPriority(char ch)
{
    return ch switch
    {
        '+' => 0,
        '-' => 1,
        '*' => 2,
        '/' => 2,
        '^' => 3,
        _ => 4
    };
}

string GetExpression(string input)
{
    var output = string.Empty;
    var operators = new Stack<char>();
    for(var item = 0; item < input.Length; item++)
    {
        if (char.IsDigit(input[item]))
        {
            while (!IsOperator(input[item]))
            {
                output += input[item];
                item++;
                if (item == input.Length)
                {
                    break;
                }
            }
            output += " ";
            item--;
        }
        else if (IsOperator(input[item]))
        {
            if (operators.Count > 0)
            {
                if (GetPriority(input[item]) <= GetPriority(operators.Peek()))
                {
                    output += operators.Pop().ToString() + " ";
                }
            }
            operators.Push(input[item]);
        }
    }

    while (operators.Count > 0)
    {
        output += operators.Pop() + " ";
    }
    return output;
}

void PrintElements(string inputString)
{
    var nums = string.Empty;
    var operators = string.Empty;
    foreach (var ch in inputString)
    {
        if (char.IsDigit(ch))
        {
            nums += ch;
        }
        else if (IsOperator(ch))
        {
            operators += ch;
        }
    }
    Console.WriteLine($"Числа:{nums}");
    Console.WriteLine($"Операторы: {operators}");
}

double Calculation(string inputString)
{
    
    var tempStack = new Stack<double>();
    for(var item = 0; item < inputString.Length; item++)
    {
        if (char.IsDigit(inputString[item]))
        {
            var tempString = string.Empty;
            while (char.IsDigit(inputString[item]))
            {
                tempString += inputString[item];
                item++;
            }
            item--;
            tempStack.Push(Double.Parse(tempString));
        }
        else if (IsOperator(inputString[item]))
        {
            var a = tempStack.Pop();
            var b = tempStack.Pop();

            var result = inputString[item] switch
            {
                '+' => a + b,
                '-' => b - a,
                '*' => a * b,
                '/' => b / a,
                '^' => Math.Pow(b, a),
                _ => 0.0
            };
            tempStack.Push(result);
        }
    }

    return tempStack.Peek();
}

//Console.WriteLine(str);
//Console.WriteLine(GetExpression(str));
PrintElements(str);
Console.WriteLine($"Result: {Calculation(GetExpression(str))}");