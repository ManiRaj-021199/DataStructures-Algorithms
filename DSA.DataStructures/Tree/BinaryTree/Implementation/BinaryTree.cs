﻿namespace DSA.DataStructures;

public class BinaryTree<T> : ITreeBase<T>
{
    #region Properties
    private TreeNode<T>? Root { get; set; }
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

    public TreeNode<T> Insert(T item)
    {
        TreeNode<T>? nodeTemp = this.Root;
        TreeNode<T> node = new(item);

        if(nodeTemp is null)
        {
            this.Root = node;

            return this.Root;
        }

        ListBasedQueue<TreeNode<T>> queue = new();
        queue.Enqueue(nodeTemp);

        // Level order travel to get an empty space
        while(queue.Length() != 0)
        {
            nodeTemp = queue.Dequeue();

            if(nodeTemp.Left is null)
            {
                nodeTemp.Left = node;
                break;
            }

            queue.Enqueue(nodeTemp.Left);

            if(nodeTemp.Right is null)
            {
                nodeTemp.Right = node;
                break;
            }

            queue.Enqueue(nodeTemp.Right);
        }

        return node;
    }

    public TreeNode<T> Remove(T item)
    {
        throw new NotImplementedException();
    }

    public TreeNode<T> Find(T item)
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