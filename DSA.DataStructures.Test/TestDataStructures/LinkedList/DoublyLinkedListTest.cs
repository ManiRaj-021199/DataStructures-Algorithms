﻿namespace DSA.DataStructures.Test;

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
    public void Test_GetData()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddFirst(1);
        _ = this.DoublyLinkedList.AddFirst(2);
        _ = this.DoublyLinkedList.AddFirst(3);

        // Act
        List<int> lstData = this.DoublyLinkedList.GetData().ToList();

        // Assert
        Assert.AreEqual(3, lstData.Count);

        Assert.AreEqual(3, lstData[0]);
        Assert.AreEqual(2, lstData[1]);
        Assert.AreEqual(1, lstData[2]);
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

        Assert.AreEqual(3, this.DoublyLinkedList.GetFirst());
        Assert.AreEqual(1, this.DoublyLinkedList.GetLast());
    }

    [TestMethod]
    public void Test_AddLast()
    {
        // Arrange

        // Act
        _ = this.DoublyLinkedList.AddLast(1);
        _ = this.DoublyLinkedList.AddLast(2);
        _ = this.DoublyLinkedList.AddLast(3);

        // Assert
        Assert.AreEqual(3, this.DoublyLinkedList.Count);

        Assert.AreEqual(1, this.DoublyLinkedList.GetFirst());
        Assert.AreEqual(3, this.DoublyLinkedList.GetLast());
    }

    [TestMethod]
    public void Test_InsertAt()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddLast(1);
        _ = this.DoublyLinkedList.AddLast(2);
        _ = this.DoublyLinkedList.AddLast(3);

        // Act
        _ = this.DoublyLinkedList.InsertAt(2, 22);

        // Assert
        Assert.AreEqual(4, this.DoublyLinkedList.Count);

        Assert.AreEqual(2, this.DoublyLinkedList.GetByIndex(1));
        Assert.AreEqual(22, this.DoublyLinkedList.GetByIndex(2));
        Assert.AreEqual(3, this.DoublyLinkedList.GetByIndex(3));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_InsertAt_NegativeValue_ArgumentOutOfRangeException()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddFirst(1);
        _ = this.DoublyLinkedList.AddFirst(2);
        _ = this.DoublyLinkedList.AddFirst(3);

        // Act
        _ = this.DoublyLinkedList.InsertAt(-1, 22);

        // Assert
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void Test_InsertAt_LengthExceeds_ArgumentOutOfRangeException()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddFirst(1);
        _ = this.DoublyLinkedList.AddFirst(2);
        _ = this.DoublyLinkedList.AddFirst(3);

        // Act
        _ = this.DoublyLinkedList.InsertAt(4, 22);

        // Assert
    }

    [TestMethod]
    public void Test_InsertAfter()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddLast(1);
        DoublyLinkedListNode<int> previous = this.DoublyLinkedList.AddLast(2);
        _ = this.DoublyLinkedList.AddLast(3);

        // Act
        _ = this.DoublyLinkedList.InsertAfter(previous, 22);

        // Assert
        Assert.AreEqual(4, this.DoublyLinkedList.Count);

        Assert.AreEqual(2, this.DoublyLinkedList.GetByIndex(1));
        Assert.AreEqual(22, this.DoublyLinkedList.GetByIndex(2));
        Assert.AreEqual(3, this.DoublyLinkedList.GetByIndex(3));
    }

    [TestMethod]
    public void Test_Find()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddLast(1);
        _ = this.DoublyLinkedList.AddLast(2);
        _ = this.DoublyLinkedList.AddLast(3);

        // Act
        DoublyLinkedListNode<int> node = this.DoublyLinkedList.Find(2);

        // Assert
        Assert.IsNotNull(node);
        Assert.AreEqual(2, node.Data);
    }

    [TestMethod]
    public void Test_Find_ValueNotAvailableException()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddLast(1);
        _ = this.DoublyLinkedList.AddLast(2);
        _ = this.DoublyLinkedList.AddLast(3);

        // Act
        DoublyLinkedListNode<int>? node = this.DoublyLinkedList.Find(22);

        // Assert
        Assert.IsNull(node);
    }

    [TestMethod]
    public void Test_RemoveHead()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddLast(1);
        _ = this.DoublyLinkedList.AddLast(2);
        _ = this.DoublyLinkedList.AddLast(3);

        // Act
        this.DoublyLinkedList.RemoveHead();

        // Assert
        Assert.AreEqual(2, this.DoublyLinkedList.Count);
        Assert.AreEqual(2, this.DoublyLinkedList.GetFirst());
        Assert.AreEqual(3, this.DoublyLinkedList.GetLast());
    }

    [TestMethod]
    [ExpectedException(typeof(Exception), ExceptionMessages.VALUE_NOT_AVAILABLE)]
    public void Test_RemoveHead_NullReferenceException()
    {
        // Arrange

        // Act

        // Assert
        this.DoublyLinkedList.RemoveHead();
    }

    [TestMethod]
    public void Test_RemoveAt_Success()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddLast(1);
        _ = this.DoublyLinkedList.AddLast(2);
        _ = this.DoublyLinkedList.AddLast(3);

        // Act
        this.DoublyLinkedList.RemoveAt(1);

        // Assert
        Assert.AreEqual(2, this.DoublyLinkedList.Count);
        Assert.AreEqual(1, this.DoublyLinkedList.GetFirst());
        Assert.AreEqual(3, this.DoublyLinkedList.GetLast());
    }

    [TestMethod]
    public void Test_RemoveAt_Head_Success()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddLast(1);
        _ = this.DoublyLinkedList.AddLast(2);

        // Act
        this.DoublyLinkedList.RemoveAt(0);

        // Assert
        Assert.AreEqual(1, this.DoublyLinkedList.Count);
        Assert.AreEqual(2, this.DoublyLinkedList.GetFirst());
        Assert.AreEqual(2, this.DoublyLinkedList.GetLast());
    }

    [TestMethod]
    public void Test_RemoveAt_Tail_Success()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddLast(1);
        _ = this.DoublyLinkedList.AddLast(2);

        // Act
        this.DoublyLinkedList.RemoveAt(1);

        // Assert
        Assert.AreEqual(1, this.DoublyLinkedList.Count);
        Assert.AreEqual(1, this.DoublyLinkedList.GetFirst());
        Assert.AreEqual(1, this.DoublyLinkedList.GetLast());
    }

    [TestMethod]
    public void Test_RemoveAt_LengthExceeds_Success()
    {
        // Arrange
        _ = this.DoublyLinkedList.AddLast(1);
        _ = this.DoublyLinkedList.AddLast(2);

        // Act
        this.DoublyLinkedList.RemoveAt(2);

        // Assert
        Assert.AreEqual(2, this.DoublyLinkedList.Count);
        Assert.AreEqual(1, this.DoublyLinkedList.GetFirst());
        Assert.AreEqual(2, this.DoublyLinkedList.GetLast());
    }
    #endregion
}