﻿namespace DSA.DataStructures;

public class ArrayBasedQueue<T> : IArrayBasedQueue<T>
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
        throw new NotImplementedException();
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