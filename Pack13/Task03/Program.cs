//Описать рекурсивную функцию degree5(N), которая вычисляет, какой степенью числа 5
//является натуральное число N. Если N не степень пяти, функция должна вернуть число -1. 
//Например, degree5(50) = -1, degree5(125) =3, degree5(5) =1, degree5(1) =0.


Console.WriteLine("Для определения степени числа 5, введите натуральное число:");
var n = int.Parse(Console.ReadLine());

int Degree5(int itemN, int degree = 0)
{
    
    if (itemN == 5)
    {
        return ++degree;
    }
    else if (itemN % 5 > 0)
    {
        return -1;
    }
    else
    {
        ++degree;
        return Degree5(itemN / 5, degree);
    }
}

Console.WriteLine($"Результат выполнения функции: {Degree5(n)}");