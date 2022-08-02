// Использую вложенные циклы, напечатайте числа в ввиде таблиц
// (таблц.1 (4 строки по 5 5 5 5 5),
//Таблц.2 (от 1 до 10  - 4 строки)
//Таблц.3 (от 41 до 40 - 4 строки)

for (int i = 1; i < 5; i++)
{
    for (int j = 1; j < 6; j++)
    {
        Console.Write("5 ");
    }
    Console.Write("    ");
    for (int j = 1; j <= 10; j++)
    {
        Console.Write(j + " ");
    }
    Console.Write("    ");
    for (int j = 41; j <= 50; j++)
    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}