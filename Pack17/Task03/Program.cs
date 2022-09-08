// Написать свой стек

var myStack = new MyStack<string>();
for (var i = 0; i < 12; i++)
{
    myStack.Push($"{i*11}");
}

var len = myStack.Count;
for (var i = 0; i < len; i++)
{
    Console.WriteLine(myStack.Pop());
}

class MyStack<T>
{
    private int count;
    private T[] items;
    private int defaultLenth = 10;

    public MyStack()
    {
        items = new T[defaultLenth];
    }

    public bool IsEmpty
    {
        get { return count == 0; }
    }

    public int Count
    {
        get { return count; }
    }

    public void Push(T item)
    {
        if (count == items.Length)
        {
            ReSize();
        }
        items[count++] = item;
    }

    public T Pop()
    {
        if (!IsEmpty)
        {
            var item = items[--count];
            items[count] = default(T);
            return item;
        }
        else
        {
            throw new InvalidOperationException("Stack is clear");
        }
    }

    public T Peek()
    {
        if (!IsEmpty)
        {
            return items[count-1];
        }
        else
        {
            throw new InvalidOperationException("Stack is clear");
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