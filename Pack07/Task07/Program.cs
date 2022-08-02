// Для заданного натурального числа n  вывести первые n простых чисел


Console.WriteLine("Введите натуральное число");
int n = int.Parse(Console.ReadLine());
int counter = 0; //счетчик количества простых чисел
int numbers = 2; //числа на проверку
bool flag;
while (counter < n)
{
    flag = true;
    for (int k = 2; k <= numbers / 2; k++)
    {
        if (numbers % k == 0)
        {
            flag = false;
            break;
        } 
    }

    if (flag)
    {
        Console.WriteLine(numbers);
        counter++;
    }

    numbers++;

}