// Дан код программы на С++.  Вывести  все операции и частоту их использования в программе

const string path = @"/home/smol/homework/Pack12/Task05/Program.cs";
var text = File.ReadAllText(path);
var words = text.Split(new char[]{' ', ',', ';', '[', ']', '{', '}', '(', ')', '/', '$', '-', '+', '<', '=', '>'}, StringSplitOptions.RemoveEmptyEntries );
var operations = words.Where(item => char.IsUpper(item[0]) && char.IsAscii(item[0]));
var uniqueOperations = operations.Distinct();
foreach (var item in uniqueOperations)
{
    var counter = operations.Count(x => x == item);
    Console.WriteLine($"Operation '{item}' found {counter} times");
}