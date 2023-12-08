﻿namespace DSA.DataStructures;

public class DoublyLinkedList<T> : IDoublyLinkedList<T>
{
    #region Properties
    public int Count { get; set; }

    private DoublyLinkedListNode<T>? Head { get; set; }
    private DoublyLinkedListNode<T>? Tail { get; set; }
    #endregion

    #region Publics
    public T? GetFirst()
    {
        ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowNullException(this.Head);

        return this.Head!.Data;
    }

    public T? GetByIndex(int nIndex)
    {
        ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowNullException(this.Head);

        if(nIndex < 0 || nIndex >= this.Count)
        {
            ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowArgumentOutOfRangeException();
        }

        DoublyLinkedListNode<T>? nodeTemp = this.Head!;

        for(int i = 0; i < nIndex; i++)
        {
            nodeTemp = nodeTemp?.Next;
        }

        return nodeTemp!.Data;
    }

    public T? GetLast()
    {
        ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowNullException(this.Tail);

        return this.Tail!.Data;
    }

    public DoublyLinkedListNode<T> AddFirst(T data)
    {
        DoublyLinkedListNode<T> node = new(data);

        if(this.Head is null)
        {
            this.Head = node;
            this.Tail = node;
            this.Count = 1;
        }
        else
        {
            this.Head.Previous = node;
            node.Next = this.Head;

            this.Head = node;

            this.Count++;
        }

        return node;
    }

    public DoublyLinkedListNode<T> AddLast(T data)
    {
        throw new NotImplementedException();
    }

    public DoublyLinkedListNode<T> InsertAt(int nIndex, T data)
    {
        throw new NotImplementedException();
    }

    public DoublyLinkedListNode<T> InsertAfter(T previous, T data)
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

    public string ToString(char cSeparator)
    {
        throw new NotImplementedException();
    }

    public void Reverse()
    {
        throw new NotImplementedException();
    }
    #endregion
}