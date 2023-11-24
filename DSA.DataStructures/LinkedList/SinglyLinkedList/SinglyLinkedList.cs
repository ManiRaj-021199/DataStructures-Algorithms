namespace DSA.DataStructures;

public class SinglyLinkedList<T>
{
    #region Properties
    /// <summary>
    /// Head of the list.
    /// </summary>
    private SinglyLinkedListNode<T>? Head { get; set; }
    #endregion

    #region Publics
    /// <summary>
    ///     Returns a head node content.
    ///     Time complexity      - O(1)
    ///     Space complexity     - O(1)
    /// </summary>
    /// <returns>Head node content</returns>
    public T? GetFirst()
    {
        ThrowExceptionsHelper<SinglyLinkedListNode<T>>.ThrowNullException(this.Head);

        return this.Head!.Data;
    }

    public T GetElementByIndex(int nIndex)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///     Returns a head node content.
    ///     Time complexity      - O(n)
    ///     Space complexity     - O(1)
    /// </summary>
    /// <returns>End node content</returns>
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

    /// <summary>
    ///     Adding a new node at the beginning of the list.
    ///     Time complexity      - O(1)
    ///     Space complexity     - O(1)
    /// </summary>
    /// <param name="data">Content of the new node</param>
    /// <returns>Newly added node</returns>
    public SinglyLinkedListNode<T> AddFirst(T data)
    {
        SinglyLinkedListNode<T> node = new(data, this.Head);
        this.Head = node;

        return node;
    }

    /// <summary>
    ///     Adding a new node at the end of the list.
    ///     Time complexity      - O(n)
    ///     Space complexity     - O(1)
    /// </summary>
    /// <param name="data">Content of the new node</param>
    /// <returns>Newly added node</returns>
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

    public bool InsertAt(int nIndex, T data)
    {
        throw new NotImplementedException();
    }

    public bool InsertAfter(T previous, T data)
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

        return 0;
    }
    #endregion
}