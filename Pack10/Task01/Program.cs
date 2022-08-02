//Написать программу «справочник». Создать два одномерных массива.
//Один массив хранит номера ICQ, второй – телефонные номера.
//Реализовать меню для пользователя: 
//Отсортировать по номерам ICQ вставками
//Отсортировать по номерам телефона выбором
//Вывести список пользователей
//Найти в отсортированном массиве пользователя по номеру ICQ методом бинарного поиска
//Выход


//Создадим рандомные массивы
int[] arrICQ =new int[10];
int[] arrNumbers =new int[10];
Random rnd = new Random();
Console.WriteLine("Данные с ICQ и телефонами:");
Console.Write("ICQ\t");
Console.Write("\tNumbers");
Console.WriteLine();
for (int i = 0; i < arrICQ.Length; i++)
{
    arrICQ[i] = rnd.Next(100000000, 1000000000);
    Console.Write($"{arrICQ[i]}\t");
    arrNumbers[i] = rnd.Next(1000000, 10000000);
    Console.Write($"{arrNumbers[i]}");
    Console.WriteLine();
}

int[] arrICQSort = arrICQ; //для удобства вывода в меню создадим отдельный массив сразу отсортированный
for (int i = 1; i < arrICQSort.Length; i++) //сортировка вставками
{
    for (int j = i ; j > 0 && arrICQSort[j - 1] > arrICQSort[j]; j--)
    {
        (arrICQSort[j - 1], arrICQSort[j]) = (arrICQSort[j], arrICQSort[j - 1]);
    }
}

int[] arrNumbersSort = arrNumbers; //для удобства вывода в меню создадим отдельный массив сразу отсортированный
for (int i = 0; i < arrNumbersSort.Length; i++) //сортировка выбором
{
    int min = i;
    for (int j = i + 1; j < arrNumbersSort.Length; j++)
    {
        min = arrNumbersSort[min] > arrNumbersSort[j] ? j : min;
    }

    (arrNumbersSort[min], arrNumbersSort[i]) = (arrNumbersSort[i], arrNumbersSort[min]);
}

//реализуем меню
Console.WriteLine("Введите номер пункта меню:");
Console.WriteLine("1 - Вывести отсортированный список ICQ");
Console.WriteLine("2 - Вывести отсортированный список Телефон");
Console.WriteLine("3 - Вывести список пользователей");
Console.WriteLine("4 - Найти в отсортированном массиве номер ICQ");
Console.WriteLine("Введите любую другую клавишу для выхода");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("Отсортированный список ICQ");
        foreach (int i in arrICQSort)
        {
            Console.WriteLine(i);
        }
        break;
    
    case "2":
        Console.WriteLine("Отсортированный список телефонов");
        foreach (int i in arrNumbersSort)
        {
            Console.WriteLine(i);
        }
        break;
    
    case "3":
        Console.WriteLine("Справочник");
        Console.Write("№\t");
        Console.Write("ICQ\t");
        Console.Write("\tNumber");
        Console.WriteLine();
        for (int i = 0; i < arrNumbersSort.Length; i++)
        {
            Console.Write($"{i + 1}\t");
            Console.Write($"{arrICQSort[i]}\t");
            Console.Write($"{arrNumbers[i]}\t");
            Console.WriteLine();
        }

        break;
    
    case "4":
        Console.WriteLine("Введите номер ICQ для поиска"); //бинарный поиск
        int numberICQ = int.Parse(Console.ReadLine()); 
        int mid = arrICQSort.Length / 2;
        int low = 0;
        int hight = arrICQSort.Length - 1;
        bool flag = false;
        while (hight >= low && !flag)
        {
            mid = (hight + low) / 2;

            if (numberICQ > arrICQSort[mid]) 
                low = mid + 1;
            else if (arrICQSort[mid] == numberICQ)
                flag = true;
            else 
                hight = mid - 1;
            
        }
        if (flag)
            Console.WriteLine($"Номер {numberICQ} есть с порядковым номером {mid + 1}");
        else Console.WriteLine("Такого номера нет");

        break;
    default: 
        Console.WriteLine("Вы вышли из меню");
        break;
}