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

    public BinaryTreeNode<T>? Remove(T item)
    {
        BinaryTreeNode<T>? nodeTemp = this.Root;

        if (nodeTemp is null)
        {
            return default;
        }

        if (nodeTemp.Left is null && nodeTemp.Right is null)
        {
            if(nodeTemp.TData?.Equals(item) == true)
            {
                this.Root = default;
            }

            return default;
        }

        ListBasedQueue<BinaryTreeNode<T>> queue = new();
        queue.Enqueue(nodeTemp);

        BinaryTreeNode<T>? nodeKey = default;

        while (queue.Length() != 0)
        {
            nodeTemp = queue.Dequeue();

            if (nodeTemp.TData?.Equals(item) == true)
            {
                nodeKey = nodeTemp;
            }

            if (nodeTemp.Left is not null)
            {
                queue.Enqueue(nodeTemp.Left);
            }

            if (nodeTemp.Right is not null)
            {
                queue.Enqueue(nodeTemp.Right);
            }
        }

        if (nodeKey is not null)
        {
            T data = nodeTemp.TData;

            DeleteDeepestNode(nodeKey);

            nodeKey.TData = data;
        }

        return nodeKey;
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

    #region Privates
    private void DeleteDeepestNode(BinaryTreeNode<T> nodeNeedToDelete)
    {
        if (this.Root is null) return;

        ListBasedQueue<BinaryTreeNode<T>> queue = new();
        queue.Enqueue(this.Root);

        while (queue.Length() != 0)
        {
            BinaryTreeNode<T>? nodeTemp = queue.Dequeue();
            if (nodeTemp == nodeNeedToDelete)
            {
                nodeTemp = default;
                return;
            }

            if (nodeTemp.Left != null)
            {
                if (nodeTemp.Left == nodeNeedToDelete)
                {
                    nodeTemp.Left = default;
                    return;
                }
                else
                {
                    queue.Enqueue(nodeTemp.Left);
                }
            }

            if (nodeTemp.Right != null)
            {
                if (nodeTemp.Right == nodeNeedToDelete)
                {
                    nodeTemp.Right = default;
                    return;
                }
                else
                {
                    queue.Enqueue(nodeTemp.Right);
                }
            }
        }
    }
    #endregion
}