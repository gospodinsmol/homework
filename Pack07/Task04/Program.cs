// Найти наибольший общий делитель двух натуральных чисел

Console.WriteLine("Введите 1ое число");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2ое число");
int m = int.Parse(Console.ReadLine());

while (n > 0 && m > 0)
{
    if (n > m)
        n %= m;
    else 
        m %= n;
}

Console.WriteLine($"Наибольший общий делитель: {n + m}");