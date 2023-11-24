namespace DSA.DataStructures.Test;

[TestClass]
public class SinglyLinkedListTest
{
    #region Tests
    [TestMethod]
    public void Test_GetHeadValue()
    {
        // Arrange
        SinglyLinkedList<int> list = new();

        // Act
        _ = list.AddFirst(1);

        // Assert
        int nValue = list.GetFirst();

        Assert.AreEqual(1, nValue);
    }

    [TestMethod]
    public void Test_GetHeadValue_NullReferenceException()
    {
        // Arrange
        SinglyLinkedList<int> list = new();

        // Act

        // Assert
        Assert.ThrowsException<NullReferenceException>(() => list.GetFirst());
    }

    [TestMethod]
    public void Test_GetTailValue()
    {
        // Arrange
        SinglyLinkedList<int> list = new();

        // Act
        _ = list.AddFirst(1);
        _ = list.AddFirst(2);

        // Assert
        int nValue = list.GetLast();

        Assert.AreEqual(1, nValue);
    }

    [TestMethod]
    public void Test_GetTailValue_NullReferenceException()
    {
        // Arrange
        SinglyLinkedList<int> list = new();

        // Act

        // Assert
        Assert.ThrowsException<NullReferenceException>(() => list.GetLast());
    }

    [TestMethod]
    public void Test_AddFirst()
    {
        // Arrange
        SinglyLinkedList<int> list = new();

        // Act
        _ = list.AddFirst(1);

        // Assert
        int nValue = list.GetFirst();

        Assert.AreEqual(1, nValue);

        _ = list.AddFirst(2);
        nValue = list.GetFirst();

        Assert.AreEqual(2, nValue);
    }

    [TestMethod]
    public void Test_AddLast()
    {
        // Arrange
        SinglyLinkedList<int> list = new();

        // Act
        _ = list.AddLast(1);
        _ = list.AddLast(2);

        // Assert
        int nValue = list.GetLast();

        Assert.AreEqual(2, nValue);

        _ = list.AddLast(3);
        nValue = list.GetLast();

        Assert.AreEqual(3, nValue);

        nValue = list.GetFirst();
        Assert.AreEqual(1, nValue);
    }
    #endregion
}