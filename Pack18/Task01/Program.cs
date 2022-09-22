// Даны 2 числа и операция. Вывести на консоль выбранный  байт ответа. 
// Например: 21*37=777, 777= 00000011 00001001, последний байт это 00001001=9

Menu();

void Menu()
{
    Console.WriteLine("Please, enter first number");
    var value1 = ReadInt();
    Console.WriteLine("Please, enter second number");
    var value2 = ReadInt();
    Console.WriteLine("Please, enter operation (*,+,-)");
    var operat = ReadOperator();
    var result = Calculate(value1, value2, operat);
    Console.WriteLine($"Please enter number of byte");
    var selectedByteNumber = ReadNumberOfByte(result);
    PrintByte(result, selectedByteNumber);
}

int Calculate(int valueA, int valueB, char operat)
{
    return operat switch
    {
        '+' => valueA + valueB,
        '-' => valueA - valueB,
        '*' => valueA * valueB,
        _ => throw new ArgumentOutOfRangeException()
    };
}

int ReadInt()
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out var outValue1))
        {
            return outValue1;
        }
        Console.WriteLine("Please enter valid values");
    }
}

int ReadNumberOfByte(int inputNumber)
{
    var numberOfBit = Convert.ToString(inputNumber, 2).Length;
    var numberOfByte = Convert.ToInt32(Math.Ceiling((double)numberOfBit / 8));
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out var outValue1))
        {
            if (outValue1 <= numberOfByte && outValue1 > 0)
            {
                return outValue1;
            }
        }
        Console.WriteLine($"Please enter valid values (from 1 to {numberOfByte})");
    }
}

bool IsValidOperation(char input)
{
    return "+*-".IndexOf(input) != -1;
}

char ReadOperator()
{
    while (true)
    {
        if (char.TryParse(Console.ReadLine(), out var outValue))
        {
            if (IsValidOperation(outValue))
            {
                return outValue;
            }
        }
        Console.WriteLine("Please enter valid values");
    }
}

void PrintByte(int number, int byteNumber)
{
    var numberBit = Convert.ToString(number, 2);
    
    if (numberBit.Length % 8 != 0)
    {
        numberBit = numberBit.PadLeft(numberBit.Length + (8 - numberBit.Length % 8), '0');
    }
    var maxBit = byteNumber * 8;
    numberBit = numberBit[(maxBit - 8)..(maxBit)];
    number = Convert.ToInt32(numberBit, 2);
    Console.WriteLine($"Selected byte is {numberBit} - {number}");
}