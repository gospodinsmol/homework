// Даны 4 числа, задача найти наибольшее четное число

Console.WriteLine("Введите 4 целых числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

if (a <= b && b % 2 == 0)
{
    a = b;
}
if (a <= c && c % 2 == 0)
{
    a = c;
}
if (a <= d && d % 2 == 0)
{
    a = d;
}

if (a % 2 != 0)
{
    Console.WriteLine("Not found");
}
else
{
    Console.WriteLine("Наибольшее четное число: " + a);
}