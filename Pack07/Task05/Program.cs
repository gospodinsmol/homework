﻿// Когда Василисе Премудрой исполнилось 18 лет, Кощей предложил ей выйти за него замуж.
// Василиса спросила, сколько у него есть сундуков с золотом.
// Кощей сказал что сейчас у него N ящиков, и каждый год добавляемся по М сундуков.
// Василиса пообещала, что выйдет за него замуж, когда у Кощея будет К полных ящиков с золотом.
// Сколько лет тогда будет Василисе?


Console.WriteLine("Введите количество яшиков N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество сундуков М");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите итоговое количество яшиков K");
int k = int.Parse(Console.ReadLine());
int year = 18;

while (n < k)
{
    n += m;
    year++;
}
Console.WriteLine(year);