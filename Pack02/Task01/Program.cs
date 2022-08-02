// Программа для преоразования введенного дробного числа в формат расстояния в километрах  и метрах

Console.WriteLine("Введите дробное число:");
double a = double.Parse(Console.ReadLine());
int b = (int)a;
double c = a - (double)b;
Console.WriteLine($"{a} - это {b} км {c*1000} метров");