//Ввести 2 массива А и В целых чисел. Найти максимальный элемент массива А
//не принадлежащий массиву В.


Random rnd = new Random();
int[] arrA = new int[]{rnd.Next(-100,100), rnd.Next(-100,100), rnd.Next(-100,100), rnd.Next(-100,100), rnd.Next(-100,100)};
int[] arrB = new int[]{rnd.Next(-100,100), rnd.Next(-100,100), rnd.Next(-100,100), rnd.Next(-100,100), rnd.Next(-100,100)};
int max = int.MinValue;
bool isNotArrB = true;

foreach (int i in arrA)
{
    Console.Write($"{i} ");
    if (i > max)
    {
        foreach (int j in arrB) //Можно без цикла через Array
        {
            if (j == i)
            {
                isNotArrB = false;
                break;
            }
        }

        if (isNotArrB) max = i;
    }
}
Console.WriteLine();
Console.WriteLine($"Наибольший элемент А не пренадлежащий В: {max}");