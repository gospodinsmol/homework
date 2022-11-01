// Задана некоторая плоскость NxM. Каждой клетке поля соответствует некоторое число.
// Фишка, начиная движение из угла поля с координатами (0, 0), может перемещаться влево, вправо, вверх и вниз.
// Напишите программу, которая определит, какую максимальную сумму может набрать фишка за К ходов,
// при условии, что закончить свое движение она должна в любой клетке N-ой строки поля.

Menu();

void Menu()
{
    Console.WriteLine("Задайте размер плоскости NxM");
    Console.WriteLine("Введите количество строк N");
    var sizeOfLinesN = int.Parse(Console.ReadLine());
    Console.WriteLine("Ввидет количество столбцов M");
    var sizeOfColumnsM = int.Parse(Console.ReadLine());
    Console.WriteLine($"Введите количество ходов (не менее {sizeOfLinesN - 1}):");
    var stepsK = int.Parse(Console.ReadLine());
    if (sizeOfColumnsM <= 0 || sizeOfLinesN <= 0 || stepsK < sizeOfLinesN - 1)
    {
        Console.WriteLine("Введите корректные значение \n");
        Menu();
    }
    var areaOfNumbers = GetNewRandomArea(sizeOfLinesN, sizeOfColumnsM);
    PrintArea(areaOfNumbers);
    var maxSum = GetMaxSum(areaOfNumbers, stepsK);
    Console.WriteLine($"Максимальная сумма: {maxSum}");
}


int GetMaxSum(int[,] area, int countOfSteps)
{
    var position = new int[] { 0, 0 };
    var maxSum = area[position[0], position[1]];
    while (countOfSteps > 0)
    {
        position = GetNextPosition(position, area, countOfSteps);
        maxSum += area[position[0], position[1]];
        countOfSteps--;
    }
    return maxSum;
}

int[] GetNextPosition(int[] positionNow, int[,] area, int countOfSteps)
{
    var countRows = area.GetUpperBound(0) + 1;
    var countColumn = area.Length / countRows;
    var freeSteps = countOfSteps - (countRows - positionNow[0] - 1);
    if (freeSteps > 0)
    {
        var distanceToTheBorder = countColumn - 1 - positionNow[1] > positionNow[1] //расстояние до границы
            ? countColumn - 1 - positionNow[1]
            : positionNow[1];
        var maxCountOfStep = freeSteps <= distanceToTheBorder //мах количество шагов в одной плоскости
            ? freeSteps
            : distanceToTheBorder;
        var positionWithMaxPerspective = new int[] { positionNow[0] + maxCountOfStep, positionNow[1] };
        positionWithMaxPerspective = GetTempTryPosition(positionWithMaxPerspective, countRows, countColumn);
        var sum = SumItems(area, positionNow, positionWithMaxPerspective);
        int[] resultPosition;
        resultPosition = GetTempTryPosition(new int[] { positionNow[0] + 1, positionNow[1] }, countRows, countColumn);

        var sumTemp = 0;
        var tempPosition = GetTempTryPosition(new int[] { positionNow[0] - maxCountOfStep, positionNow[1]}, countRows, countColumn);
        sumTemp = SumItems(area, positionNow, tempPosition);
        if (sumTemp > sum)
        {
            sum = sumTemp;
            resultPosition = new int[] { positionNow[0] - 1, positionNow[1] };
        }
        
        tempPosition = GetTempTryPosition(new int[] { positionNow[0], positionNow[1]  + maxCountOfStep}, countRows, countColumn);
        sumTemp = SumItems(area, positionNow, tempPosition);
        if (sumTemp > sum)
        {
            sum = sumTemp;
            resultPosition = new int[] { positionNow[0], positionNow[1] + 1};
        }

        tempPosition = GetTempTryPosition(new int[] { positionNow[0], positionNow[1]  - maxCountOfStep}, countRows, countColumn);
        sumTemp = SumItems(area, positionNow, tempPosition);
        if (sumTemp > sum)
        {
            sum = sumTemp;
            resultPosition = new int[] { positionNow[0], positionNow[1] - 1 };
        }

        return resultPosition;
    }
    else
    {
        return new int[] { positionNow[0] + 1, positionNow[1] };
    }
}

int[] GetTempTryPosition(int[] position, int maxRow, int maxColumn)
{
    if (position[0] < 0)
    {
        position[0] = 0;
    }

    if (position[0] > maxRow - 1)
    {
        position[0] = maxRow - 1;
    }

    if (position[1] < 0)
    {
        position[1] = 0;
    }

    if (position[1] > maxColumn - 1)
    {
        position[1] = maxColumn - 1;
    }

    return position;
}
int SumItems(int[,] area, int[] startPosition, int[] endPosition)
{
    var sumItems = 0;
    var countRows = area.GetUpperBound(0) + 1;
    var countColumn = area.Length / countRows;
    if (endPosition[0] >= countRows)
    {
        endPosition[0] = countRows - 1;
    }
    else if (endPosition[0] < 0)
    {
        endPosition[0] = 0;
    }

    if (endPosition[1] >= countColumn)
    {
        endPosition[1] = countColumn - 1;
    }
    else if (endPosition[1] < 0)
    {
        endPosition[1] = 0;
    }
    
    for (var itemLine = startPosition[0]; itemLine <= endPosition[0]; itemLine++)
    {
        for (var itemColumn = startPosition[1]; itemColumn <= endPosition[1]; itemColumn++)
        {
            sumItems += area[itemLine, itemColumn];
        }
    }
    return sumItems;
}

int[,] GetNewRandomArea(int sizeOfLines, int sizeOfColumns)
{
    int[,] tempArea = new int[sizeOfLines, sizeOfColumns];
    var rnd = new Random();
    for(var itemOfLine = 0; itemOfLine < sizeOfLines; itemOfLine++)
    {
        for (var itemOfColumn = 0; itemOfColumn < sizeOfColumns; itemOfColumn++)
        {
            tempArea[itemOfLine, itemOfColumn] = rnd.Next(0, 6);
        }
    }

    return tempArea;
}

void PrintArea(int[,] area)
{
    var countRows = area.GetUpperBound(0) + 1;
    var countColumn = area.Length / countRows;
    for (var itemRow = 0; itemRow < countRows; itemRow++)
    {
        for (var itemColumn = 0; itemColumn < countColumn; itemColumn++)
        {
            Console.Write($"{area[itemRow, itemColumn]} ");
        }
        Console.WriteLine();
    }
}
