// Написать yes если из двух чисел можно составить третье

Console.WriteLine("Введите три целых числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a + c == b || a + b == c || b + c == a)
{
    Console.WriteLine("yes");
}