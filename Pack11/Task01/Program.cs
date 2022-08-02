//Случайный двумерный массив со случайными значениями
//Отсортировать методом вставок элементы в каждой строке,
//методом бинарного поиска найти в каждой строке заданный  элемент и вывести на экран. 


Console.WriteLine("Задайте размер массива NxM");
Console.WriteLine("Введите N");
var sizeN = int.Parse(Console.ReadLine());
Console.WriteLine("Введите М");
var sizeM = int.Parse(Console.ReadLine());
var rnd = new Random();
int[,] arr = new int[sizeN, sizeM];
Console.WriteLine("Изначальный массив имеет вид:");
for (var indexN = 0; indexN < sizeN; indexN++)
{
    for (var indexM = 0; indexM < sizeM; indexM++)
    {
        arr[indexN, indexM] = rnd.Next(-100, 100);
        Console.Write($"{arr[indexN, indexM]} ");
    }
    Console.WriteLine();
}

//сортировка вставками
for (var indexN = 0; indexN < sizeN; indexN++)
{
    for (var indexM = 1; indexM < sizeM; indexM++)
    {
        for (var indexTemp = indexM; indexTemp > 0 && arr[indexN, indexTemp] < arr[indexN, indexTemp - 1]; indexTemp--)
        {
            (arr[indexN, indexTemp], arr[indexN, indexTemp - 1]) = (arr[indexN, indexTemp - 1], arr[indexN, indexTemp]);
            
        }
    }
}

Console.WriteLine("Массив после сортировки:");
for (var indexN = 0; indexN < sizeN; indexN++)
{
    for (var indexM = 0; indexM < sizeM; indexM++)
    {
        Console.Write($"{arr[indexN, indexM]} ");
    }
    Console.WriteLine();
}

//бинарный поиск
Console.WriteLine("Введите число для поиска:");
var searchNum = int.Parse(Console.ReadLine());

for (var indexN = 0; indexN < sizeN; indexN++)
{
    var indexRight = sizeM;
    var indexLeft = 0;
    var isContain = false;
    while (indexRight >= indexLeft && !isContain)
    {
        var indexMiddle = (indexRight + indexLeft) / 2;
        if (searchNum == arr[indexN, indexMiddle])
        {
            isContain = true;
        }
        else if (searchNum > arr[indexN, indexMiddle])
        {
            indexLeft = indexMiddle + 1;
        }
        else
        {
            indexRight = indexMiddle - 1;
        }
        
    }

    var result = isContain ? $"В строчке {indexN} найдено число {searchNum}" : $"В строчке {indexN} числа {searchNum} нет";
    Console.WriteLine(result);
    
}