// Найти натуральное число из интервала от a до b с максимальной суммой делителей

Console.WriteLine("Введите а:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b:");
int b = int.Parse(Console.ReadLine());
int maxSum = 0;
int maxNum = 0;

for (int i = a; i < b + 1; i++)
{
    int temp = 0;
    for (int j = 1; j < i + 1; j++)
    {
        if (i % j == 0)
        {
            temp += j;
        }
    }

    if (maxSum < temp)
    {
        maxSum = temp;
        maxNum = i;
    }
}
Console.WriteLine($"Число с максимальной суммой делителей - {maxNum}");