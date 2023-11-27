namespace DSA.Common;

public class SinglyLinkedListNode<T>
{
    #region Properties
    public T? Data { get; }
    public SinglyLinkedListNode<T>? Next { get; set; }
    #endregion

    #region Constructors
    public SinglyLinkedListNode(T data, SinglyLinkedListNode<T>? next = null)
    {
        this.Data = data;
        this.Next = next;
    }
    #endregion
}