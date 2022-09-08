//Описать рекурсивную функцию degree5(N), которая вычисляет, какой степенью числа 5
//является натуральное число N. Если N не степень пяти, функция должна вернуть число -1. 
//Например, degree5(50) = -1, degree5(125) =3, degree5(5) =1, degree5(1) =0.


Console.WriteLine("Для определения степени числа 5, введите натуральное число:");
var n = int.Parse(Console.ReadLine());

int Degree5(int itemN)
{

    if (itemN == 1)
    {
        return 0;
    }
    else if (itemN % 5 != 0)
    {
        return -1;
    }

    var degree = Degree5((itemN / 5));
    return degree == -1 ? -1 : degree + 1;
}

Console.WriteLine($"Результат выполнения функции: {Degree5(n)}");