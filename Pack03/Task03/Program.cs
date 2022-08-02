// Даны три числа, найдите 2, у которых наибольшая сумма

Console.WriteLine("Введите три целых числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a < b && a < c)
{
    Console.WriteLine($"наибольшая сумма чисел {b} и {c}");
}
if (b < a && b < c)
{
    Console.WriteLine($"наибольшая сумма чисел {a} и {c}");
}
if (c < a && c < b)
{
    Console.WriteLine($"наибольшая сумма чисел {a} и {b}");
}