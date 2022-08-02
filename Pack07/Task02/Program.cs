// Ввести с клавиатуры натуральное число, получить другое натуральное число записанное в обратном порядке

Console.WriteLine("Введите число:");
var num = int.Parse(Console.ReadLine());
int res = 0;
while (num >= 1)
{
    res = res * 10 + num % 10;
    num /= 10;
}
Console.WriteLine(res);
