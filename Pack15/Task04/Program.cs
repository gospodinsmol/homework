//В строке найти частоты всех двухбуквенных сочетаний и вывести.
//Например: Ехали ли вы, да, да, да. Результат: ли-1 вы-1 да-3.

var str =
    "A string is a sequential collection of characters that's used to represent text. A String object is a sequential collection of System.Char objects that represent a string; a System.Char object corresponds to a UTF-16 code unit. The value of the String object is the content of the sequential collection of System.Char objects, and that value is immutable (that is, it is read-only). For more information about the immutability of strings, see the Immutability and the StringBuilder class section. The maximum size of a String object in memory is 2-GB, or about 1 billion characters.";
Console.WriteLine("Исходный текст:");
Console.WriteLine(str);
string[] arrStr = str.Split(" ");
for (var indexArr = 0; indexArr < arrStr.Length; indexArr++)
{
    if (arrStr[indexArr].Length == 2)
    {
        int counter = (str.Length - str.Replace(arrStr[indexArr], "").Length) / arrStr[indexArr].Length;
        if (counter > 0)
        {
            Console.WriteLine($"Подстрока {arrStr[indexArr]} встречается {counter} раз");
            str = str.Replace(arrStr[indexArr], "");
        }
    }
}