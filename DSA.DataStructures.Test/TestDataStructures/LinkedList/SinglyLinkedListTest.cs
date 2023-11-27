namespace DSA.DataStructures.Test;

[TestClass]
public class SinglyLinkedListTest
{
    #region Properties
    private ISinglyLinkedList<int> SinglyLinkedList { get; set; } = new SinglyLinkedList<int>();
    #endregion

    #region Initialize and Cleanup
    [TestInitialize]
    public void TestInitialize()
    {
        this.SinglyLinkedList = new SinglyLinkedList<int>();
    }
    #endregion

    #region Tests
    [TestMethod]
    public void Test_GetFirst()
    {
        // Arrange

        // Act
        _ = this.SinglyLinkedList.AddFirst(1);

        // Assert
        int nValue = this.SinglyLinkedList.GetFirst();

        Assert.AreEqual(1, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void Test_GetFirst_NullReferenceException()
    {
        // Arrange

        // Act

        // Assert
        _ = this.SinglyLinkedList.GetFirst();
    }

    [TestMethod]
    public void Test_GetByIndex()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);
        _ = this.SinglyLinkedList.AddFirst(2);
        _ = this.SinglyLinkedList.AddFirst(3);

        // Act
        int nValue = this.SinglyLinkedList.GetByIndex(1);

        // Assert
        Assert.AreEqual(2, nValue);

        _ = this.SinglyLinkedList.AddFirst(5);
        nValue = this.SinglyLinkedList.GetByIndex(1);

        Assert.AreEqual(3, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_GetByIndex_NegativeValue_ArgumentOutOfRangeException()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);

        // Assert
        _ = this.SinglyLinkedList.GetByIndex(-1);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_GetByIndex_ArgumentOutOfRangeException()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);

        // Assert
        _ = this.SinglyLinkedList.GetByIndex(2);
    }

    [TestMethod]
    public void Test_GetLast()
    {
        // Arrange

        // Act
        _ = this.SinglyLinkedList.AddFirst(1);
        _ = this.SinglyLinkedList.AddFirst(2);

        // Assert
        int nValue = this.SinglyLinkedList.GetLast();

        Assert.AreEqual(1, nValue);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void Test_GetLast_NullReferenceException()
    {
        // Arrange

        // Act

        // Assert
        _ = this.SinglyLinkedList.GetLast();
    }

    [TestMethod]
    public void Test_AddFirst()
    {
        // Arrange

        // Act
        _ = this.SinglyLinkedList.AddFirst(1);

        // Assert
        int nValue = this.SinglyLinkedList.GetFirst();

        Assert.AreEqual(1, nValue);

        _ = this.SinglyLinkedList.AddFirst(2);
        nValue = this.SinglyLinkedList.GetFirst();

        Assert.AreEqual(2, nValue);
    }

    [TestMethod]
    public void Test_AddLast()
    {
        // Arrange

        // Act
        _ = this.SinglyLinkedList.AddLast(1);
        _ = this.SinglyLinkedList.AddLast(2);

        // Assert
        int nValue = this.SinglyLinkedList.GetLast();

        Assert.AreEqual(2, nValue);

        _ = this.SinglyLinkedList.AddLast(3);
        nValue = this.SinglyLinkedList.GetLast();

        Assert.AreEqual(3, nValue);

        nValue = this.SinglyLinkedList.GetFirst();
        Assert.AreEqual(1, nValue);
    }

    [TestMethod]
    public void Test_InsertAt()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);

        // Act
        _ = this.SinglyLinkedList.InsertAt(0, 0);

        // Act
        string strValue = this.SinglyLinkedList.ToString('-');
        Assert.AreEqual("0-1", strValue);
    }

    [TestMethod]
    public void Test_InsertAt_MiddlePosition()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddLast(1);
        _ = this.SinglyLinkedList.AddLast(2);
        _ = this.SinglyLinkedList.AddLast(3);

        // Act
        _ = this.SinglyLinkedList.InsertAt(1, 22);

        // Act
        string strValue = this.SinglyLinkedList.ToString('-');
        Assert.AreEqual("1-22-2-3", strValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_InsertAt_ArgumentOutOfRangeException()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);

        // Act
        _ = this.SinglyLinkedList.InsertAt(10, 0);

        // Act
    }

    [TestMethod]
    public void Test_InsertAfter()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);

        // Act
        _ = this.SinglyLinkedList.InsertAfter(1, 10);

        // Act
        string strValue = this.SinglyLinkedList.ToString('-');
        Assert.AreEqual("1-10", strValue);
    }

    [TestMethod]
    public void Test_InsertAfter_MiddlePosition()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddLast(1);
        _ = this.SinglyLinkedList.AddLast(2);
        _ = this.SinglyLinkedList.AddLast(3);

        // Act
        _ = this.SinglyLinkedList.InsertAfter(2, 22);

        // Act
        string strValue = this.SinglyLinkedList.ToString('-');
        Assert.AreEqual("1-2-22-3", strValue);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), ExceptionConstants.VALUE_NOT_AVAILABLE)]
    public void Test_InsertAfter_ArgumentOutOfRangeException()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);

        // Act
        _ = this.SinglyLinkedList.InsertAfter(10, 0);

        // Act
    }

    [TestMethod]
    public void Test_Remove()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);
        _ = this.SinglyLinkedList.AddFirst(2);
        _ = this.SinglyLinkedList.AddFirst(3);

        // Act
        bool bIsDeleted = this.SinglyLinkedList.Remove(3);

        // Assert
        Assert.IsTrue(bIsDeleted);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), ExceptionConstants.VALUE_NOT_AVAILABLE)]
    public void Test_Remove_ValueNotAvailable()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);
        _ = this.SinglyLinkedList.AddFirst(2);
        _ = this.SinglyLinkedList.AddFirst(3);

        // Act
        _ = this.SinglyLinkedList.Remove(5);

        // Assert
    }

    [TestMethod]
    public void Test_RemoveAt()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(0);
        _ = this.SinglyLinkedList.AddFirst(1);
        _ = this.SinglyLinkedList.AddFirst(2);
        _ = this.SinglyLinkedList.AddFirst(3);

        // Act
        _ = this.SinglyLinkedList.RemoveAt(1);
        bool bIsDeleted = this.SinglyLinkedList.RemoveAt(0);

        // Assert
        Assert.IsTrue(bIsDeleted);

        string strValue = this.SinglyLinkedList.ToString('-');
        Assert.AreEqual("1-0", strValue);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_RemoveAt_ArgumentOutOfRangeException()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);
        _ = this.SinglyLinkedList.AddFirst(2);
        _ = this.SinglyLinkedList.AddFirst(3);

        // Act
        _ = this.SinglyLinkedList.RemoveAt(8);

        // Assert
    }

    [TestMethod]
    public void Test_RemoveAll()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddLast(1);
        _ = this.SinglyLinkedList.AddLast(2);
        _ = this.SinglyLinkedList.AddLast(3);
        _ = this.SinglyLinkedList.AddLast(1);

        // Act
        bool bIsDeleted = this.SinglyLinkedList.RemoveAll(1);

        // Assert
        Assert.IsTrue(bIsDeleted);

        string strValues = this.SinglyLinkedList.ToString('~');
        Assert.AreEqual("2~3", strValues);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), ExceptionConstants.VALUE_NOT_AVAILABLE)]
    public void Test_RemoveAll_ValueNotAvailable()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);
        _ = this.SinglyLinkedList.AddFirst(2);
        _ = this.SinglyLinkedList.AddFirst(3);

        // Act
        _ = this.SinglyLinkedList.RemoveAll(5);

        // Assert
    }

    [TestMethod]
    public void Test_ToString()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);
        _ = this.SinglyLinkedList.AddFirst(2);
        _ = this.SinglyLinkedList.AddFirst(3);

        // Act
        string strValue = this.SinglyLinkedList.ToString('-');

        // Assert
        Assert.AreEqual("3-2-1", strValue);
    }

    [TestMethod]
    public void Test_Count()
    {
        // Arrange
        _ = this.SinglyLinkedList.AddFirst(1);
        _ = this.SinglyLinkedList.AddFirst(2);
        _ = this.SinglyLinkedList.AddFirst(3);

        // Act
        int nCount = this.SinglyLinkedList.Count();

        // Assert
        Assert.AreEqual(3, nCount);

        _ = this.SinglyLinkedList.AddFirst(5);
        nCount = this.SinglyLinkedList.Count();

        Assert.AreEqual(4, nCount);
    }
    #endregion
}