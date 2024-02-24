namespace DSA.DataStructures;

public class QueueBasedStack<T> : IStackBase<T>
{
    #region Properties
    private IQueueBase<T> Queue1 { get; set; } = new ArrayBasedQueue<T>();
    private IQueueBase<T> Queue2 { get; set; } = new ArrayBasedQueue<T>();
    #endregion

    #region Publics
    public void Push(T data)
    {
        this.Queue2.Enqueue(data);

        while(this.Queue1.Length() > 0)
        {
            data = this.Queue1.Dequeue();
            this.Queue2.Enqueue(data);
        }

        (this.Queue2, this.Queue1) = (this.Queue1, this.Queue2);
    }

    public bool IsEmpty()
    {
        return this.Queue1.Length() == 0;
    }

    public T Pop()
    {
        if(this.Queue1.Length() == 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        return this.Queue1.Dequeue();
    }

    public T Top()
    {
        if (this.Queue1.Length() == 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        return this.Queue1.First();
    }

    public int Length()
    {
        return this.Queue1.Length();
    }
    #endregion
}