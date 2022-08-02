// Написать программу, копирующую элементы 2-х массивов размером 5 элементов
// каждый в один массив размером 10 элементов  следующим образом:
// сначала копируются последовательно все элементы, большие 0,
// затем последовательно все элементы, равные 0, а затем последовательно все элементы, меньшие 0.
// Элементы последовательности вводятся с клавиатуры

Console.WriteLine("Введите 5 элементов 1го массива");
int[] arr1 = new int[5]
{
    int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())
};
Console.WriteLine("Введите 5 элементов 2го массива");
int[] arr2 = new int[5]
{
    int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()),
    int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())
};
int[] arrTen = new int[10];
int indexOfTen = 0;
for (int i = 0; i < 5; i++)
{
    if (arr1[i] > 0)
    {
        arrTen[indexOfTen] = arr1[i];
        indexOfTen++;
    }
    if (arr2[i] > 0)
    {
        arrTen[indexOfTen] = arr2[i];
        indexOfTen++;
    }
}
for (int i = 0; i < 5; i++)
{
    if (arr1[i] == 0)
    {
        arrTen[indexOfTen] = arr1[i];
        indexOfTen++;
    }
    if (arr2[i] == 0)
    {
        arrTen[indexOfTen] = arr2[i];
        indexOfTen++;
    }
}
for (int i = 0; i < 5; i++)
{
    if (arr1[i] < 0)
    {
        arrTen[indexOfTen] = arr1[i];
        indexOfTen++;
    }
    if (arr2[i] < 0)
    {
        arrTen[indexOfTen] = arr2[i];
        indexOfTen++;
    }
}
Console.WriteLine("Массив из 10 символов:");
foreach (int i in arrTen)
{
    Console.Write(i + " ");
}