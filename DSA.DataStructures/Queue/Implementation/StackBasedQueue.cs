namespace DSA.DataStructures;

public class StackBasedQueue<T> : IQueueBase<T>
{
    #region Properties
    private IStackBase<T> Stack1 { get; set; } = new ArrayBasedStack<T>();
    private IStackBase<T> Stack2 { get; set; } = new ArrayBasedStack<T>();
    #endregion

    #region Publics
    public void Enqueue(T data)
    {
        this.Stack1.Push(data);
    }

    public T Dequeue()
    {
        if(this.Stack1.Length() == 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        // Reverse Stack
        int nLengthStack1 = this.Stack1.Length();

        for(int i = 0; i < nLengthStack1 - 1; i++)
        {
            this.Stack2.Push(this.Stack1.Pop());
        }

        T dataNeedToPop = this.Stack1.Pop();
        int nLengthStack2 = this.Stack2.Length();

        for (int i = 0; i < nLengthStack2; i++)
        {
            this.Stack1.Push(this.Stack2.Pop());
        }

        return dataNeedToPop;
    }

    public T First()
    {
        if (this.Stack1.Length() == 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        T data = default!;

        while(this.Stack1.Length() > 0)
        {
            data = this.Stack1.Pop();

            this.Stack2.Push(data);
        }

        while (this.Stack2.Length() > 0)
        {
            this.Stack1.Push(this.Stack2.Pop());
        }

        return data;
    }

    public T Last()
    {
        if (this.Stack1.Length() == 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        return this.Stack1.Top();
    }

    public int Length()
    {
        return this.Stack1.Length();
    }
    #endregion
}