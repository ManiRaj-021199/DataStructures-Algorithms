namespace DSA.DataStructures;

public class ArrayBasedQueue<T> : IQueueBase<T>
{
    #region Constants
    private const int BOUND = 5;
    #endregion

    #region Fields
    private int nFrontIndex = 0;
    private int nRearIndex = -1;
    private int nLength = 0;
    #endregion

    #region Properties
    private T[] Queue { get; set; } = null!;
    #endregion

    #region Publics
    public void Enqueue(T data)
    {
        if(nRearIndex == nLength - 1)
        {
            this.Queue = ExtendQueue();
        }

        nRearIndex++;

        this.Queue[nRearIndex] = data;
    }

    public T Dequeue()
    {
        if (nLength == 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        T first = First();

        for(int i = 0; i < nRearIndex; i++)
        {
            this.Queue[i] = this.Queue[i + 1];
        }

        this.Queue[nRearIndex] = default!;
        nRearIndex--;

        return first;
    }

    public T First()
    {
        if(nLength == 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        return this.Queue[nFrontIndex];
    }

    public T Last()
    {
        if (nLength == 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        return this.Queue[nRearIndex];
    }

    public int Length()
    {
        return nRearIndex + 1;
    }
    #endregion

    #region Privates
    private T[] ExtendQueue()
    {
        T[] queueNew = new T[nLength + BOUND];

        // Copy the old stack data to new stack
        for (int i = 0; i < nLength; i++)
        {
            queueNew[i] = this.Queue[i];
        }

        nLength += BOUND;

        return queueNew;
    }
    #endregion
}