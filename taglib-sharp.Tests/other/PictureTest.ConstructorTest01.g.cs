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
	public partial class PictureTest
	{

[TestMethod]
[PexGeneratedBy(typeof(PictureTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest01ThrowsArgumentNullException849()
{
    Picture picture;
    picture = this.ConstructorTest01((File.IFileAbstraction)null);
}
	}
}
