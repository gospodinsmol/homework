//Случайный двумерный массив со случайными значениями
//Определите  столбцы и  строки массива, в которых не содержится ни одного отрицательного элемента.
//Выведите на экран найденные индексы строк и столбцов.

var rnd = new Random();
var sizeN = rnd.Next(4, 10);
var sizeM = rnd.Next(4, 10);
int[,] arr = new int[sizeN, sizeM];
Console.WriteLine("Изначальный массив имеет вид:");
for (var indexN = 0; indexN < sizeN; indexN++)
{
    var isNonNegative = true;
    for (var indexM = 0; indexM < sizeM; indexM++)
    {
        arr[indexN, indexM] = rnd.Next(-10, 100);
        Console.Write($"{arr[indexN, indexM]} \t");
        if (arr[indexN, indexM] < 0) isNonNegative = false;
    }

    if (isNonNegative) Console.Write($" Строка {indexN} не имеет отрицательный значений");
    
    Console.WriteLine();
}

for (var indexM = 0; indexM < sizeM; indexM++)
{
    var isNonNegative = true;
    for (var indexN = 0; indexN < sizeN; indexN++)
    {
        if (arr[indexN, indexM] < 0)
        {
            isNonNegative = false;
            break;
        }
        
    }
    if (isNonNegative) Console.WriteLine($"Столбец {indexM} не имеет отрицательный значений");
}