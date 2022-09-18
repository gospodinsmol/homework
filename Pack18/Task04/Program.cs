// Выяснить является ли число степенью двойки, используя битовые операции.

Console.WriteLine("Введите число:");
var input = int.Parse(Console.ReadLine());
var counter = 0;
var item = 1;

if (input == 0)
{
    Console.WriteLine("ноль не является степенью двойки");
}
while (item < input)
{
    item <<= 1;
    counter++;
}

Console.WriteLine(item == input
    ? $"Число {input} является {counter}й степенью 2ки"
    : $"Число {input} не является степенью 2ки");