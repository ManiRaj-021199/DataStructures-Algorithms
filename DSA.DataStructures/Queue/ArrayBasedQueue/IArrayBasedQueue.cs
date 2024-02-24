namespace DSA.DataStructures;

public interface IArrayBasedQueue<T>
{
    /// <summary>
    ///     Addition of a data to the queue.
    /// </summary>
    /// <param name="data">Data need to add</param>
    void Enqueue(T data);

    /// <summary>
    ///     Remove first data from the queue.
    /// </summary>
    /// <returns>Removed data</returns>
    T Dequeue();

    /// <summary>
    ///     Returns first data of the queue.
    /// </summary>
    /// <returns>First data of the queue</returns>
    T First();

    /// <summary>
    ///     Returns last data of the queue.
    /// </summary>
    /// <returns>Last data of the queue</returns>
    T Last();
}