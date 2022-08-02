// Найти сумму цифр для заданного натурального числа. Диалог с пользователем реализовать при помощи меню
Console.WriteLine("Введите пожалуйста натуральное число:");
int n = int.Parse(Console.ReadLine());
int sum = 0;
while (n > 0)
{
    sum += n % 10;
    n /= 10;
}
Console.WriteLine($"Сумма цифр числа: {sum}");