﻿// Какой по счету пассажир пострадает, если лифт выдерживает вес не более S кг,
// а вес пассажиров равен соответственно а1. а2,.. аn


Console.WriteLine("Введите максимальную нагрузку лифта, кг : ");
int s = int.Parse(Console.ReadLine());
int sum = 0; // фактическая нагрузка на лифт
int a = 0; //порядковый номер пассажира
while (sum <= s)
{
    a++;
    Console.WriteLine($"Ввведите вес {a}го пассажира:");
    sum += int.Parse(Console.ReadLine());
}
Console.WriteLine($"{a}й пассажир не влезет");