namespace DSA.DataStructures.Test;

[TestClass]
public class ListBasedStackTest
{
    #region Properties
    private IListBasedStack<int> ListBasedStack { get; set; } = null!;
    #endregion

    #region Initialize and Cleanup
    [TestInitialize]
    public void TestInitialize()
    {
        this.ListBasedStack = new ListBasedStack<int>();
    }
    #endregion

    #region Tests
    [TestMethod]
    public void Test_Push_Success()
    {
        // Arrange

        // Act
        this.ListBasedStack.Push(1);
        this.ListBasedStack.Push(2);
        this.ListBasedStack.Push(3);
        this.ListBasedStack.Push(4);
        this.ListBasedStack.Push(5);
        this.ListBasedStack.Push(6);

        // Assert
        int nValue = this.ListBasedStack.Top();

        Assert.AreEqual(6, nValue);
    }

    [TestMethod]
    public void Test_IsEmpty_Success_EmptyStack()
    {
        // Arrange

        // Act
        bool bIsEmpty = this.ListBasedStack.IsEmpty();

        // Assert
        Assert.IsTrue(bIsEmpty);
    }

    [TestMethod]
    public void Test_IsEmpty_Success_NonEmptyStack()
    {
        // Arrange
        this.ListBasedStack.Push(1);

        // Act
        bool bIsEmpty = this.ListBasedStack.IsEmpty();

        // Assert
        Assert.IsFalse(bIsEmpty);
    }

    [TestMethod]
    public void Test_Pop_Success()
    {
        // Arrange
        this.ListBasedStack.Push(1);
        this.ListBasedStack.Push(2);

        // Act
        int nValue = this.ListBasedStack.Pop();

        // Assert
        Assert.AreEqual(2, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Pop_Success_OutOfRangeException()
    {
        // Arrange

        // Act
        int nValue = this.ListBasedStack.Pop();

        // Assert
        Assert.AreEqual(2, nValue);
    }

    [TestMethod]
    public void Test_Top_Success()
    {
        // Arrange
        this.ListBasedStack.Push(1);
        this.ListBasedStack.Push(2);
        this.ListBasedStack.Push(3);
        this.ListBasedStack.Push(4);

        // Act
        int nValue = this.ListBasedStack.Top();

        // Assert
        Assert.AreEqual(4, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Top_OutOfRangeException()
    {
        // Arrange

        // Act
        this.ListBasedStack.Top();

        // Assert
    }
    #endregion
}