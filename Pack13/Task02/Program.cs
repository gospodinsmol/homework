//Не используя операции умножения и деления, рекурсивно описать функцию Mod(a,b)
//от целых чисел a и b (a≥0, b>0), которая вычисляет остаток от деления a на b

Console.WriteLine("Введите a a≥0:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b (b>0)");
int b = int.Parse(Console.ReadLine());

int Mod(int divident, int divider)
{
    if (divident < divider)
    {
        return divident;
    }
    divident -= divider;
    return Mod(divident, divider);
}

Console.WriteLine($"Мод при делении числа {a} на число {b}: {Mod(a, b)}");