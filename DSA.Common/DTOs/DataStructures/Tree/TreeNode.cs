namespace DSA.Common;

public class TreeNode<T>
{
    #region Properties
    public T TData { get; set; } = default!;
    public TreeNode<T>? Left { get; set; } = null;
    public TreeNode<T>? Right { get; set; } = null;
    #endregion

    #region Constructors
    public TreeNode(T data)
    {
        this.TData = data;
        this.Left = null;
        this.Right = null;
    }
    #endregion
}