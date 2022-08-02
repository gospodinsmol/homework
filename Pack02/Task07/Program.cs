// Программа для вычисления оптимального веса, сравнивает его с реальным
//и выдает рекомендацию

Console.WriteLine("Введите Ваш рост");
int h = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Ваш вес");
int m = int.Parse(Console.ReadLine());
if (h - 100 == m)
{
    Console.WriteLine("Ваш Вес идеальный");
}
else if (h - 100 < m)
{
    Console.WriteLine($"Вам нужно похудеть на {m- (h - 100)} кг");
}
else
{
    Console.WriteLine($"Ты похож(а) на дистрофана, нужно набрать {h - 100 - m} кг");
}