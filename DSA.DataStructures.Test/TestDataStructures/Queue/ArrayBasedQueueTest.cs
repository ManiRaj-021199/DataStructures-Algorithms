namespace DSA.DataStructures.Test;

[TestClass]
public class ArrayBasedQueueTest
{
    #region Properties
    private IArrayBasedQueue<int> ArrayBasedQueue { get; set; } = null!;
    #endregion

    #region Initialize and Cleanup
    [TestInitialize]
    public void TestInitialize()
    {
        this.ArrayBasedQueue = new ArrayBasedQueue<int>();
    }
    #endregion

    #region Tests
    [TestMethod]
    public void Test_Enqueue_Success()
    {
        // Arrange
        this.ArrayBasedQueue.Enqueue(1);
        this.ArrayBasedQueue.Enqueue(2);
        this.ArrayBasedQueue.Enqueue(3);
        this.ArrayBasedQueue.Enqueue(4);
        this.ArrayBasedQueue.Enqueue(5);
        this.ArrayBasedQueue.Enqueue(6);

        // Act
        int nFront = this.ArrayBasedQueue.Front();
        int nLast = this.ArrayBasedQueue.Dequeue();

        // Assert
        Assert.AreEqual(1, nFront);
        Assert.AreEqual(6, nLast);
    }

    [TestMethod]
    public void Test_Dequeue_Success() 
    {
        // Arrange
        this.ArrayBasedQueue.Enqueue(1);

        // Act
        int nLast = this.ArrayBasedQueue.Dequeue();

        // Assert
        Assert.AreEqual(1, nLast);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Dequeue_OutOfRangeException() 
    {
        // Arrange

        // Act
        _ = this.ArrayBasedQueue.Dequeue();

        // Assert
    }

    [TestMethod]
    public void Test_Front_Success()
    {
        // Arrange
        this.ArrayBasedQueue.Enqueue(1);
        this.ArrayBasedQueue.Enqueue(2);
        this.ArrayBasedQueue.Enqueue(3);

        // Act
        int nFront = this.ArrayBasedQueue.Front();

        // Assert
        Assert.AreEqual(1, nFront);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Front_OutOfRangeException()
    {
        // Arrange
        
        // Act
        _ = this.ArrayBasedQueue.Front();

        // Assert
    }
    #endregion
}