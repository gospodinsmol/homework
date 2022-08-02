// Необходимо отсортировать первые две трети массива
// в порядке возрастания, если среднее арифметическое всех элементов больше нуля;
// иначе - лишь первую треть. Остальную часть массива не сортировать, а расположить в обратном порядке.


//Создаем рандомный массив
Console.WriteLine("Массив имеет вид");
int [] arr = new int[12];
Random rnd = new Random();
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-100, 100);
    Console.Write($"{arr[i]} ");
    sum += arr[i];
}
Console.WriteLine();
int numSort = sum / arr.Length > 0 ? arr.Length * 2 / 3 : arr.Length / 3; //индекс до которого сортировать
int counter = 1;

for (int i = 1; i < arr.Length; i++)
{
    if (i < numSort)
    {
        for (int j = i ; j > 0 && arr[j - 1] > arr[j]; j--) //сортировка вставками
        {
            (arr[j - 1], arr[j]) = (arr[j], arr[j - 1]);
        }
    }
    else if (i < numSort + ((arr.Length - numSort)/2))
    {
        (arr[i], arr[arr.Length - counter]) = (arr[arr.Length - counter], arr[i]);
        counter++;
    }
}

Console.WriteLine("Отсортированный массив:");
foreach (int i in arr)
{
    Console.Write($"{i} ");
}