//Дан массив натуральных чисел.
//Составить программу, которая выполняет сортировку его элементов следующим образом:
//сначала идут элементы, кратные числу K (дают 0 в остатке от деления на K),
//затем те, которые при делении на K дают в остатке 1, и т.д.
//Последнюю группу составляют числа, остаток от деления на K которых равен K-1.
//Затем в каждой из полученных групп выполнить сортировку
//в порядке возрастания разности минимальной и максимальной цифр в записи чисел.


Console.WriteLine("Введите число К:");
int numK = int.Parse(Console.ReadLine());
const int maxNum = 20;
Console.WriteLine("Задан массив:");
Random rnd = new Random();
int[] arr = new int[20];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(0, maxNum);
    Console.Write($"{arr[i]} ");
}
Console.WriteLine();

int counter = 0;
for (int j = 0; j < numK; j++)
{
    int prevCounter = counter;
    for (int i = j; i < arr.Length; i++) //Сортировка по группам
    {
        if (arr[i] % numK == j)
        {
            (arr[counter], arr[i]) = (arr[i], arr[counter]);
            counter++;
        }
    }

    for (int i = prevCounter + 1; i <= counter; i++) //cортировка каждой группы по возрастанию, пузырьком
    {
        for (int k = prevCounter + 1; k < counter; k++)
        {

            if (Math.Abs(arr[k - 1] % 10 - arr[k - 1] / 10) > Math.Abs(arr[k] % 10 - arr[k] / 10))
            {
                (arr[k - 1], arr[k]) = (arr[k], arr[k - 1]);
            }
            
        }
    }

}

Console.WriteLine("Итоговый массив:");
foreach (int i in arr)
{
    Console.Write(i+" ");
}