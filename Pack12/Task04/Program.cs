//Реализовать функции для обработки массива целых чисел.
//Функция находит минимальный элемент массива и сортирует все элементы левее его по убыванию,
//а правее его – по возрастанию. Функция возвращает индекс минимального элемента.

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

int SearchIndexOfMinItem(int[] arr)
{
    var minItem = int.MaxValue;
    var minIndex = 0;
    for (var index = 0; index < arr.Length; index++)
    {
        if (arr[index] < minItem)
        {
            minItem = arr[index];
            minIndex = index;
        }
    }
    return minIndex;
}

void SortBeforeAfterMin(int[] arr, int indexOfMinItem)
{
    for (var indexBefore = 0; indexBefore < indexOfMinItem; indexBefore++) //сортировка по убыванию
    {
        for (var indexTemp = indexBefore; indexTemp < indexOfMinItem; indexTemp++)
        {
            if (arr[indexBefore] < arr[indexTemp])
                (arr[indexBefore], arr[indexTemp]) = (arr[indexTemp], arr[indexBefore]);
        }
    }
    for (var indexAfter = indexOfMinItem + 1; indexAfter < arr.Length; indexAfter++) //сортировка по возрастанию
    {
        for (var indexTemp = indexAfter; indexTemp < arr.Length; indexTemp++)
        {
            if (arr[indexAfter] > arr[indexTemp])
                (arr[indexAfter], arr[indexTemp]) = (arr[indexTemp], arr[indexAfter]);
        }
    }
}

int[] arr = GeneratorRandomArray(10, -100, 100);
PrintArray(arr);
int minIndex = SearchIndexOfMinItem(arr);

SortBeforeAfterMin(arr, minIndex);
PrintArray(arr);