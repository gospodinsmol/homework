//Написать функцию с параметрами по умолчанию, которая принимает три числа
//и показывает на экран все числа от 0 до 1000, которые одновременно кратны всем трем параметрам.


void ShowMultiplesOf(int num1, int num2, int num3)
{
    for (var item = 0; item < 1000; item++)
    {
        if (item % num1 == 0 && item % num2 == 0 && item % num3 == 0)
            Console.WriteLine($"Число {item} кратно всем трем параметрам");
    }
}

var test1 = 11;
var test2 = 41;
var test3 = 38;

ShowMultiplesOf(test1, test2, test3);