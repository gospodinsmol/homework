// Написать свою очередь

var myQueue = new MyQueue<string>();
for (var i = 0; i < 12; i++)
{
    myQueue.Equeue($"{i*12}");
    Console.Write($"{i*12} ");
}
Console.WriteLine();
Console.WriteLine(myQueue.Dequeue());
Console.WriteLine(myQueue.Dequeue());
Console.WriteLine(myQueue.Peek());
class MyQueue<T>
{
    private T[] items;
    private int head;
    private int tail;
    private int count;
    private int defaultLenth = 10;

    public MyQueue()
    {
        items = new T[defaultLenth];
        head = 0;
        count = 0;
    }

    public T Dequeue()
    {
        if (count > 0)
        {
            head++;
            count--;
            return items[head - 1];
        }
        else
        {
            throw new InvalidOperationException("Queue is empty");
        }
    }

    public void Equeue(T item)
    {
        if (head + count > defaultLenth - 1)
        {
            ReSize();
        }
        
        if (count == 0)
        {
            items[head] = item;
            count++;
        }
        else
        {
            tail = head + count;
            items[tail] = item;
            count++;
        }
    }

    public T Peek()
    {
        if (count > 0)
        {
            return items[head];
        }
        else
        {
            throw new InvalidOperationException("Queue is empty");
        }
    }
    
    private void ReSize()
    {
        defaultLenth += 10;
        var tempItems = new T[defaultLenth];
        for (var i = 0; i < items.Length; i++)
        {
            tempItems[i] = items[i];
        }
        items = tempItems;
    }
}
