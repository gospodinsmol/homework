//Случайный двумерный массив со случайными значениями
//Вычислить сумму чисел в каждой строке. 
//Вычислить произведение чисел в каждом столбце. 
//Вычислить сумму элементов матрицы, которые расположены выше главной диагонали. 
//Вычислить сумму элементов матрицы, которые расположены ниже побочной диагонали матрицы. 



Console.WriteLine("Задайте размер массива NxM");
Console.WriteLine("Введите N");
var sizeN = int.Parse(Console.ReadLine());
Console.WriteLine("Введите М");
var sizeM = int.Parse(Console.ReadLine());
var rnd = new Random();
int[,] arr = new int[sizeN, sizeM];
var resultSum = "";
var resultTotal = "";
var sumMainDiag = 0;
var sumSecondDiag = 0;
Console.WriteLine("Массив имеет вид:");
for (var indexN = 0; indexN < sizeN; indexN++)
{
    var sum = 0;
    for (var indexM = 0; indexM < sizeM; indexM++)
    {
        arr[indexN, indexM] = rnd.Next(0, 2);
        Console.Write($"{arr[indexN, indexM]} ");
        sum += arr[indexN, indexM];
        if (indexM > indexN) sumMainDiag += arr[indexN, indexM];
        if (indexN >= sizeM - indexM) sumSecondDiag += arr[indexN, indexM];
    }
     
    resultSum += $"Сумма {indexN + 1}й строки = {sum} \n";
    Console.WriteLine();
}

//произведение чисел столбцов
for (var indexM = 0; indexM < sizeM; indexM++)
{
    var total = 1;
    for (var indexN = 0; indexN < sizeN; indexN++)
    {
        total *= arr[indexN, indexM];
    }
    resultTotal += $"Произведение {indexM + 1}го столбца = {total} \n";
}

Console.WriteLine(resultSum);
Console.WriteLine();
Console.WriteLine(resultTotal);
Console.WriteLine($"Сумма выше главной диагонали:{sumMainDiag}");
Console.WriteLine($"Сумма ниже вторичной диагонали:{sumSecondDiag}");