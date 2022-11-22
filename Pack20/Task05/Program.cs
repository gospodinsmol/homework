// Дан текстовый файл. Необходимо создать новый файл и записать в него
// следующую статистику по исходному файлу:
// Количество символов
// Количество строк
// Количество гласных букв
// Количество согласных букв
// Количество цифр.


const string path = @"/home/smol/homework/Pack20/Task05/NewFile.txt";
const string vowels = "аоуеыэяиюeyuioa";
var text = File.ReadAllText(path);
var countOfSymbols = text.Length;
var countLines = File.ReadAllLines(path).Length;
var numbers = text.Where(char.IsNumber).Select(n => n);
var countNumbers = numbers.Count();
var vowelsFromText = text.Where(n => vowels.IndexOf(n) != -1).Select(n => n);
var countVowels = vowelsFromText.Count();
var consonantsFromText = text.Where(n => char.IsLetter(n) && !vowels.Contains(n)).Select(n => n);
var countConsonants = consonantsFromText.Count();
Console.WriteLine($"Количество символов: {countOfSymbols}");
Console.WriteLine($"Количество строк {countLines}");
Console.WriteLine($"Количество цифр {countNumbers}");
Console.WriteLine($"Количество гласных {countVowels}");
Console.WriteLine($"Количество согласных {countConsonants}");