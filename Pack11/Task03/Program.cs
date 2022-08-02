//Случайный двумерный массив со случайными значениями
//Вычислить произведение элементов для каждой строки.
//Поменять местами строки с максимальным и минимальным значением произведения. 


Console.WriteLine("Задайте размер массива NxM");
Console.WriteLine("Введите N");
var sizeN = int.Parse(Console.ReadLine());
Console.WriteLine("Введите М");
var sizeM = int.Parse(Console.ReadLine());
var rnd = new Random();
int[,] arr = new int[sizeN, sizeM];
var totalMax = int.MinValue;
var indexTotalMax = 0;
var totalMin = int.MaxValue;
var indexTotalMin = 0;
Console.WriteLine("Изначальный массив имеет вид:");
for (var indexN = 0; indexN < sizeN; indexN++)
{
    var temp = 1;
    for (var indexM = 0; indexM < sizeM; indexM++)
    {
        arr[indexN, indexM] = rnd.Next(-10, 10);
        Console.Write($"{arr[indexN, indexM]} ");
        temp *= arr[indexN, indexM];
    }

    if (temp > totalMax)
    {
        totalMax = temp;
        indexTotalMax = indexN;
    }

    if (temp < totalMin)
    {
        totalMin = temp;
        indexTotalMin = indexN;
    }
    Console.WriteLine();
}

for (var index = 0; index < sizeN; index++)
{
    (arr[indexTotalMin, index], arr[indexTotalMax, index]) = (arr[indexTotalMax, index], arr[indexTotalMin, index]);
}
Console.WriteLine("Итоговый массив:");
for (var indexN = 0; indexN < sizeN; indexN++)
{
    for (var indexM = 0; indexM < sizeM; indexM++)
    {
        Console.Write($"{arr[indexN, indexM]} ");
    }
    Console.WriteLine();
}