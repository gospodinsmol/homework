//Пусть имеются описания const int n = 100; float array[n].
//Рекурсивно описать процедуру PrNeg(array), которая печатает отрицательные элементы массива.

const int n = 100;

//Создаем случайный массив
float[] array = new float[n];
Random rnd = new Random();
for (int index = 0; index < n; index++)
{
    array[index] = rnd.Next(-100, 100);
    Console.Write($"{array[index]} ");
}
Console.WriteLine();

//сама функция

void PrintNegativeNumbers(float[] arr, int i = 0)
{
    if (i < arr.Length)
    {
        if (arr[i] < 0)
            Console.Write($"{arr[i]} ");
        PrintNegativeNumbers(arr, ++i);
    }
}
Console.WriteLine("Отрицательные элементы:");
PrintNegativeNumbers(array);