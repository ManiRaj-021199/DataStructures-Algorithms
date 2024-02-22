namespace DSA.DataStructures;

public class DoublyLinkedList<T> : IDoublyLinkedList<T>
{
    #region Properties
    public int Count { get; private set; }

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

    public DoublyLinkedListNode<T>? GetNodeByIndex(int nIndex)
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

        return nodeTemp;
    }

    public IEnumerable<T?> GetData()
    {
        DoublyLinkedListNode<T>? nodeTemp = this.Head;

        while(nodeTemp != null)
        {
            yield return nodeTemp.Data;

            nodeTemp = nodeTemp.Next;
        }
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
        DoublyLinkedListNode<T> node = new(data);

        if(this.Head is null)
        {
            this.Head = node;
            this.Tail = node;
            this.Count = 1;
        }
        else
        {
            node.Previous = this.Tail;
            this.Tail!.Next = node;

            this.Tail = node;

            this.Count++;
        }

        return node;
    }

    public DoublyLinkedListNode<T> InsertAt(int nIndex, T data)
    {
        ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowNullException(this.Head);

        if(nIndex < 0 || nIndex > this.Count)
        {
            ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowArgumentOutOfRangeException();
        }

        DoublyLinkedListNode<T>? nodeTemp = this.Head!;

        for(int i = 0; i < nIndex - 1; i++)
        {
            nodeTemp = nodeTemp?.Next;
        }

        if(nodeTemp == null) return AddLast(data);

        DoublyLinkedListNode<T> node = new(data, nodeTemp, nodeTemp.Next);
        nodeTemp.Next = node;

        if(node.Next != null)
        {
            node.Next.Previous = node;
        }

        this.Count++;

        return node;
    }

    public DoublyLinkedListNode<T> InsertAfter(DoublyLinkedListNode<T> previous, T data)
    {
        if(this.Tail == previous) return AddLast(data);

        DoublyLinkedListNode<T> node = new(data, previous, previous.Next);
        previous.Next = node;

        if(node.Next is not null)
        {
            node.Next.Previous = node;
        }

        this.Count++;

        return node;
    }

    public DoublyLinkedListNode<T>? Find(T data)
    {
        DoublyLinkedListNode<T>? nodeTemp = this.Head;

        while(nodeTemp != null)
        {
            T? value = nodeTemp.Data;

            if((value is null && data is null) || (value is not null && value.Equals(data)))
            {
                return nodeTemp;
            }

            nodeTemp = nodeTemp.Next;
        }
        
        return null;
    }

    public void RemoveHead()
    {
        if(this.Head is null)
        {
            throw ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowValueNotAvailableException();
        }

        this.Head = this.Head.Next;

        if(this.Head is not null)
        {
            this.Head.Previous = null;
            this.Count--;

            return;
        }

        this.Tail = null;
        this.Count = 0;
    }

    public void RemoveTail()
    {
        if(this.Tail is null)
        {
            throw ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowValueNotAvailableException();
        }

        this.Tail = this.Tail.Previous;

        if(this.Tail is not null)
        {
            this.Tail.Next = null;
            this.Count--;

            return;
        }

        this.Head = null;
        this.Count = 0;
    }

    public void Remove(T data)
    {
        DoublyLinkedListNode<T>? node = Find(data);

        if(node is not null)
        {
            RemoveNode(node);
        }

        ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowNullException(node);
    }

    public void RemoveNode(DoublyLinkedListNode<T> node)
    {
        if(node == this.Head)
        {
            RemoveHead();
        }
        else if(node == this.Tail)
        {
            RemoveTail();
        }
        else if(node.Previous is null || node.Next is null)
        {
            ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowNullException(node.Previous);
            ThrowExceptionsHelper<DoublyLinkedListNode<T>>.ThrowNullException(node.Next);
        }
        else
        {
            node.Previous!.Next = node.Next;
            node.Next!.Previous = node.Previous;

            this.Count--;
        }
    }

    public void RemoveAt(int nIndex)
    {
        DoublyLinkedListNode<T>? node = GetNodeByIndex(nIndex);

        if(node is not null)
        {
            RemoveNode(node);
        }
    }

    public void RemoveAll(T data)
    {
        DoublyLinkedListNode<T>? node = this.Head;

        while(node is not null)
        {
            if(node.Data is not null && node.Data.Equals(data))
            {
                RemoveNode(node);
            }

            node = node.Next;
        }
    }

    public string ToString(char cSeparator)
    {
        string strResult = string.Empty;

        DoublyLinkedListNode<T>? nodeTemp = this.Head;

        while(nodeTemp is not null)
        {
            strResult += nodeTemp.Data + cSeparator.ToString();

            nodeTemp = nodeTemp.Next;
        }

        return strResult;
    }

    public void Reverse()
    {
        DoublyLinkedListNode<T>? nodeTemp = this.Head;
        DoublyLinkedListNode<T>? nodePrev = null;

        while(nodeTemp is not null)
        {
            nodePrev = nodeTemp.Previous;

            nodeTemp.Previous = nodeTemp.Next;
            nodeTemp.Next = nodePrev;
            nodeTemp = nodeTemp.Previous;
        }

        this.Tail = this.Head;

        if(nodePrev is not null)
        {
            this.Head = nodePrev.Previous;
        }
    }

    public int IndexOf(T data)
    {
        DoublyLinkedListNode<T>? nodeTemp = this.Head;
        var nIndex = 0;

        while(nodeTemp is not null)
        {
            if(nodeTemp.Data is not null && nodeTemp.Data.Equals(data))
            {
                return nIndex;
            }

            nodeTemp = nodeTemp.Next;
            nIndex++;
        }

        return -1;
    }

    public bool Contains(T data)
    {
        return IndexOf(data) != -1;
    }
    #endregion
}