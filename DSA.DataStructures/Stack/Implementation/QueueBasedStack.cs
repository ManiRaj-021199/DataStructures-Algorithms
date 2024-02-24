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
        throw new NotImplementedException();
    }

    public bool IsEmpty()
    {
        throw new NotImplementedException();
    }

    public T Pop()
    {
        throw new NotImplementedException();
    }

    public T Top()
    {
        throw new NotImplementedException();
    }
    #endregion
}