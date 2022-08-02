// ПРограмма для проверки, начинается ли число с 1

Console.WriteLine("Введите целое число");
int num1 = int.Parse(Console.ReadLine());
if (num1 / 10 == 1)
{
    Console.WriteLine($"Число {num1} - да");
}
else
{
    Console.WriteLine($"Число {num1} - нет");

}