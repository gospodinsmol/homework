// Пользователь вводит любое целое число.
// Необходимо из этого целого числа удалить все цифры 3 и 6  вывести обратно на экран

Console.WriteLine("Введите число");
string num = Console.ReadLine();
for (int i = 0; i < num.Length - 1; i++)
{
    if (num[i] != '3' && num[i] != '6')
    {
        Console.Write(num[i]);
    }
}