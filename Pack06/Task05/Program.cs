// Найти максимальную цифру натурального числа

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int max = 1;
while (num > 1)
{
    max = max > num % 10 ? max : num % 10;
    num /= 10;
}
Console.WriteLine(max);