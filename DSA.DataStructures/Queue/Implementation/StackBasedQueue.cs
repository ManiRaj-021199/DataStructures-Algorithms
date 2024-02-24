namespace DSA.DataStructures;

public class StackBasedQueue<T> : IQueueBase<T>
{
    #region Properties
    private ArrayBasedStack<T> Stack1 { get; set; } = null!;
    private ArrayBasedStack<T> Stack2 { get; set; } = null!;
    #endregion

    #region Publics
    public void Enqueue(T data)
    {
        throw new NotImplementedException();
    }

    public T Dequeue()
    {
        throw new NotImplementedException();
    }

    public T First()
    {
        throw new NotImplementedException();
    }

    public T Last()
    {
        throw new NotImplementedException();
    }

    public int Length()
    {
        throw new NotImplementedException();
    }
    #endregion
}