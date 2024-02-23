namespace DSA.DataStructures;

public interface IListBasedStack<T>
{
    /// <summary>
    ///     Adds an element to the top of the stack.
    /// </summary>
    /// <param name="data">Data need to add to the stack</param>
    void Push(T data);

    /// <summary>
    ///     Checks weather the stack is empty.
    /// </summary>
    /// <returns>True if the stack is empty else False</returns>
    bool IsEmpty();

    /// <summary>
    ///     Removes the top most element from the stack.
    /// </summary>
    T Pop();
    
    /// <summary>
    ///     Return the top most element of the stack.
    /// </summary>
    /// <returns>Top most element of the stack</returns>
    T Top();
}