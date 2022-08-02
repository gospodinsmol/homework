﻿// Составить программу для графического изображения делимости чисел от 1 до n (значение n вводится с клавиатуры).
// В каждой строке необходимо напечатать очередное число и столько символов "+", сколько делителей у этого числа.

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    Console.Write($"{i}+");
    for (int j = 1; j < i /2 + 1; j++)
    {
        if (i % j == 0)
        {
            Console.Write("+");
        }
    }
    Console.WriteLine();
}