// Напечатать в возрастающем порядке все трехзначные числа, в десятичной записи,
// У которых нет одинаковых цифр
;
for (int i = 100; i < 1000; i++)
{
    if ((i / 100) != (i % 10) && (i / 100) != (i % 100 / 10) && (i % 10) != (i % 100 / 10))
    {
        Console.WriteLine(i);
    }

}