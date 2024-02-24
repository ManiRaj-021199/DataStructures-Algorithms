namespace DSA.DataStructures;

public class ListBasedQueue<T> : IQueueBase<T>
{
    #region Properties
    private List<T> Queue { get; set; } = null!;
    #endregion

    #region Publics
    public void Enqueue(T data)
    {
        this.Queue ??= new List<T>();

        this.Queue.Add(data);
    }

    public T Dequeue()
    {
        if(this.Queue == null)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        T first = this.Queue[0];

        this.Queue.RemoveAt(0);

        return first;
    }

    public T First()
    {
        if (this.Queue == null)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        return this.Queue.First();
    }

    public T Last()
    {
        if (this.Queue == null)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        return this.Queue.Last();
    }

    public int Length()
    {
        return this.Queue.Count;
    }
    #endregion
}