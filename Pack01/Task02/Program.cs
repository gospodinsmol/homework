// Пользователь вводит время в минутах, а расстояние в километрах. Найдите скорость в м/с

Console.WriteLine("Введите время (мин):");
double time = double.Parse(Console.ReadLine());
Console.WriteLine("Введите расстояние (км):");
double distance = double.Parse(Console.ReadLine());
Console.WriteLine($"Скорость равна:{distance * 1000 / (time * 60)} м/с");
