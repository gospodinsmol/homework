// Даны две очереди Q1 и Q2, заполненные произвольными целыми числами.
// Создать третью очередь Q3, в которую занести сумму элементов, Q3[i]=Q1[i]+Q2[i],
// третью очередь мы заполняем до тех пор, пока одна из очередей не опустеет.
// (Реализовать вариант на базе динамического списка.)

var q1 = new QueueArr<int>();
var q2 = new QueueArr<int>();
var q3 = new QueueArr<int>();
for (var i = 0; i < 12; i++)
{
    q1.Eueue(i*3);
    q2.Eueue(i*5);
}
q2.Eueue(24);
q1.PrintQueue();
q2.PrintQueue();
while (q1.Count > 0 && q2.Count > 0)
{
    q3.Eueue(q1.Dueue() + q2.Dueue());
}
q3.PrintQueue();

class QueueArr<T>
{
    private List<T> items;
    
    public QueueArr()
    {
        items = new List<T>();
    }

    public void Eueue(T item)
    {
        items.Add(item);
    }

    public T Dueue()
    {
        var tempItem = items[0];
        items.RemoveAt(0);
        return tempItem;
    }

    public T Peek()
    {
        return items[0];
    }

    public void PrintQueue()
    {
        foreach (var item in items)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
    public int Count => items.Count;
}