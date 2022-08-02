// Найти количество минимальных и максимальных элементов массива.
// Найти количество минимальных и максимальных элементов на главных диагоналях.
// Сложить найденные минимумы и максимумы. Отобразить исходный массив, минимальный элемент массива,
// максимальный элемент массива, минимумы, максимумы диагоналей, их позиции и суммы.

const int maxValue = 100;
const int minValue = -100;

var rnd = new Random();
var sizeN = rnd.Next(4, 10);
var sizeM = rnd.Next(4, 10);
var itemMax = minValue;
var itemMin = maxValue;
var itemMaxDiag = minValue;
var itemMinDiag = maxValue;

int[,] arr = new int[sizeN, sizeM];

var counterMin = 0;
var counterMax = 0;
var counterMinDiag = 0;
var counterMaxDiag = 0;

Console.WriteLine("Изначальный массив имеет вид:");
for (var indexN = 0; indexN < sizeN; indexN++)
{
    for (var indexM = 0; indexM < sizeM; indexM++)
    {
        arr[indexN, indexM] = rnd.Next(minValue, maxValue);
        Console.Write($"{arr[indexN, indexM]} \t");
        
        //подсчет максимальных значений в массиве
        if (arr[indexN, indexM] > itemMax)
        {
            itemMax = arr[indexN, indexM];
            counterMax = 1;
        }
        else if (arr[indexN, indexM] == itemMax) 
            counterMax++;

        //подсчет минимальных значений в массиве
        if (arr[indexN, indexM] < itemMin)
        {
            itemMin = arr[indexN, indexM];
            counterMin = 1;
        }
        else if (arr[indexN, indexM] == itemMin)
            counterMin++;
        
        //подсчет максимальных и минимальный значений на гл.диагоналях
        if (indexM == indexN || indexN == sizeM - indexM - 1)
        {
            if (arr[indexN, indexM] > itemMaxDiag)
            {
                itemMaxDiag = arr[indexM, indexM];
                counterMaxDiag = 1;
            }
            else if (arr[indexN, indexM] == itemMaxDiag) 
                counterMaxDiag++;

            if (arr[indexN, indexM] < itemMinDiag)
            {
                itemMinDiag = arr[indexN, indexM];
                counterMinDiag = 1;
            }
            else if (arr[indexN, indexM] == itemMinDiag)
                counterMinDiag++;
        } 
    }
    Console.WriteLine();
}

Console.WriteLine($"Максимальное значение в массиве {itemMax}, встречается {counterMax} раз");
Console.WriteLine($"Минимальное значение в массиве {itemMin}, встречается {counterMin} раз");
Console.WriteLine($"Сумма максимального и минимального значения в массиве: {itemMin + itemMax}");
Console.WriteLine($"Максимальное значение на диагоналях {itemMaxDiag}, встречается {counterMaxDiag} раз");
Console.WriteLine($"Минимальное значение на диагоналях {itemMinDiag}, встречается {counterMinDiag} раз");
Console.WriteLine($"Сумма максимального и минимального значения на диагоналях: {itemMinDiag + itemMaxDiag}");