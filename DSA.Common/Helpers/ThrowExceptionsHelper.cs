﻿namespace DSA.Common;

public static class ThrowExceptionsHelper<T>
{
    #region Publics
    /// <summary>
    ///     Throw null reference exception if the data is null.
    /// </summary>
    /// <param name="data">data need to check is null or not.</param>
    /// <exception cref="NullReferenceException">Throw when the data is null.</exception>
    public static void ThrowNullException(T? data)
    {
        if(data is null)
        {
            throw new NullReferenceException(nameof(data));
        }
    }
    #endregion
}