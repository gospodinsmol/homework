// Подсчитать количество пар соседних элементов, которые имеют противоположные знаки.
// Максимальный размер массива 100 элементов. Массив заполнить случайными числами.
// Диапазон случайных значений от -100 до 100.

Random rnd = new Random();
int[] arr = new int[100];
byte counter = 0;
arr[0] = rnd.Next(-100, 100);
Console.WriteLine("Массив имеет вид:");
Console.Write($"{arr[0]} ");
for (int i = 1; i < 100; i++)
{
    arr[i] = rnd.Next(-100, 100);
    if (arr[i] * arr[i - 1] < 0)
    {
        counter++;
    }
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Количество пар с противоположными знаками: {counter}");