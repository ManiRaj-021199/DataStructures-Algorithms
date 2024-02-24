namespace DSA.DataStructures.Test;

[TestClass]
public class QueueBasedStackTest
{
    #region Properties
    private IStackBase<int> QueueBasedStack { get; set; } = null!;
    #endregion

    #region Initialize and Cleanup
    [TestInitialize]
    public void TestInitialize()
    {
        this.QueueBasedStack = new QueueBasedStack<int>();
    }
    #endregion

    #region Tests
    [TestMethod]
    public void Test_Push_Success()
    {
        // Arrange

        // Act
        this.QueueBasedStack.Push(1);
        this.QueueBasedStack.Push(2);
        this.QueueBasedStack.Push(3);
        this.QueueBasedStack.Push(4);
        this.QueueBasedStack.Push(5);
        this.QueueBasedStack.Push(6);

        // Assert
        int nValue = this.QueueBasedStack.Top();

        Assert.AreEqual(6, nValue);
    }

    [TestMethod]
    public void Test_IsEmpty_Success_EmptyStack()
    {
        // Arrange

        // Act
        bool bIsEmpty = this.QueueBasedStack.IsEmpty();

        // Assert
        Assert.IsTrue(bIsEmpty);
    }

    [TestMethod]
    public void Test_IsEmpty_Success_NonEmptyStack()
    {
        // Arrange
        this.QueueBasedStack.Push(1);

        // Act
        bool bIsEmpty = this.QueueBasedStack.IsEmpty();

        // Assert
        Assert.IsFalse(bIsEmpty);
    }

    [TestMethod]
    public void Test_Pop_Success()
    {
        // Arrange
        this.QueueBasedStack.Push(1);
        this.QueueBasedStack.Push(2);

        // Act
        int nValue = this.QueueBasedStack.Pop();

        // Assert
        Assert.AreEqual(2, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Pop_Success_OutOfRangeException()
    {
        // Arrange

        // Act
        int nValue = this.QueueBasedStack.Pop();

        // Assert
        Assert.AreEqual(2, nValue);
    }

    [TestMethod]
    public void Test_Top_Success()
    {
        // Arrange
        this.QueueBasedStack.Push(1);
        this.QueueBasedStack.Push(2);
        this.QueueBasedStack.Push(3);
        this.QueueBasedStack.Push(4);

        // Act
        int nValue = this.QueueBasedStack.Top();

        // Assert
        Assert.AreEqual(4, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Top_OutOfRangeException()
    {
        // Arrange

        // Act
        this.QueueBasedStack.Top();

        // Assert
    }

    [TestMethod]
    public void Test_Length_Success_Equal()
    {
        // Arrange
        this.QueueBasedStack.Push(1);
        this.QueueBasedStack.Push(2);
        this.QueueBasedStack.Push(3);
        this.QueueBasedStack.Push(4);

        // Act
        int nLength = this.QueueBasedStack.Length();

        // Assert
        Assert.AreEqual(4, nLength);
    }

    [TestMethod]
    public void Test_Length_Success_NotEqual()
    {
        // Arrange
        this.QueueBasedStack.Push(1);
        this.QueueBasedStack.Push(2);
        this.QueueBasedStack.Push(3);
        this.QueueBasedStack.Push(4);

        // Act
        int nLength = this.QueueBasedStack.Length();

        // Assert
        Assert.AreNotEqual(3, nLength);
    }
    #endregion
}