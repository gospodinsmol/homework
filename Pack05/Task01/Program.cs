//Пользователь вводит число n,  Напишите программу, которая находит сумму чисел:
//1 + 1/1! + 1/2! + ... + 1/n!


Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
double sum = 1.0;
ulong factorial = 1;

for (ushort x = 1; x <= n; ++x)
{
    factorial *= x;
    sum += (1.0 / factorial);
}
Console.WriteLine($"при n = {n} результат выражения: {sum}");