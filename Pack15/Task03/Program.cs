//Пользователь вводит строку символов и искомый символ,
//посчитать сколько раз он встречается в строке.

Console.WriteLine("Введите строку символов");
var str = Console.ReadLine();
Console.WriteLine("Введите искомый символ");
var symbol = char.Parse(Console.ReadLine());
var counter = 0;

foreach(var item in str)
    if (item == symbol)
        counter++;

Console.WriteLine(str);
Console.WriteLine($"Символ {symbol} встречает {counter} раз");
