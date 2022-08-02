//Рекурсивно описать функцию Head3(n), которая вычисляет число,
//получаемое приписыванием слева цифры 3 к десятичной записи целого неотрицательного числа n.
//Например: Head3(1592)=31592.

Console.WriteLine("Введите целое неотрицательное число n:");
var n = int.Parse(Console.ReadLine());
const byte num = 3;

int Head3(int valueN, int tenner = 10)
{
    if (valueN / tenner < 1)
        return valueN + tenner * num;
    else
    {
        return Head3(valueN, tenner * 10);
    }
}

Console.WriteLine(Head3(n));