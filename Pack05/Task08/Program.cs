// Вычислить число сочетаний из n элементов по m 
// C = n! / (m! * (n-m)!)

Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите m:");
int m = int.Parse(Console.ReadLine());
double result = 1; //числа большие мб, поэтому double

//конечно было бы удобнее 1 функцию вместо 3х циклов написать
for (int i = 1; i < n + 1; i++)
{
    result *= i;
}

for (int i = 1; i < m + 1; i++)
{
    result /= i;
}
for (int i = 1; i < n - m + 1; i++)
{
    result /= i;
}
Console.WriteLine($"Итого число сочетаний: {result}");