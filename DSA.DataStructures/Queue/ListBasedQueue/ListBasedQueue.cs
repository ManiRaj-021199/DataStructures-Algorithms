namespace DSA.DataStructures;

public class ListBasedQueue<T> : IListBasedQueue<T>
{
    #region Properties
    private List<T> Queue { get; set; } = null!;
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
    #endregion
}