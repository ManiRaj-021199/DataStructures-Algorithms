namespace DSA.DataStructures.Test;

[TestClass]
public class ArrayBasedStackTest
{
    #region Properties
    private IArrayBasedStack<int> ArrayBasedStack { get; set; } = null!;
    #endregion

    #region Initialize and Cleanup
    [TestInitialize]
    public void TestInitialize()
    {
        this.ArrayBasedStack = new ArrayBasedStack<int>();
    }
    #endregion

    #region Tests
    [TestMethod]
    public void Test_Push_Success()
    {
        // Arrange

        // Act
        this.ArrayBasedStack.Push(1);
        this.ArrayBasedStack.Push(2);
        this.ArrayBasedStack.Push(3);
        this.ArrayBasedStack.Push(4);
        this.ArrayBasedStack.Push(5);
        this.ArrayBasedStack.Push(6);

        // Assert
        int nValue = this.ArrayBasedStack.Top();

        Assert.AreEqual(6, nValue);
    }

    [TestMethod]
    public void Test_IsEmpty_Success_EmptyStack()
    {
        // Arrange

        // Act
        bool bIsEmpty = this.ArrayBasedStack.IsEmpty();

        // Assert
        Assert.IsTrue(bIsEmpty);
    }

    [TestMethod]
    public void Test_IsEmpty_Success_NonEmptyStack()
    {
        // Arrange
        this.ArrayBasedStack.Push(1);

        // Act
        bool bIsEmpty = this.ArrayBasedStack.IsEmpty();

        // Assert
        Assert.IsFalse(bIsEmpty);
    }

    [TestMethod]
    public void Test_Pop_Success()
    {
    }

    [TestMethod]
    public void Test_Top_Success()
    {
        // Arrange
        this.ArrayBasedStack.Push(1);
        this.ArrayBasedStack.Push(2);
        this.ArrayBasedStack.Push(3);
        this.ArrayBasedStack.Push(4);

        // Act
        int nValue = this.ArrayBasedStack.Top();

        // Assert
        Assert.AreEqual(4, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_Top_OutOfRangeException()
    {
        // Arrange

        // Act
        this.ArrayBasedStack.Top();

        // Assert
    }
    #endregion
}