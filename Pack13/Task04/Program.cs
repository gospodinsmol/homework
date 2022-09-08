//Рекурсивно описать функцию maxdig(N), которая находит наибольшую цифру в десятичной записи
//неотрицательного целого числа N. Например, maxdig(27306) = 7.



Console.WriteLine("Введите неотрицательное целое число N");
var n = int.Parse(Console.ReadLine());

/*int MaxDig(int itemN, int max = 0)
{
    if (itemN == 0)
        return max;
    else
    {
        max = max < itemN % 10 ? itemN % 10 : max;
        return MaxDig(itemN / 10, max);
    }
}*/
int MaxDig(int itemN)
{
    if (itemN < 10)
    {
        return itemN;
    }

    if (MaxDig(itemN / 10) < itemN % 10)
    {
        return itemN % 10;
    }

    return MaxDig(itemN / 10);
}

Console.WriteLine($"Максимальная цифра в числе {n}: {MaxDig(n)}");