// Дан текстовый файл. Отсортировать все слова в файле по длине слова и вывести в файл  Output.txt

const string path = @"/home/smol/homework/Pack20/Task02/Text.txt";
var text = File.ReadAllText(path);
var words = text.Split(new char[] { ' ', ',', ':',  '\n' }, StringSplitOptions.RemoveEmptyEntries);
var arr = from item in words orderby item.Length select item;
File.WriteAllLines(@"/home/smol/homework/Pack20/Task02/result.txt", arr);