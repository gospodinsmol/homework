// Напишите программу перевода из Фаренгейта в Цельсии

Console.WriteLine("Укажите температуру в фаренгейтах:");
double farenheit = double.Parse(Console.ReadLine());
Console.WriteLine($"Температура по Цельсию:{5 * farenheit / 9 - 17.8} градусов");