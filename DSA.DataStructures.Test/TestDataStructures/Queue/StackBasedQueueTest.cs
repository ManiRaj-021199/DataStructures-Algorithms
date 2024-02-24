namespace DSA.DataStructures.Test;

[TestClass]
public class StackBasedQueueTest
{
    #region Properties
    private IQueueBase<int> StackBasedQueue { get; set; } = null!;
    #endregion

    #region Initialize and Cleanup
    [TestInitialize]
    public void TestInitialize()
    {
        this.StackBasedQueue = new StackBasedQueue<int>();
    }
    #endregion

    #region Tests
    [TestMethod]
    public void Test_Enqueue_Success()
    {
        // Arrange
        this.StackBasedQueue.Enqueue(1);
        this.StackBasedQueue.Enqueue(2);
        this.StackBasedQueue.Enqueue(3);
        this.StackBasedQueue.Enqueue(4);
        this.StackBasedQueue.Enqueue(5);
        this.StackBasedQueue.Enqueue(6);

        // Act
        int nFront = this.StackBasedQueue.First();
        int nLast = this.StackBasedQueue.Last();

        // Assert
        Assert.AreEqual(1, nFront);
        Assert.AreEqual(6, nLast);
    }

    [TestMethod]
    public void Test_Dequeue_Success() 
    {
        // Arrange
        this.StackBasedQueue.Enqueue(1);
        this.StackBasedQueue.Enqueue(2);
        this.StackBasedQueue.Enqueue(3);
        this.StackBasedQueue.Enqueue(4);

        // Act
        int nFirst = this.StackBasedQueue.Dequeue();
        int nLast = this.StackBasedQueue.Last();

        // Assert
        Assert.AreEqual(1, nFirst);
        Assert.AreEqual(4, nLast);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Dequeue_OutOfRangeException() 
    {
        // Arrange

        // Act
        _ = this.StackBasedQueue.Dequeue();

        // Assert
    }

    [TestMethod]
    public void Test_Front_Success()
    {
        // Arrange
        this.StackBasedQueue.Enqueue(1);
        this.StackBasedQueue.Enqueue(2);
        this.StackBasedQueue.Enqueue(3);

        // Act
        int nFront = this.StackBasedQueue.First();

        // Assert
        Assert.AreEqual(1, nFront);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Front_OutOfRangeException()
    {
        // Arrange
        
        // Act
        _ = this.StackBasedQueue.First();

        // Assert
    }

    [TestMethod]
    public void Test_Last_Success()
    {
        // Arrange
        this.StackBasedQueue.Enqueue(1);
        this.StackBasedQueue.Enqueue(2);
        this.StackBasedQueue.Enqueue(3);

        // Act
        int nFront = this.StackBasedQueue.Last();

        // Assert
        Assert.AreEqual(3, nFront);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Last_OutOfRangeException()
    {
        // Arrange

        // Act
        _ = this.StackBasedQueue.Last();

        // Assert
    }

    [TestMethod]
    public void Test_Length_Success_Equal()
    {
        // Arrange
        this.StackBasedQueue.Enqueue(1);
        this.StackBasedQueue.Enqueue(2);
        this.StackBasedQueue.Enqueue(3);
        this.StackBasedQueue.Enqueue(4);

        // Act
        int nLength = this.StackBasedQueue.Length();

        // Assert
        Assert.AreEqual(4, nLength);
    }

    [TestMethod]
    public void Test_Length_Success_NotEqual()
    {
        // Arrange
        this.StackBasedQueue.Enqueue(1);
        this.StackBasedQueue.Enqueue(2);
        this.StackBasedQueue.Enqueue(3);
        this.StackBasedQueue.Enqueue(4);

        // Act
        int nLength = this.StackBasedQueue.Length();

        // Assert
        Assert.AreNotEqual(3, nLength);
    }
    #endregion
}