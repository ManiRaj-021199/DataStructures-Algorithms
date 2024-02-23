namespace DSA.DataStructures;

public class ArrayBasedQueue<T> : IArrayBasedQueue<T>
{
    #region Constants
    private const int BOUND = 5;
    #endregion

    #region Fields
    private int nFrontIndex = 0;
    private int nRearIndex = 0;
    private int nLength = 0;
    #endregion

    #region Properties
    private T[] Queue { get; set; } = null!;
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

    public T Front()
    {
        throw new NotImplementedException();
    }
    #endregion
}