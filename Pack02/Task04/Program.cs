// Программа для проверки числа на четность
Console.WriteLine("Введите число");
float num1 = float.Parse(Console.ReadLine());
if (num1 % 2 > 0)
{
    Console.WriteLine($"Число {num1} - нечетное");
}
else
{
    Console.WriteLine($"Число {num1} - четное");

}