// Дано число, вывести  его двоичное представление, используя только битовые операции.

Console.WriteLine("Enter a number to convert to binary");
var num = int.Parse(Console.ReadLine());

Console.WriteLine($"Number {num} in binary system: {ConvertToBit(num)}");
Console.WriteLine(Convert.ToString(num, 2));

string ConvertToBit(int input)
{
    var result = string.Empty;
    while (input > 0)
    {
        result = result.PadLeft(result.Length + 1, (char)(input & 1));
        input >>= 1;
    }

    return result;
}