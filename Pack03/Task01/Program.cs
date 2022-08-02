// Если первое больше второго то YES, иначе поменять значения местами и вывести их на экран

Console.WriteLine("Введите два целых числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("yes");
}
else
{
    (a, b) = (b, a);
    Console.WriteLine($"1ое число теперь - {a}, а второе - {b}");
}