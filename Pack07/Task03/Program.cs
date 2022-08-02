// Найти сумму членов ряда, член ряда вычисляется по формуле а = (-1^n) (n + 1) / 2^(n-1). 
// n задается пользователем

Console.WriteLine("Введите n");
int n = int.Parse(Console.ReadLine());
double sum = 0;
for (int i = 1; i < n + 1; i++)
{
    sum += Math.Pow(-1, i) * (i + 1) / Math.Pow(2, i - 1);
}
Console.WriteLine($"Сумма ченов ряда равна: {sum}");