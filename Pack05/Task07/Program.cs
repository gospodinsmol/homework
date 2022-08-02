// Найти все правильные несократимые дроби, знаменатель которых меньше заданного числа

Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i < n; i++)
{
    bool flag = true;
    for (int j = 1; j < i; j++)
    {
        for (int k = 2; k < j + 1; k++)
        {
            if (i % k == 0 & j % k == 0)
            {
                flag = false;
                break;
            }
        }
        if (flag)
        {
            Console.WriteLine($"{j}/{i}");
        }

        flag = true;
    }
}