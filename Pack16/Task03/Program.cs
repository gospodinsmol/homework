//Строка состоит из целых чисел, возможно отрицательных, разделенных пробелами или запятыми,
//найти сумму этих чисел.

using System.Dynamic;

var originalString = "12 -5 -6,-4,3,4,-5 6 7 12";
var newString = originalString.Split(new char[]{' ', ','});
var sum = 0;
foreach (var item in newString)
{
    Console.WriteLine(item);
    sum += int.Parse(item);
}
Console.WriteLine($"Сумма элементов: {sum}");
