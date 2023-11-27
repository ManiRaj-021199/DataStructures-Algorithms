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
}