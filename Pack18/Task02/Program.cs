// Дано число, вывести  его двоичное представление, используя только битовые операции.

using System.Collections;

Console.WriteLine("Введите число для перевод в двоичную систему");
var num = int.Parse(Console.ReadLine());

Console.WriteLine($"Число {num} в двоичной системе: {ConvertToBit(num)}");
Console.WriteLine(Convert.ToString(num,2));
string ConvertToBit(int input)
{
    var temp = string.Empty;
    if (input != 1)
    {
        temp += input & 1;
        input = input >> 1;
        return ConvertToBit(input) + temp;
    }
    else
    {
        temp += "1";
    }
    return temp;
    //return input == 1 ? "1" : ConvertToBit(input >>= 1) + (input & 1);
}
