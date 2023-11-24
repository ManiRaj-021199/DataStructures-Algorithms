namespace DSA.Common.Test;

[TestClass]
public class ThrowExceptionsHelperTest
{
    #region Tests
    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void Test_ThrowNullException_ValueNull()
    {
        // Arrange
        string? strValue = null;

        // Act
        ThrowExceptionsHelper<string>.ThrowNullException(strValue);
    }

    [TestMethod]
    public void Test_ThrowNullException_ValueNotNull()
    {
        // Arrange
        string strValue = string.Empty;

        // Act
        ThrowExceptionsHelper<string>.ThrowNullException(strValue);
    }
    #endregion
}