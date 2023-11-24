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
    public void Test_GetHeadValue()
    {
        // Arrange

        // Act
        _ = this.SinglyLinkedList.AddFirst(1);

        // Assert
        int nValue = this.SinglyLinkedList.GetFirst();

        Assert.AreEqual(1, nValue);
    }

    [TestMethod]
    public void Test_GetHeadValue_NullReferenceException()
    {
        // Arrange

        // Act

        // Assert
        Assert.ThrowsException<NullReferenceException>(() => this.SinglyLinkedList.GetFirst());
    }

    [TestMethod]
    public void Test_GetTailValue()
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
    public void Test_GetTailValue_NullReferenceException()
    {
        // Arrange

        // Act

        // Assert
        Assert.ThrowsException<NullReferenceException>(() => this.SinglyLinkedList.GetLast());
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
    #endregion
}