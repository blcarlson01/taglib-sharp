using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Asf.Tests
{
	public partial class HeaderObjectTest
	{

[TestMethod]
[PexGeneratedBy(typeof(HeaderObjectTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTestThrowsArgumentNullException97()
{
    HeaderObject headerObject;
    headerObject = this.ConstructorTest((File)null, 0L);
}
	}
}
