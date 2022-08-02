//Создать копию строки и «перевернуть» в строке все слова
//(например: «Жили были дед и баба» - «илиЖ илыб дед и абаб»).

var str = "Если число соответствует этому условию, то лямбда-выражение возвращает true, а переданное число складывается с другими числами.";
var str2 = "";
string[] arrStr = str.Split(" ");
foreach (var item in arrStr)
{
    for (int index = 0; index < item.Length; index++)
    {
        str2 += item[item.Length - 1 - index];
    }

    str2 += " ";
}
Console.WriteLine(str2);