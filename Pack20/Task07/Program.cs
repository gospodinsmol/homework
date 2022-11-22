// Написать функцию с помощью которой подготовить входной  бинарный  файл
// записав в него 20 чисел в диапазоне от -20 до 20.
// Сформировать выходной текстовый  файл, преобразовав числа следующим образом:
// Добавить к каждому числу последнее число файла;
// Умножить каждое число на произведение первого и последнего отрицательного числа;
// Заменить все нули средним арифметическим.

using System.Globalization;

const string pathInput = @"/home/smol/homework/Pack20/Task07/Input.txt";
const string pathOutput= @"/home/smol/homework/Pack20/Task07/Output.txt";

CreateInputFile(pathInput);
CreateOutputFile(pathInput, pathOutput);

void CreateInputFile(string path)
{
    var arrayOfNumber = new string[20];
    var rnd = new Random();
    for (var item = 0; item < arrayOfNumber.Length; item++)
    {
        arrayOfNumber[item] = rnd.Next(-20, 20).ToString();
    }
    File.WriteAllLines(path, arrayOfNumber);
}

void CreateOutputFile(string pathIn, string pathOut)
{
    var arrayLinesFromInput = File.ReadAllLines(pathIn);
    var arrayNumbersFromInput = arrayLinesFromInput.Select(double.Parse).ToArray();
    var lastItemFromArr = arrayNumbersFromInput[^1];
    var multiplicationNegativeNumbers = arrayNumbersFromInput.First(a => a < 0) * arrayNumbersFromInput.Last(a => a < 0);
    var averageNum = arrayNumbersFromInput.Average();
    var arrayTemp = arrayNumbersFromInput
        .Select(a =>
        {
            if (a != 0) 
            {
                return (a + lastItemFromArr) * multiplicationNegativeNumbers;
            }
            else
            {
                return averageNum;
            }
        });
        //.Where(a => a == 0.0).Select(a => averageNum);
    var arrayOut = arrayTemp.Select(a => a.ToString());
    File.WriteAllLines(pathOut, arrayOut);
}