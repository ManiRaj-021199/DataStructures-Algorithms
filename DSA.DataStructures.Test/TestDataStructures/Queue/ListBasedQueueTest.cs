namespace DSA.DataStructures.Test;

[TestClass]
public class ListBasedQueueTest
{
    #region Properties
    private IQueueBase<int> ListBasedQueue { get; set; } = null!;
    #endregion

    #region Initialize and Cleanup
    [TestInitialize]
    public void TestInitialize()
    {
        this.ListBasedQueue = new ListBasedQueue<int>();
    }
    #endregion

    #region Tests
    [TestMethod]
    public void Test_Enqueue_Success()
    {
        // Arrange
        this.ListBasedQueue.Enqueue(1);
        this.ListBasedQueue.Enqueue(2);
        this.ListBasedQueue.Enqueue(3);
        this.ListBasedQueue.Enqueue(4);
        this.ListBasedQueue.Enqueue(5);
        this.ListBasedQueue.Enqueue(6);

        // Act
        int nFront = this.ListBasedQueue.First();
        int nLast = this.ListBasedQueue.Last();

        // Assert
        Assert.AreEqual(1, nFront);
        Assert.AreEqual(6, nLast);
    }

    [TestMethod]
    public void Test_Dequeue_Success() 
    {
        // Arrange
        this.ListBasedQueue.Enqueue(1);
        this.ListBasedQueue.Enqueue(2);
        this.ListBasedQueue.Enqueue(3);
        this.ListBasedQueue.Enqueue(4);

        // Act
        int nFirst = this.ListBasedQueue.Dequeue();
        int nLast = this.ListBasedQueue.Last();

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
        _ = this.ListBasedQueue.Dequeue();

        // Assert
    }

    [TestMethod]
    public void Test_Front_Success()
    {
        // Arrange
        this.ListBasedQueue.Enqueue(1);
        this.ListBasedQueue.Enqueue(2);
        this.ListBasedQueue.Enqueue(3);

        // Act
        int nFront = this.ListBasedQueue.First();

        // Assert
        Assert.AreEqual(1, nFront);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Front_OutOfRangeException()
    {
        // Arrange
        
        // Act
        _ = this.ListBasedQueue.First();

        // Assert
    }

    [TestMethod]
    public void Test_Last_Success()
    {
        // Arrange
        this.ListBasedQueue.Enqueue(1);
        this.ListBasedQueue.Enqueue(2);
        this.ListBasedQueue.Enqueue(3);

        // Act
        int nFront = this.ListBasedQueue.Last();

        // Assert
        Assert.AreEqual(3, nFront);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Last_OutOfRangeException()
    {
        // Arrange

        // Act
        _ = this.ListBasedQueue.Last();

        // Assert
    }

    [TestMethod]
    public void Test_Length_Success_Equal()
    {
        // Arrange
        this.ListBasedQueue.Enqueue(1);
        this.ListBasedQueue.Enqueue(2);
        this.ListBasedQueue.Enqueue(3);
        this.ListBasedQueue.Enqueue(4);

        // Act
        int nLength = this.ListBasedQueue.Length();

        // Assert
        Assert.AreEqual(4, nLength);
    }

    [TestMethod]
    public void Test_Length_Success_NotEqual()
    {
        // Arrange
        this.ListBasedQueue.Enqueue(1);
        this.ListBasedQueue.Enqueue(2);
        this.ListBasedQueue.Enqueue(3);
        this.ListBasedQueue.Enqueue(4);

        // Act
        int nLength = this.ListBasedQueue.Length();

        // Assert
        Assert.AreNotEqual(3, nLength);
    }
    #endregion
}