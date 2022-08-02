//Реализовать 3 функции, каждая из которых принимает указатель на массив и количество элементов
//и возвращает указатель на новый массив.
//Первая функция ищет простые числа и заносит их в новый массив,
//вторая – все числа кратные трем, третья – все четные числа.
//Напишите функцию, которая принимает указатель на функцию в качестве параметра.
//Добавьте меню, в котором пользователь может выбрать желаемую операцию. Меню реализовать двумя способами.
//Сначала посчитайте количество простых элементов в массиве, потом уже создайте новый массив
//и занесите туда эти числа. 



void Menu()
{
    Console.WriteLine("Исходный массив имеет вид:");
    int[] arrayOriginal = GenerationArray();
    PrintArray(arrayOriginal);
    Console.WriteLine("Выберите номер пункта меню:");
    Console.WriteLine("'1' - Выборка из простых чисел");
    Console.WriteLine("'2' - Выборка из чисел кратных 3м");
    Console.WriteLine("'3' - Выборка из чисел кратных 2м");
    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            int[] arrayTemp = FuncSearchPrimes(arrayOriginal);
            PrintArray(arrayTemp);
            Console.WriteLine("--------------");
            break;
        case "2":
            int[] arrayTempOfThree = FuncMultipleOfThree(arrayOriginal);
            PrintArray(arrayTempOfThree);
            Console.WriteLine("--------------");
            break;
        case "3":
            int[] arrayTempOfTwo = FuncMultipleOfTwo(arrayOriginal);
            PrintArray(arrayTempOfTwo);
            Console.WriteLine("--------------");
            break;
        default:
            Console.WriteLine("Введите действительный пункт меню");
            break;
    }
    Console.WriteLine("Для вызова меню нажмите любую клавишу");
    Console.ReadLine();
    Menu();
}

int[] GenerationArray()
{
    const int sizeArr = 20;
    Random rnd = new Random();
    int[] arr = new int[sizeArr];
    for (var index = 0; index < arr.Length; index++)
    {
        arr[index] = rnd.Next(0, 100);
    }

    return arr;
}

int[] FuncSearchPrimes(int[] arr, int counter = 0)
{
    counter = Counter(arr, IsPrimes);
    return ReturnArray(arr, counter, IsPrimes);
}

int[] FuncMultipleOfThree(int[] arr, int counter = 0)
{
    counter = Counter(arr, x => x % 3 == 0);
    return ReturnArray(arr, counter, x => x % 3 == 0);
}

int[] FuncMultipleOfTwo(int[] arr, int counter = 0)
{
    counter = Counter(arr, x => x % 2 == 0);
    return ReturnArray(arr, counter, x => x % 2 == 0);
}

bool IsPrimes(int value) //проверка на простое число
{
    if (value > 1)
    {
        for (int item = 2; item <= value / 2; item++)
        {
            if (value % item == 0)
                return false;
        }

        return true;
    }
    else return false;
}

int[] ReturnArray(int[] arr, int counter, IsEqual func) //возвращает отфильтрованный массив
{
    int[] newArr = new int[counter];
    var indexNewArr = 0;
    foreach (var item in arr)
    {
        if (func(item) && indexNewArr < counter)
        {
            newArr[indexNewArr] = item;
            indexNewArr++;
        }
    }
    return newArr;
}
int Counter(int[] arr, IsEqual func) 
{
    int result = 0;
    foreach (var item in arr)
    {
        if (func(item))
            result++;
    }

    return result;
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");   
    }
    Console.WriteLine();
}

Menu();

delegate bool IsEqual(int x);


