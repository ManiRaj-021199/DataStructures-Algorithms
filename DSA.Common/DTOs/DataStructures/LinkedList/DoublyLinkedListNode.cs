namespace DSA.Common;

public class DoublyLinkedListNode<T>
{
    #region Properties
    public T? Data { get; }
    public DoublyLinkedListNode<T>? Previous { get; set; }
    public DoublyLinkedListNode<T>? Next { get; set; }
    #endregion

    #region Constructors
    public DoublyLinkedListNode(T data, DoublyLinkedListNode<T>? previous = null, DoublyLinkedListNode<T>? next = null)
    {
        this.Data = data;
        this.Previous = previous;
        this.Next = next;
    }
    #endregion
}