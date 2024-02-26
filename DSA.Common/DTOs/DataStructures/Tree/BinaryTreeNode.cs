namespace DSA.Common;

public class BinaryTreeNode<T>
{
    #region Properties
    public T TData { get; set; } = default!;
    public BinaryTreeNode<T>? Left { get; set; } = null;
    public BinaryTreeNode<T>? Right { get; set; } = null;
    #endregion

    #region Constructors
    public BinaryTreeNode(T data)
    {
        this.TData = data;
        this.Left = null;
        this.Right = null;
    }
    #endregion
}