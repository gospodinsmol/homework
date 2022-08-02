//Рекурсивно описать функцию Search(A,size,key), определяющую,
//входит ли целое число key в упорядоченный по возрастанию массив  A типа int.

//упорядочный массив
Console.WriteLine("Введите целое число по которому будет осуществляться поиск");
var key = int.Parse(Console.ReadLine());
var size = 10;
int[] array = new int[size];
Console.WriteLine("Массив имеет вид:");
for (int index = 0; index < array.Length; index++)
{
    array[index] = index * index;
    Console.Write($"{array[index]} ");
}
Console.WriteLine();

bool Search(int[] arr, int sizeArr, int keyValue)
{
    if (sizeArr > 0)
    {
        if (keyValue == arr[sizeArr - 1])
            return true;
        else
            return Search(arr, sizeArr - 1, keyValue);
    }
    else
        return false;
}

if (Search(array, size, key))
    Console.WriteLine($"Число {key} в массиве присутствует");
else
    Console.WriteLine("Такого числа в массиве нет");