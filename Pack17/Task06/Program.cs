// Дана шахматная доска. Найти минимальное количество ходов
// за которое конь переместится из одной клетки в другую.
// Использовать структуру данных очередь.

const int maxCoord = 8;
const int minCoord = 1;

Console.WriteLine("Шахматная доска - площадка из клеток 8х8");
Console.WriteLine("Введите начальные координаты фигуры Конь");
Console.Write("Координата X (от 1 до 8)");
var startPointX = int.Parse(Console.ReadLine());
Console.Write("Координата Y (от 1 до 8)");
var startPointY = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечные координаты фигуры Конь");
Console.Write("Координата X (от 1 до 8)");
var endPointX = int.Parse(Console.ReadLine());
Console.Write("Координата Y (от 1 до 8)");
var endPointY = int.Parse(Console.ReadLine());

var coordStart = new int[]{startPointX, startPointY};
var coordEnd = new int[]{endPointX, endPointY};
var counter = 0;

var queue = new Queue<int[]>();
queue.Enqueue(coordStart);
Console.WriteLine($"{SearchCountsOfMoves(queue)} ходов");
int SearchCountsOfMoves(Queue<int[]> inputQueue)
{
    var tempQueue = new Queue<int[]>();
    counter += 1;
    while(inputQueue.Count != 0)
    {
        if (IsOneMove(inputQueue.Peek()))
        {
            return counter;
        }
        tempQueue.Enqueue(inputQueue.Dequeue());
    }
    
    return SearchCountsOfMoves(CreateNewQueue(tempQueue));
}

Queue<int[]> CreateNewQueue(Queue<int[]> inputQueue)
{
    var outQueue = new Queue<int[]>();
    while (inputQueue.Count != 0)
    {
        var tempItem = inputQueue.Dequeue();
        var tempOut = new int[]{tempItem[0] + 1, tempItem[1] + 2};
        if (IsInRange(tempOut))
        {
            outQueue.Enqueue(tempOut);
        }
        tempOut = new int[]{tempItem[0] + 2, tempItem[1] + 1};
        if (IsInRange(tempOut))
        {
            outQueue.Enqueue(tempOut);
        }
        tempOut = new int[]{tempItem[0] - 2, tempItem[1] - 1};
        if (IsInRange(tempOut))
        {
            outQueue.Enqueue(tempOut);
        }
        tempOut = new int[]{tempItem[0] - 2, tempItem[1] + 1};
        if (IsInRange(tempOut))
        {
            outQueue.Enqueue(tempOut);
        }
        tempOut = new int[]{tempItem[0] + 2, tempItem[1] - 1};
        if (IsInRange(tempOut))
        {
            outQueue.Enqueue(tempOut);
        }
        tempOut = new int[]{tempItem[0] + 1, tempItem[1] - 2};
        if (IsInRange(tempOut))
        {
            outQueue.Enqueue(tempOut);
        }
        tempOut = new int[]{tempItem[0] - 1, tempItem[1] - 2};
        if (IsInRange(tempOut))
        {
            outQueue.Enqueue(tempOut);
        }
        tempOut = new int[]{tempItem[0] - 1, tempItem[1] + 2};
        if (IsInRange(tempOut))
        {
            outQueue.Enqueue(tempOut);
        }
    }

    return outQueue;
}

bool IsInRange(int[] input)
{
    return input[0] >= minCoord && input[0] <= maxCoord && input[1] >= minCoord && input[1] <= maxCoord;
}

bool IsOneMove(int[] input)
{
    return Math.Pow(Math.Abs(coordEnd[0] - input[0]), 2) + Math.Pow(Math.Abs(coordEnd[1] - input[1]), 2) == 5;
}

