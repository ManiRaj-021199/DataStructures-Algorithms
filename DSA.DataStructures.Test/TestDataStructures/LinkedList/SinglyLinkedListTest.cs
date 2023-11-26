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