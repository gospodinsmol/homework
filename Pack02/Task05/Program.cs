// ПРограмма для проверки, заканчивается ли число на 0

Console.WriteLine("Введите целое число");
int num1 = int.Parse(Console.ReadLine());
if (num1 % 10 > 0)
{
    Console.WriteLine($"Число {num1} - нет");
}
else
{
    Console.WriteLine($"Число {num1} - да");

}