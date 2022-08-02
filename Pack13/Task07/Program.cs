//Рекурсивно описать функцию equal(n, s), где n и s неотрицательные целые числа,
//которая проверяет, совпадает ли сумма цифр в десятичной записи числа n со значением s.
//Например: equal(12345,15)=true, equal(24,7)=false.

Console.WriteLine("Введите неотрицательное целое число n:");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите неотрицательное целое число s");
var s = int.Parse(Console.ReadLine());

bool Equal(int valueN, int valueS, int sum = 0)
{
    if (valueN < 1)
    {
        return sum == valueS ? true : false;
    }
    else
    {
        sum += valueN % 10;
        valueN /= 10;
        return Equal(valueN, valueS, sum);
    }
}
Console.WriteLine(Equal(n, s));