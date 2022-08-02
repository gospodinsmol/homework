//Случайный двумерный массив со случайными значениями 
//Заполните главные диагонали массива нулями. 


var rnd = new Random();
var sizeN = rnd.Next(4, 10);
var sizeM = rnd.Next(4, 10);
int[,] arr = new int[sizeN, sizeM];
Console.WriteLine("Изначальный массив имеет вид:");
for (var indexN = 0; indexN < sizeN; indexN++)
{
    for (var indexM = 0; indexM < sizeM; indexM++)
    {
        arr[indexN, indexM] = rnd.Next(-100, 100);

        if (indexM == indexN)
        {
            arr[indexN, indexM] = 0;
        }
        if (indexN == sizeM - indexM - 1)
        {
            arr[indexN, indexM] = 0;
        }
        Console.Write($"{arr[indexN, indexM]} \t");
    }
   
    Console.WriteLine();
}