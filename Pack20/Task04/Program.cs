// Дано два текстовых файла.
// Выяснить, совпадают ли их строки. Если нет, то вывести несовпадающую строку из каждого файла.

const string pathFirst = @"/home/smol/homework/Pack20/Task04/FirstFile.txt";
const string pathSecond = @"/home/smol/homework/Pack20/Task04/SecondFile.txt";

var linesFromFirstFile = File.ReadAllLines(pathFirst);
var linesFromSecondFile = File.ReadAllLines(pathSecond);
var lenghtOfSmaller = linesFromFirstFile.Length < linesFromSecondFile.Length
    ? linesFromFirstFile.Length
    : linesFromSecondFile.Length;
var difOfLines = linesFromFirstFile.Length > linesFromSecondFile.Length
    ? linesFromFirstFile[(linesFromSecondFile.Length - 1)..linesFromFirstFile.Length]
    : linesFromSecondFile[(linesFromFirstFile.Length - 1)..linesFromSecondFile.Length];
for (var item = 0; item < lenghtOfSmaller; item++)
{
    if(linesFromFirstFile[item] != linesFromSecondFile[item])
    {
        Console.WriteLine(linesFromFirstFile[item]);
        Console.WriteLine(linesFromSecondFile[item]);
    }
}
foreach(var item in difOfLines)
{
    Console.WriteLine(item);
}




    