// Выяснить является ли число степенью двойки, используя битовые операции.

Console.WriteLine("Enter number:");
var input = int.Parse(Console.ReadLine());
Console.WriteLine( (input & (input - 1)) == 0
    ? $"Number {input} is a power of two"
    : $"Число {input} isn`t a power of two");