//Написать функцию, которая производит двоичный поиск места размещения нового элемента
//в упорядоченном массиве и возвращает место включения нового элемента.
//С помощью данной функции реализовать сортировку вставками.


using System.Collections.Immutable;

void SortInserts(int[] arr)
{
    for (var index = 1; index < arr.Length; index++)
    {
        for (var indexTemp = index; indexTemp > 0 && arr[indexTemp] < arr[indexTemp - 1]; indexTemp--)
        {
            (arr[indexTemp - 1], arr[indexTemp]) = (arr[indexTemp], arr[indexTemp - 1]);
        }
    }
}

void PrintArray(int[] arr)
{
    foreach(var item in arr)
        Console.Write($"{item} ");
    Console.WriteLine(); 
}

int SearchBinary(int[] arr, int itemOfSearch)
{
    SortInserts(arr);
    Console.WriteLine("Отсортированный массив методом вставок:");
    PrintArray(arr);
    
    var indexOfSearch = -1;
    
    var indexLeft = 0;
    var indexRight = arr.Length - 1;
    while (indexLeft < indexRight)
    {
        var midIndex = (indexLeft + indexRight);
        if (arr[midIndex] == itemOfSearch)
        {
            indexOfSearch = midIndex;
            break;
        }

        if (itemOfSearch < arr[midIndex])
            indexRight = midIndex - 1;
        else
            indexLeft = midIndex + 1;
        
    }
    return indexOfSearch;
    
}

void PrintResultOfSearch(int indexOfSearch)
{
    if (indexOfSearch == -1)
        Console.WriteLine("Такого элемента нет в массиве");
    else
    {
        
        Console.WriteLine($"Искуемый элемент найден под индексом: {indexOfSearch}");
    }
}

int ReadSearchItem()
{
    Console.WriteLine("Введите элемент поиска");
    var searchItem = int.Parse(Console.ReadLine());
    return searchItem;
}

int[] arrTest = {1, -3, 14, 0, -3, -33, 34, -65, 33, -34, 33};
PrintArray(arrTest);
int searchItem = ReadSearchItem();
var resultOfSearch = SearchBinary(arrTest, searchItem);
PrintResultOfSearch(resultOfSearch);




