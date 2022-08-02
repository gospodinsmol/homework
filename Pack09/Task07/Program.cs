// Поменять местами максимальный элемент массива и последний.
// При этом сформировать новый массив. Вывести оба массива.

Console.WriteLine("Задан массив:");
Random rnd = new Random();
int[] arr = new int[20];
int maxItem = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 10);
    Console.Write($"{arr[i]} ");
    if (arr[i] > arr[maxItem])
    {
        maxItem = i;
    }
}
Console.WriteLine();

Console.WriteLine("Новый массив имеет вид:");
int[] arr2 = arr;
(arr2[^1], arr2[maxItem]) = (arr2[maxItem], arr2[^1]);
foreach (int i in arr2)
{
    Console.Write($"{i} ");
}
