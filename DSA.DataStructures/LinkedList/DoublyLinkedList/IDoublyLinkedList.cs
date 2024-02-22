namespace DSA.DataStructures;

public interface IDoublyLinkedList<T>
{
    /// <summary>
    ///     Length of the linked list
    /// </summary>
    int Count { get; }

    /// <summary>
    ///     Returns a head node content.
    /// </summary>
    /// <returns>Head node content</returns>
    T? GetFirst();

    /// <summary>
    ///     Return a content by index.
    /// </summary>
    /// <param name="nIndex">Index which need to fetch the content</param>
    /// <returns>Content on the required index</returns>
    T? GetByIndex(int nIndex);

    /// <summary>
    ///     Returns a head node content.
    /// </summary>
    /// <returns>End node content</returns>
    T? GetLast();
    
    /// <summary>
    ///     Return a node by index.
    /// </summary>
    /// <param name="nIndex">Index which need to fetch the content</param>
    /// <returns>Content on the required index</returns>
    DoublyLinkedListNode<T>? GetNodeByIndex(int nIndex);

    /// <summary>
    ///     Returns a head node content.
    /// </summary>
    /// <returns>End node content</returns>
    IEnumerable<T?> GetData();

    /// <summary>
    ///     Adding a new node at the beginning of the list.
    /// </summary>
    /// <param name="data">Content of the new node</param>
    /// <returns>Newly added node</returns>
    DoublyLinkedListNode<T> AddFirst(T data);

    /// <summary>
    ///     Adding a new node at the end of the list.
    /// </summary>
    /// <param name="data">Content of the new node</param>
    /// <returns>Newly added node</returns>
    DoublyLinkedListNode<T> AddLast(T data);

    /// <summary>
    ///     Insert a data on the provided index.
    /// </summary>
    /// <param name="nIndex">Index which need to store the data</param>
    /// <param name="data">Data need to be stored</param>
    /// <returns>Newly added node</returns>
    DoublyLinkedListNode<T> InsertAt(int nIndex, T data);

    /// <summary>
    ///     Insert a data after the provided node value.
    /// </summary>
    /// <param name="previous">Previous node data</param>
    /// <param name="data">Data need to be stored</param>
    /// <returns>Newly added node</returns>
    DoublyLinkedListNode<T> InsertAfter(DoublyLinkedListNode<T> previous, T data);

    /// <summary>
    ///    Find the first node equivalent to the data provided.
    /// </summary>
    /// <param name="data">data need to find</param>
    /// <returns>first node equivalent to the data provided</returns>
    DoublyLinkedListNode<T>? Find(T data);

    /// <summary>
    ///     Remove the first node from the list.
    /// </summary>
    void RemoveHead();

    /// <summary>
    ///     Remove the last node from the list.
    /// </summary>
    void RemoveTail();

    /// <summary>
    ///     Remove a first node equivalent to the data provided.
    /// </summary>
    /// <param name="data">Data need to removed</param>
    /// <returns>Status of the operation, If the data was removed it is true else false</returns>
    void Remove(T data);

    /// <summary>
    ///     Remove the given node from the list.
    /// </summary>
    /// <param name="node">Node need to remove from the list.</param>
    void RemoveNode(DoublyLinkedListNode<T> node);

    /// <summary>
    ///     Remove the node which is on the given index.
    /// </summary>
    /// <param name="nIndex">Index need to removed from the list</param>
    /// <returns>Status of the operation, If the data was removed it is true else false</returns>
    void RemoveAt(int nIndex);

    /// <summary>
    ///     Remove all the node equivalent to the data provided.
    /// </summary>
    /// <param name="data">Data need to removed</param>
    /// <returns>Status of the operation, If the data was removed it is true else false</returns>
    void RemoveAll(T data);

    /// <summary>
    ///     Returns all node data as a string format.
    /// </summary>
    /// <param name="cSeparator">Separator symbol for separate the node contents</param>
    /// <returns>Returns all node data as a string format and separate the node value by using cSeparator</returns>
    string ToString(char cSeparator);

    /// <summary>
    ///     Reverse the list.
    /// </summary>
    void Reverse();

    /// <summary>
    ///     Index of the data in the list.
    /// </summary>
    /// <param name="data">Data to look for.</param>
    /// <returns>Returns the index of the node if it is found else -1.</returns>
    int IndexOf(T data);

    /// <summary>
    ///     Check whether the list contains the data or not.
    /// </summary>
    /// <param name="data">Data to look for.</param>
    /// <returns>Return true if data is in the list else false.</returns>
    bool Contains(T data);
}