using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Tests
{
	public partial class UnsupportedFormatExceptionTest
	{

[TestMethod]
[PexGeneratedBy(typeof(UnsupportedFormatExceptionTest))]
public void ConstructorTest01384()
{
    UnsupportedFormatException unsupportedFormatException;
    unsupportedFormatException =
      this.ConstructorTest01((string)null, (Exception)null);
    Assert.IsNotNull((object)unsupportedFormatException);
    Assert.IsNull(((Exception)unsupportedFormatException).InnerException);
    Assert.AreEqual<int>
        (-2146233088, ((Exception)unsupportedFormatException).HResult);
}
	}
}
