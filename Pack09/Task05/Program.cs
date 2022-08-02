// Задан одномерный массив. Подсчитать количество нулевых зон

Console.WriteLine("Задан массив:");
Random rnd = new Random();
int[] arr = new int[100];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 2);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

int counter = arr[arr.Length - 1] == 0 ? 1: 0;

for (int j = 0; j < arr.Length - 1; j++)
{
    if (arr[j] == arr[j + 1] && arr[j] == 0)
    {
        continue;
    }
    if (arr[j] == 0)
    {
        counter++;
    }
}
Console.WriteLine($"Количество нулевых зон: {counter}");