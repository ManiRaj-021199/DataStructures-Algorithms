namespace DSA.DataStructures;

public interface ITreeBase<T>
{
    /// <summary>
    ///     To calculate the height of the tree.
    /// </summary>
    /// <returns>Height of the tree</returns>
    int Height();

    /// <summary>
    ///     To calculate the level of the tree.
    /// </summary>
    /// <returns>Level of the tree</returns>
    int Level();

    /// <summary>
    ///     To calculate the size of the tree.
    /// </summary>
    /// <returns>Size of the tree</returns>
    int Size();

    /// <summary>
    ///     Insert an element into the tree.
    /// </summary>
    /// <param name="item">Item need to insert into the tree</param>
    /// <returns>Inserted item</returns>
    BinaryTreeNode<T> Insert(T item);

    /// <summary>
    ///     Remove an element from the tree.
    /// </summary>
    /// <param name="item">Item need to remove from the tree</param>
    /// <returns>Removed item</returns>
    BinaryTreeNode<T>? Remove(T item);

    /// <summary>
    ///     Find an element from the tree
    /// </summary>
    /// <param name="item">Item need to find from the tree</param>
    /// <returns>Null if the item was not in the tree else the node</returns>
    BinaryTreeNode<T>? Find(T item);

    /// <summary>
    ///     Inorder traversal in iterative approach.
    /// </summary>
    /// <returns>String contains tree values separated by '-'</returns>
    string IterativeInorderTraversal();

    /// <summary>
    ///     Inorder traversal in recursive approach.
    /// </summary>
    /// <returns>String contains tree values separated by '-'</returns>
    string RecursiveInorderTraversal();

    /// <summary>
    ///     Preorder traversal in iterative approach.
    /// </summary>
    /// <returns>String contains tree values separated by '-'</returns>
    string IterativePreorderTraversal();

    /// <summary>
    ///     Preorder traversal in recursive approach.
    /// </summary>
    /// <returns>String contains tree values separated by '-'</returns>
    string RecursivePreorderTraversal();

    /// <summary>
    ///     Postorder traversal in iterative approach.
    /// </summary>
    /// <returns>String contains tree values separated by '-'</returns>
    string IterativePostorderTraversal();

    /// <summary>
    ///     Postorder traversal in recursive approach.
    /// </summary>
    /// <returns>String contains tree values separated by '-'</returns>
    string RecursivePostorderTraversal();

    /// <summary>
    ///     Levelorder traversal in iterative approach.
    /// </summary>
    /// <returns>String contains tree values separated by '-'</returns>
    string IterativeLevelorderTraversal();

    /// <summary>
    ///     Levelorder traversal in recursive approach.
    /// </summary>
    /// <returns>String contains tree values separated by '-'</returns>
    string RecursiveLevelorderTraversal();
}