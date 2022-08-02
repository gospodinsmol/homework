//Найти ту непрерывную последовательность положительных чисел,сумма элементов в которой максимальная.
//Массив заполнить случайными числами. Диапазон случайных значений от -100 до 100.

Console.WriteLine("Массив имеет вид:");
Random rnd = new Random();
int[] arr = new int[100];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-100, 100);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();
int sumMax = 0;
int sum = 0;
string sequence = "";
string sequenceMax = "";
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        sequence += arr[i].ToString() + " ";
        sum += arr[i];
    }
    else
    {
        if (sum > sumMax)
        {
            sumMax = sum;
            sequenceMax = sequence;
        }
        sum = 0;
        sequence = "";
    }
}
Console.WriteLine($"Максимальная непрерывная последовательность: {sequenceMax} , при сумме {sumMax}");
