// Дан массив целых чисел, в котором все числа кроме одного встречаются четное количество раз,
// одно число встречается нечетное количество раз. Найти это число. Решить задачу используя битовые операции.


using System.Diagnostics.Metrics;

var nums = new int[]{1, 2, 3, 4, 5, 6, 7, 7, 1, 2, 3, 4, 5, 6, 7};

for (var i = 0; i < nums.Length; i++)
{
    var counter = 0;
    for (var j = i; j < nums.Length; j++)
    {
        if (nums[i] == nums[j])
        {
            counter++;
        }
    }

/*    var tempCounterConvert = Convert.ToString(counter, 2);
    if (tempCounterConvert[^1] == '1')
    {
        Console.WriteLine($"Число {nums[i]} повторяется нечетное количество раз");
        break;
    } */

    if ((counter & 1) == 1)
    {
        Console.WriteLine($"Число {nums[i]} повторяется нечетное количество раз");
        break;
    }
}