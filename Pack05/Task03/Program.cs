// Напечатать таблицу умножения

using System.Security.Cryptography;

for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.Write($"{i}x{j}={i * j}");
        Console.Write("\t");
    }
    Console.WriteLine();
}