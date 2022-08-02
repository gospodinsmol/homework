// Определить, между какими двумя последующими степенями двойки расположено данное натуральное число
Console.WriteLine("Введите число");
var n = int.Parse(Console.ReadLine());

var currentPow = 0;
var twoPow = 1;

while (twoPow < n)
{
    currentPow++;
    twoPow <<= 1;
}

Console.WriteLine($"Между степенями {currentPow} и {currentPow + 1}");