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
	public partial class SupportedMimeTypeTest
	{

[TestMethod]
[PexGeneratedBy(typeof(SupportedMimeTypeTest))]
public void ConstructorTest580()
{
    SupportedMimeType supportedMimeType;
    supportedMimeType = this.ConstructorTest((string)null);
    Assert.IsNotNull((object)supportedMimeType);
    Assert.AreEqual<string>((string)null, supportedMimeType.MimeType);
    Assert.AreEqual<string>((string)null, supportedMimeType.Extension);
}
	}
}
