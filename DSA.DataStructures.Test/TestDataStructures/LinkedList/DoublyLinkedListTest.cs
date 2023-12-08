namespace DSA.DataStructures.Test;

[TestClass]
public class DoublyLinkedListTest
{
    #region Properties
    private IDoublyLinkedList<int> DoublyLinkedList { get; set; } = new DoublyLinkedList<int>();
    #endregion

    #region Initialize and Cleanup
    [TestInitialize]
    public void TestInitialize()
    {
        this.DoublyLinkedList = new DoublyLinkedList<int>();
    }
    #endregion

    #region Tests
    [TestMethod]
    public void Test_GetFirst()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddFirst(1);
        _ = this.DoublyLinkedList.AddFirst(2);
        _ = this.DoublyLinkedList.AddFirst(3);

        // Act
        int nValue = this.DoublyLinkedList.GetFirst();

        // Assert
        Assert.AreEqual(3, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void Test_GetFirst_NullReferenceException()
    {
        // Arrange

        // Act

        // Assert
        _ = this.DoublyLinkedList.GetFirst();
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_GetByIndex_NegativeValue_ArgumentOutOfRangeException()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddFirst(1);
        _ = this.DoublyLinkedList.AddFirst(2);
        _ = this.DoublyLinkedList.AddFirst(3);

        // Act
        _ = this.DoublyLinkedList.GetByIndex(-1);

        // Assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_GetByIndex_LengthExceeds_ArgumentOutOfRangeException()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddFirst(1);
        _ = this.DoublyLinkedList.AddFirst(2);
        _ = this.DoublyLinkedList.AddFirst(3);

        // Act
        _ = this.DoublyLinkedList.GetByIndex(4);

        // Assert
    }

    [TestMethod]
    public void Test_GetByIndex()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddFirst(1);
        _ = this.DoublyLinkedList.AddFirst(2);
        _ = this.DoublyLinkedList.AddFirst(3);

        // Act
        int nValue = this.DoublyLinkedList.GetByIndex(1);

        // Assert
        Assert.AreEqual(2, nValue);
    }

    [TestMethod]
    public void Test_GetLast()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddFirst(1);
        _ = this.DoublyLinkedList.AddFirst(2);
        _ = this.DoublyLinkedList.AddFirst(3);

        // Act
        int nValue = this.DoublyLinkedList.GetLast();

        // Assert
        Assert.AreEqual(1, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void Test_GetLast_NullReferenceException()
    {
        // Arrange

        // Act

        // Assert
        _ = this.DoublyLinkedList.GetLast();
    }

    [TestMethod]
    public void Test_AddFirst()
    {
        // Arrange

        // Act
        _ = this.DoublyLinkedList.AddFirst(1);
        _ = this.DoublyLinkedList.AddFirst(2);
        _ = this.DoublyLinkedList.AddFirst(3);

        // Assert
        Assert.AreEqual(3, this.DoublyLinkedList.Count);
    }
    #endregion
}