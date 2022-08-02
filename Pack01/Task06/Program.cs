// Составить программу решения линейного уравнения ax+b=0, a!=0
Console.WriteLine("Уравнение ax+b=0. Введите данные a, b:");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
Console.WriteLine($"Уравнение имеет вид: {a}x+{b}=0");
Console.WriteLine($"x = {- b / a}");
