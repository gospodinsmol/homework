// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите массу тела (кг):");
double m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите объем тела (м3):");
double v = double.Parse(Console.ReadLine());
Console.WriteLine($"Плотность тела (кг/м3) = {m/v}");