//Функция находит элемент массива, минимально удаленный от арифметического среднего значения
//всех элементов массива и сортирует все элементы левее его по убыванию и правее его – по убыванию.
//Функция возвращает индекс разделяющего элемента.


int[] GeneratorRandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (var index = 0; index < arr.Length; index++)
        arr[index] = rnd.Next(minValue, maxValue);
    return arr;
}
void PrintArray(int[] arr)
{
    foreach(var item in arr)
        Console.Write($"{item} ");
    Console.WriteLine(); 
}

int SearchIndexOfMinDif(int[] arr)
{
    var minDif = int.MaxValue;
    var minIndexDif = 0;
    var sum = 0;
    for (var index = 0; index < arr.Length; index++)
        sum += arr[index];

    var midValue = sum / arr.Length;
    for (var index = 0; index < arr.Length; index++)
    {
        if (Math.Abs(midValue - arr[index]) < minDif)
        {
            minDif = Math.Abs(midValue - arr[index]);
            minIndexDif = index;
        }
    }
    return minIndexDif;
}

void SortBeforeAfterMinDif(int[] arr, int indexOfMinDif)
{
    
    for (var indexBefore = 0; indexBefore < indexOfMinDif; indexBefore++) //сортировка по убыванию
    {
        for (var indexTemp = indexBefore; indexTemp < indexOfMinDif; indexTemp++)
        {
            if (arr[indexBefore] < arr[indexTemp])
                (arr[indexBefore], arr[indexTemp]) = (arr[indexTemp], arr[indexBefore]);
        }
    }
    for (var indexAfter = indexOfMinDif + 1; indexAfter < arr.Length; indexAfter++) //сортировка по убыванию
    {
        for (var indexTemp = indexAfter; indexTemp < arr.Length; indexTemp++)
        {
            if (arr[indexAfter] < arr[indexTemp])
                (arr[indexAfter], arr[indexTemp]) = (arr[indexTemp], arr[indexAfter]);
        }
    }
}

int[] arr = GeneratorRandomArray(10, -100, 100);
PrintArray(arr);
int minIndexDif = SearchIndexOfMinDif(arr);
Console.WriteLine($"Индекс элемента с минималной разницей со средним арифм.: {minIndexDif}");
SortBeforeAfterMinDif(arr, minIndexDif);
PrintArray(arr);


