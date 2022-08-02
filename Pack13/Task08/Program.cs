//Рекурсивно описать функцию divs(n) для подсчета количества всех делителей целого числа n
//(n>1), без учета делителей 1 и n.  Например: divs(5)=0, divs(18)=4.

Console.WriteLine("Ввелите число n (n>1):");
var n = int.Parse(Console.ReadLine());

int Divs(int nValue, int divider = 2, int counter = 0)
{
    if (nValue <= divider) return counter;
    else
    {
        if (nValue % divider == 0)
            counter++;
        return Divs(nValue, ++divider, counter);
    }
}

Console.WriteLine($"Количество делителей n: {Divs(n)}");