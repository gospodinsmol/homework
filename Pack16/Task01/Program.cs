//Дана строка символов. Определить количество букв, количество цифр и количество остальных символов,
//присутствующих в строке.

Console.WriteLine("Введите строку");
var str = Console.ReadLine();
var counterLetter = 0;
var counterNumber = 0;
var counterAnother = 0;

foreach (var item in str)
{
    if (char.IsLetter(item))
    {
        counterLetter++;
    }
    else if (char.IsDigit(item))
    {
        counterNumber++;
    }
    else
    {
        counterAnother++;
    }
}
Console.WriteLine($"Количество букв: {counterLetter}, количество цифр {counterNumber}, количество других символов {counterAnother}");