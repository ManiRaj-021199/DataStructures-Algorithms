namespace DSA.DataStructures;

public class ListBasedStack<T> : IStackBase<T>
{
    #region Properties
    private List<T> Stack { get; set; } = new();
    #endregion

    #region Publics
    public void Push(T data)
    {
        this.Stack.Add(data);
    }

    public bool IsEmpty()
    {
        return this.Stack.Count == 0;
    }

    public T Pop()
    {
        if (this.Stack.Count <= 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        T last = this.Stack.Last();
        this.Stack.RemoveAt(this.Stack.Count - 1);

        return last;
    }

    public T Top()
    {
        if(this.Stack.Count <= 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        return this.Stack.Last();
    }

    public int Length()
    {
        return this.Stack.Count;
    }
    #endregion
}