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
    public void Test_Push()
    {
        // Arrange

        // Act
        this.ArrayBasedStack.Push(1);
        this.ArrayBasedStack.Push(2);
        this.ArrayBasedStack.Push(3);
        this.ArrayBasedStack.Push(4);
        this.ArrayBasedStack.Push(5);
        this.ArrayBasedStack.Push(6);
    }

    [TestMethod]
    public void Test_Pop()
    {
    }

    [TestMethod]
    public void Test_IsEmpty()
    {
    }

    [TestMethod]
    public void Test_Top()
    {
    }
    #endregion
}