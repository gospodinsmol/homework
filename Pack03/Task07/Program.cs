// Даны 4 числа, если первые два числа больше 5, третье число делится на 6, четвертое число не делится на 3
//то вывести yes, иначе  no

Console.WriteLine("Введите 4 целых числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

if (a > 5 & b > 5 & c % 6 == 0 & d % 3 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}