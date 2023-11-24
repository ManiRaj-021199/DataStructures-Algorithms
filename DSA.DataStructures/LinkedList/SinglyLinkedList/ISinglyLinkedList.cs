namespace DSA.DataStructures;

public interface ISinglyLinkedList<T>
{
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
    T GetByIndex(int nIndex);

    /// <summary>
    ///     Returns a head node content.
    /// </summary>
    /// <returns>End node content</returns>
    T? GetLast();

    /// <summary>
    ///     Adding a new node at the beginning of the list.
    /// </summary>
    /// <param name="data">Content of the new node</param>
    /// <returns>Newly added node</returns>
    SinglyLinkedListNode<T> AddFirst(T data);

    /// <summary>
    ///     Adding a new node at the end of the list.
    /// </summary>
    /// <param name="data">Content of the new node</param>
    /// <returns>Newly added node</returns>
    SinglyLinkedListNode<T> AddLast(T data);

    /// <summary>
    ///     Insert a data on the provided index.
    /// </summary>
    /// <param name="nIndex">Index which need to store the data</param>
    /// <param name="data">Data need to be stored</param>
    /// <returns>Newly added node</returns>
    SinglyLinkedListNode<T> InsertAt(int nIndex, T data);

    /// <summary>
    ///     Insert a data after the provided node value.
    /// </summary>
    /// <param name="previous">Previous node data</param>
    /// <param name="data">Data need to be stored</param>
    /// <returns>Newly added node</returns>
    SinglyLinkedListNode<T> InsertAfter(T previous, T data);

    /// <summary>
    ///     Remove a first node equivalent to the data provided.
    /// </summary>
    /// <param name="data">Data need to removed</param>
    /// <returns>Status of the operation, If the data was removed it is true else false</returns>
    bool Remove(T data);

    /// <summary>
    ///     Remove the node which is on the given index.
    /// </summary>
    /// <param name="nIndex">Index need to removed from the list</param>
    /// <returns>Status of the operation, If the data was removed it is true else false</returns>
    bool RemoveAt(int nIndex);

    /// <summary>
    ///     Remove all the node equivalent to the data provided.
    /// </summary>
    /// <param name="data">Data need to removed</param>
    /// <returns>Status of the operation, If the data was removed it is true else false</returns>
    bool RemoveAll(T data);

    /// <summary>
    ///     Returns a total data count available on the list.
    /// </summary>
    /// <returns>Length of the linked list</returns>
    int Count();
}