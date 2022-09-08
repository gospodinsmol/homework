// В постфиксной записи (или обратной польской записи) операция записывается после двух операндов.
// Например, сумма двух чисел A и B записывается как A B +. Запись B C + D * обозначает,
// привычное нам  (B + C) * D, а запись A B C + D * + означает A + (B + C) * D.
// Достоинство постфиксной записи в том, что она не требует скобок и дополнительных соглашений
// о приоритете операторов для своего чтения.
// Вычислить значение выражения записанного в постфиксной записи используя динамическую структуру данных стек.

double Calculation(string input)
{
    var tempStack = new Stack<double>();
    for (var item = 0; item < input.Length; item++)
    {
        if (char.IsDigit(input[item]))
        {
            var tempStr = string.Empty;
            while (char.IsDigit(input[item]))
            {
                tempStr += input[item];
                item++;
                if (item == input.Length)
                {
                    break;
                }
            }
            tempStack.Push(double.Parse(tempStr));
            item--;
        }
        else if (IsOperator(input[item]))
        {
            var valueA = tempStack.Pop();
            var valueB = tempStack.Pop();
            switch (input[item])
            {
                case '+': tempStack.Push(valueA+valueB);
                    break;
                case '-': tempStack.Push(valueB-valueA);
                    break;
                case '*': tempStack.Push(valueA*valueB);
                    break;
                case '/': tempStack.Push(valueB/valueA);
                    break;
                case '^': tempStack.Push(Math.Pow(valueB, valueA));
                    break;
            }
        }
    }

    return tempStack.Peek();
}
string GetExpression(string input)
{
    var output = string.Empty;
    var tempStack = new Stack<char>();
    for (var item = 0; item < input.Length; item++)
    {
        if (IsOperator(input[item]))
        {
            if (input[item] == '(')
            {
                tempStack.Push(input[item]);
            }
            else if (input[item] == ')')
            {
                var ch = tempStack.Pop();
                while (ch != '(')
                {
                    output += ch + " ";
                    ch = tempStack.Pop();
                }
            }
            else
            {
                if (tempStack.Count > 0 && GetPriority(input[item]) <= GetPriority(tempStack.Peek()))
                {
                    output += tempStack.Pop() + " ";
                }

                tempStack.Push(input[item]);
            }
        }
        else if (char.IsDigit(input[item]))
        {
            while (char.IsDigit(input[item]))
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
    }

    while (tempStack.Count > 0)
    {
        output += tempStack.Pop() + " ";
    }

    return output;
}

bool IsOperator(char ch)
{
    return "+/*^-()".IndexOf(ch) != -1;
}

int GetPriority(char ch)
{
    return ch switch
    {
        '(' => 0,
        ')' => 1,
        '+' => 2,
        '-' => 3,
        '*' => 4,
        '/' => 4,
        '^' => 5,
        _ => 6
    };
}

void PrintResult(string input)
{
    var tempStr = GetExpression(input);
    Console.WriteLine($"Expression: {input}");
    Console.WriteLine($"Result: {Calculation(tempStr)}");
}

var expr = "(1 + 2 * 3)/4 + 6";
PrintResult(expr);

