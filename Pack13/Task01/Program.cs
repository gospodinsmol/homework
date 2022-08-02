//Описать рекурсивную функцию f(x,n), вычисляющую величину  x^n/n!
//при любом вещественном x и любом неотрицательном целом n.


Console.WriteLine("Введте х");
var x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите n");
var n = int.Parse(Console.ReadLine());


double FuncRecurs(double xItem, int nItem)
{
    if (nItem == 1)
    {
        return 1;
    }
    else
    {
        return (xItem / nItem) * FuncRecurs(xItem,  (nItem - 1));
    }
}
Console.WriteLine($"Итог вычисления функции: {FuncRecurs(x, n)}");