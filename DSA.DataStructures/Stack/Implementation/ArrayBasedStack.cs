namespace DSA.DataStructures;

public class ArrayBasedStack<T> : IStackBase<T>
{
    #region Constants
    // Array growing count
    private const int BOUND = 5;
    #endregion

    #region Fields
    public int nTop = -1;
    public int nLength;
    #endregion

    #region Properties
    private T[] Stack { get; set; } = null!;
    #endregion

    #region Publics
    public void Push(T data)
    {
        if(nTop == nLength - 1)
        {
            this.Stack = ExtendStack();
        }

        nTop += 1;

        this.Stack[nTop] = data;
    }

    public bool IsEmpty()
    {
        return nLength == 0;
    }

    public T Pop()
    {
        if(nTop < 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        T data = this.Stack[nTop];
        this.Stack[nTop] = default!;

        nTop--;

        return data;
    }

    public T Top()
    {
        if(nTop < 0)
        {
            throw ThrowExceptionsHelper<T>.ThrowArgumentOutOfRangeException();
        }

        return this.Stack[nTop];
    }

    public int Length()
    {
        return nTop + 1;
    }
    #endregion

    #region Privates
    private T[] ExtendStack()
    {
        T[] stackNew = new T[nLength + BOUND];

        // Copy the old stack data to new stack
        for(int i = 0; i < nLength; i++)
        {
            stackNew[i] = this.Stack[i];
        }

        nLength += BOUND;

        return stackNew;
    }
    #endregion
}