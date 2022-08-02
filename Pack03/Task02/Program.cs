// Даны три числа, найдите 2, у которых наибольшая сумма

Console.WriteLine("Введите три целых числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a <= b)
{
    a = b;
}
if (a <= c)
{
    a = c;
}


Console.WriteLine($"Наибольшее число - {a}");