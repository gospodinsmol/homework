//В строке все вхождения подстроки str1 заменить подстрокой str2. Str2 вводится с клавиатуры.

var str = "Жили у бабуси два веселых гуся. Один серый, другой белый. Два веселых гуся";
var str1 = "гус";
Console.WriteLine("Введите подстроку2");
var str2 = Console.ReadLine();
str = str.Replace(str1, str2);
Console.WriteLine(str);
