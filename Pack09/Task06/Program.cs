// Найти сумму элементов массива А, больших данного числа В (В вводить с клавиатуры).
// Вывести массив А и сумму

Console.WriteLine("Введите число В");
int numB = int.Parse(Console.ReadLine());
int sum = 0;
Console.WriteLine("Задан массив:");
Random rnd = new Random();
int[] arr = new int[100];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, 20);
    if (arr[i] > numB) sum += arr[i];
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов больше В равна: {sum}");