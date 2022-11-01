// Дан массив целых чисел, в котором все числа кроме одного встречаются четное количество раз,
// одно число встречается нечетное количество раз. Найти это число. Решить задачу используя битовые операции.

var nums = new[]{1, 2, 3, 4, 5, 6, 7, 7, 1, 2, 3, 4, 5, 6, 7};
var result = nums.Aggregate((result, item) => result ^ item);
Console.WriteLine($"The number {result} is repeated an odd number of times");