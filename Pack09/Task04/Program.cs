// Из последовательности целых чисел выбрать три числа, произведение которых максимально

Console.WriteLine("Дан массив:");
const int size = 10;
const int range = 100;
var rnd = new Random();
int[] arr = new int[size];
for (var index = 0; index < arr.Length; index++)
{
    arr[index] = rnd.Next(-range, range);
    Console.Write($"{arr[index]} ");
}
Console.WriteLine();

var max = int.MinValue;
var result = "";
for (var i = 0; i < arr.Length; i++) 
{
    for (var j = i + 1; j < arr.Length; j++)
    {
        for (var k = j + 1; k < arr.Length; k++)
        {
            if (arr[i] * arr[j] * arr[k] > max)
            {
                max = arr[i] * arr[j] * arr[k];
                result = $"{arr[i]} {arr[j]} {arr[k]} - {max}";
            }
        }
    }
}
Console.WriteLine($"Последовательность с максимальным произведением: {result}");