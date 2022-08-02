// Дана последовательность A=(ai), i=0..n, n<100.
// Найти  номера всех  наименьших  элементов. Элементы последовательности вводятся с клавиатуры.

Console.WriteLine("Введите количество элементов последовательности");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите {n} элементов последовательности");
int[] nums = new int[n];
int minVal = int.MaxValue;
int minNum = 0;
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = int.Parse(Console.ReadLine());
    if (nums[i] < minVal)
    {
        minVal = nums[i];
        minNum = i + 1;
    }
}
Console.WriteLine($"Минимальный элемент с порядковым номером {minNum} и значением {minVal}");