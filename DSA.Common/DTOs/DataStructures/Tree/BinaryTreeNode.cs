namespace DSA.Common;

public class BinaryTreeNode<T>
{
    #region Properties
    T TData { get; set; } = default!;
    BinaryTreeNode<T>? Left { get; set; } = null;
    BinaryTreeNode<T>? Right { get; set; } = null;
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