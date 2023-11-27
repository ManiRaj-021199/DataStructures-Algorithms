namespace DSA.DataStructures;

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
        ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowNullException(this.Head);
        ThrowExceptionsHelper<T>.ThrowNullException(data);

        SinglyLinkedListNode<T>? nodeTemp = this.Head!;
        SinglyLinkedListNode<T>? nodePrevious = null;

        while(nodeTemp != null)
        {
            if(nodeTemp.Data!.Equals(data))
            {
                if(nodePrevious is null)
                {
                    this.Head = nodeTemp.Next;
                }
                else
                {
                    nodePrevious.Next = nodeTemp.Next;
                }

                return true;
            }

            nodePrevious = nodeTemp;
            nodeTemp = nodeTemp.Next;
        }

        throw ThrowExceptionsHelper<T>.ThrowValueNotAvailableException();
    }

    public bool RemoveAt(int nIndex)
    {
        int nCount = 0;
        SinglyLinkedListNode<T>? nodeTemp = this.Head;
        SinglyLinkedListNode<T>? nodePrevious = null;

        while(nodeTemp != null)
        {
            if(nCount == nIndex)
            {
                if(nodePrevious is null)
                {
                    this.Head = nodeTemp.Next;
                }
                else
                {
                    nodePrevious.Next = nodeTemp.Next;
                }

                return true;
            }

            nodePrevious = nodeTemp;
            nodeTemp = nodeTemp.Next;
            nCount++;
        }

        throw ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowArgumentOutOfRangeException();
    }

    public bool RemoveAll(T data)
    {
        ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowNullException(this.Head);
        ThrowExceptionsHelper<T>.ThrowNullException(data);

        SinglyLinkedListNode<T>? nodeTemp = this.Head!;
        SinglyLinkedListNode<T>? nodePrevious = null;

        bool bIsValueDeleted = false;

        while(nodeTemp != null)
        {
            if(nodeTemp.Data!.Equals(data))
            {
                if(nodePrevious is null)
                {
                    this.Head = nodeTemp.Next;
                }
                else
                {
                    nodePrevious.Next = nodeTemp.Next;
                }

                bIsValueDeleted = true;
            }

            nodePrevious = nodeTemp;
            nodeTemp = nodeTemp.Next;
        }

        if(bIsValueDeleted) return true;

        throw ThrowExceptionsHelper<T>.ThrowValueNotAvailableException();
    }

    public string ToString(char cSeparator)
    {
        ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowNullException(this.Head);

        SinglyLinkedListNode<T>? nodeTemp = this.Head;
        string strValue = string.Empty;

        while(nodeTemp != null)
        {
            strValue += $"{nodeTemp.Data}{cSeparator}";

            nodeTemp = nodeTemp.Next;
        }

        return strValue[..^1];
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