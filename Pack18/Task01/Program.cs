// Даны 2 числа и операция. Вывести на консоль выбранный  байт ответа. 
// Например: 21*37=777, 777= 00000011 00001001, последний байт это 00001001=9

Menu();

void Menu()
{
    var value1 = 0;
    var value2 = 0;
    Console.WriteLine("Введите первое число");
    if (int.TryParse(Console.ReadLine(), out var outValue1))
    {
        value1 = outValue1;
    }
    else
    {
        Console.WriteLine("Введите корректные значения");
        Menu();
    }

    Console.WriteLine("Введите второе число");
    if (int.TryParse(Console.ReadLine(), out var outValue2))
    {
        value2 = outValue2;
    }
    else
    {
        Console.WriteLine("Введите корректные значения");
        Menu();
    }
    
    Console.WriteLine("Введите операцию (*,+,-)");
    var operat = Console.ReadLine();
    if ("+/*^-()".IndexOf(operat) != -1 && operat.Length == 1)
    {
        var result = Calculation(value1, value2, operat[0]);
        var resultBit = Convert.ToString(result, 2);
        if (resultBit.Length % 8 != 0)
        {
            resultBit = string.Concat(Enumerable.Repeat("0", (8 - resultBit.Length % 8))) + resultBit; 
        }

        Console.WriteLine($"Введите номер байта от 1 до {resultBit.Length / 8}");
        var numOfByte = int.Parse(Console.ReadLine());
        if (numOfByte <= resultBit.Length && numOfByte >= 1)
        {
            var maxBit = numOfByte * 8;
            resultBit = resultBit[(maxBit - 8)..(maxBit)];
            result = Convert.ToInt32(resultBit, 2);
            Console.WriteLine($"Выбранный байт это {resultBit} - {result}");
        }
        else
        {
            Console.WriteLine("Введены не верные значения. Повторите операции");
            Menu();
        }
    }
    else
    {
        Console.WriteLine("Введите корректные значения");
        Menu();
    }
}

int Calculation(int valueA, int valueB, char operat)
{
    return operat switch
    {
        '+' => valueA + valueB,
        '-' => valueA - valueB,
        '*' => valueA * valueB,
        _ => 0
    };
}