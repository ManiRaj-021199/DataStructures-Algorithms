namespace DSA.DataStructures;

public class BinaryTree<T> : ITreeBase<T>
{
    #region Properties
    private BinaryTreeNode<T>? Root { get; set; }
    #endregion

    #region Publics
    public int Height()
    {
        throw new NotImplementedException();
    }

    public int Level()
    {
        throw new NotImplementedException();
    }

    public int Size()
    {
        throw new NotImplementedException();
    }

    public BinaryTreeNode<T> Insert(T item)
    {
        BinaryTreeNode<T>? nodeTemp = this.Root;
        BinaryTreeNode<T> node = new BinaryTreeNode<T>(item);

        if (nodeTemp is null)
        {
            this.Root = node;

            return this.Root;
        }

        ListBasedQueue<BinaryTreeNode<T>> queue = new();
        queue.Enqueue(nodeTemp);

        // Level order travel to get an empty space
        while(queue.Length() != 0)
        {
            nodeTemp = queue.Dequeue();

            if (nodeTemp.Left is null)
            {
                nodeTemp.Left = node;
                break;
            }
            else
            {
                queue.Enqueue(nodeTemp.Left);
            }

            if (nodeTemp.Right is null)
            {
                nodeTemp.Right = node;
                break;
            }
            else
            {
                queue.Enqueue(nodeTemp.Right);
            }
        }

        return node;
    }

    public BinaryTreeNode<T> Remove(T item)
    {
        throw new NotImplementedException();
    }

    public BinaryTreeNode<T>? Find(T item)
    {
        throw new NotImplementedException();
    }

    public string IterativeInorderTraversal()
    {
        throw new NotImplementedException();
    }

    public string RecursiveInorderTraversal()
    {
        throw new NotImplementedException();
    }

    public string IterativePreorderTraversal()
    {
        throw new NotImplementedException();
    }

    public string RecursivePreorderTraversal()
    {
        throw new NotImplementedException();
    }

    public string IterativePostorderTraversal()
    {
        throw new NotImplementedException();
    }

    public string RecursivePostorderTraversal()
    {
        throw new NotImplementedException();
    }

    public string IterativeLevelorderTraversal()
    {
        throw new NotImplementedException();
    }

    public string RecursiveLevelorderTraversal()
    {
        throw new NotImplementedException();
    }
    #endregion
}