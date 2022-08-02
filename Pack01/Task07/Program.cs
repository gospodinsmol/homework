// Составить программу, которая запрашивает количество жителей
// и площадь страны и вычисляет и выводит плотность населения

Console.WriteLine("Введите количество жителей (чел):");
double m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите площадь страны (м2):");
double v = double.Parse(Console.ReadLine());
Console.WriteLine($"Плотность населения (чел/м2) = {m/v}");