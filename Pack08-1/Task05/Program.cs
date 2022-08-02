// Заменить все элементы с отрицательным значением на значение
// минимального не равного 0 положительного элемента.
// Максимальный размер массива 100 элементов.
// Массив заполнить случайными числами. Диапазон случайных значений от -100 до 100.

Console.WriteLine("Изначальный массив имеет вид:");
const int range = 100;
int min = range;
Random rnd = new Random();
int[] arr = new int[range];
for (int i = 0; i < range; i++)
{
    arr[i] = rnd.Next(-range, range);
    Console.Write($"{arr[i]} ");
    if (arr[i] > 0 && arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine();
Console.WriteLine("После изменения массив имеет вид:");
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0 && min < 100)
    {
        arr[i] = min;
    }
    else if (min == range)
    {
        Console.WriteLine("Положительных элементов нет");
    }
    Console.Write($"{arr[i]} ");
}