//Определить является ли квадратная матрица магическим квадратом.
//Матрица называется магическим квадратом,
//если сумма элементов каждой строки равна сумме элементов каждого столбца
//и равна сумме элементов стоящих на диагоналях.

Random rnd = new Random();
var sizeArr = rnd.Next(4, 10);
int[,] arr = new int[sizeArr, sizeArr];
//задать магический квадрат:
//var sizeArr = 3;
//int[,] arr = new int[3, 3]{{4, 9, 2}, {3, 5, 7}, {8, 1, 6}};


var sumDiagFirst = 0;
var sumDiagSecond = 0;
var isEquals = true;
var sumLine = 0;
var sumColumn = 0;
for (var indexLine = 0; indexLine < sizeArr; indexLine++)
{
    sumLine = 0;
    sumColumn = 0;
    
    for (var indexColumn = 0; indexColumn < sizeArr; indexColumn++)
    {
        arr[indexLine, indexColumn] = rnd.Next(1, 10);
        Console.Write($"{arr[indexLine, indexColumn]}\t");
        sumColumn += arr[indexColumn, indexLine];
        sumLine += arr[indexLine, indexColumn];
        if (indexColumn == indexLine)
            sumDiagFirst += arr[indexLine, indexColumn];
        if (indexLine == sizeArr - indexColumn - 1)
            sumDiagSecond += arr[indexLine, indexColumn];
    }
    Console.WriteLine();
    if (sumColumn != sumLine) isEquals = false;
}

if (isEquals && sumDiagFirst == sumDiagSecond && sumDiagFirst == sumLine)
{
    Console.WriteLine("Матрица является магическим квадратом");
}
else
{
    Console.WriteLine("Матрица не является магическим квадратом");
}