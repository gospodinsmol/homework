//Рекурсивно описать процедуру RevPrint(N),
//которая печатает в обратном порядке цифры десятичной записи целого неотрицательного числа N.
//Например, RevPrint(12345) должна вывести текст 54321.


Console.WriteLine("Введите число N");
var n = int.Parse(Console.ReadLine());

void RevPrint(int num)
{
    Console.Write(num % 10);
    if (num / 10 != 0)
    {
        RevPrint(num / 10);
    }
}
RevPrint(n);
Console.WriteLine();