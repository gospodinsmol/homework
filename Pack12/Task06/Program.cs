//Функция сортирует массив по возрастанию последней цифры каждого элемента массива.

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

void SortOfLastDigit(int[] arr)
{
    var lastDigit = 0;
    for (var index = 0; index < arr.Length; index++)
    {
        for (var indexTemp = index; indexTemp < arr.Length; indexTemp++)
        {
            if (Math.Abs(arr[index] % 10) > Math.Abs(arr[indexTemp] % 10))
            {
                (arr[index], arr[indexTemp]) = (arr[indexTemp], arr[index]);
            }
        }
    }
}

int[] arr = GeneratorRandomArray(10, -100, 100);
PrintArray(arr);
SortOfLastDigit(arr);
PrintArray(arr);