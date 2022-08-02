// даны три числа. указать yes если есть одинаковые

Console.WriteLine("Введите три целых числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a == b || a == c || b == c)
{
    Console.WriteLine("yes");
}