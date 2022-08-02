//Написать функцию, которая  находит минимальный элемент массива.
//С использованием этой функции реализовать сортировку выбором. 


int SearchIndexOfMinItem(int[] arr, int startIndex)
{
    var minItem = int.MaxValue;
    var minIndex = 0;
    for (var index = startIndex; index < arr.Length; index++)
    {
        if (arr[index] < minItem)
        {
            minItem = arr[index];
            minIndex = index;
        }
    }

    return minIndex;
}

void SortChoice(int[] arr)
{
    for (var index = 0; index < arr.Length; index++)
    {
        int indexOfMinItem = SearchIndexOfMinItem(arr, index);
        (arr[index], arr[indexOfMinItem]) = (arr[indexOfMinItem], arr[index]);
        
    }
    Console.WriteLine();
}

int[] arrTest = {3, 2, 6, 45, 6, 2, 3, 0};
SortChoice(arrTest);
foreach(var item in arrTest)
    Console.Write($"{item} ");
Console.WriteLine();  