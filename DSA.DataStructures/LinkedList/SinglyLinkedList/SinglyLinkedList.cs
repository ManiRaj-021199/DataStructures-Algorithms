﻿namespace DSA.DataStructures;

public class SinglyLinkedList<T> : ISinglyLinkedList<T>
{
    #region Properties
    private SinglyLinkedListNode<T>? Head { get; set; }
    #endregion

    #region Publics
    public T? GetFirst()
    {
        ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowNullException(this.Head);

        return this.Head!.Data;
    }

    public T? GetByIndex(int nIndex)
    {
        ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowNullException(this.Head);

        return nIndex switch
        {
            < 0 => throw ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowArgumentOutOfRangeException(),
            0 => GetFirst(),
            > 0 => GetValueByIndex(nIndex)
        };
    }

    public T? GetLast()
    {
        ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowNullException(this.Head);

        SinglyLinkedListNode<T> nodeTemp = this.Head!;

        while(nodeTemp.Next is not null)
        {
            nodeTemp = nodeTemp.Next;
        }

        return nodeTemp.Data;
    }

    public SinglyLinkedListNode<T> AddFirst(T data)
    {
        SinglyLinkedListNode<T> node = new(data, this.Head);
        this.Head = node;

        return node;
    }

    public SinglyLinkedListNode<T> AddLast(T data)
    {
        if(this.Head is null)
        {
            return AddFirst(data);
        }

        SinglyLinkedListNode<T> node = new(data);
        SinglyLinkedListNode<T> nodeTemp = this.Head;

        while(nodeTemp.Next is not null)
        {
            nodeTemp = nodeTemp.Next;
        }

        nodeTemp.Next = node;

        return node;
    }

    public SinglyLinkedListNode<T> InsertAt(int nIndex, T data)
    {
        throw new NotImplementedException();
    }

    public SinglyLinkedListNode<T> InsertAfter(T previous, T data)
    {
        throw new NotImplementedException();
    }

    public bool Remove(T data)
    {
        throw new NotImplementedException();
    }

    public bool RemoveAt(int nIndex)
    {
        throw new NotImplementedException();
    }

    public bool RemoveAll(T data)
    {
        throw new NotImplementedException();
    }

    public int Count()
    {
        ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowNullException(this.Head);

        SinglyLinkedListNode<T>? nodeTemp = this.Head;
        int nCount = 0;

        while(nodeTemp != null)
        {
            nodeTemp = nodeTemp.Next;

            nCount++;
        }

        return nCount;
    }
    #endregion

    #region Privates
    private T? GetValueByIndex(int nIndex)
    {
        int nCount = 0;
        SinglyLinkedListNode<T>? nodeTemp = this.Head;

        while(nodeTemp != null)
        {
            if(nCount == nIndex)
            {
                return nodeTemp.Data;
            }

            nodeTemp = nodeTemp.Next;
            nCount++;
        }

        throw ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowArgumentOutOfRangeException();
    }
    #endregion
}