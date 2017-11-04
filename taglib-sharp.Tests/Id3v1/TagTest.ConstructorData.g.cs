using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Id3v1;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Id3v1.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorDataThrowsArgumentNullException574()
{
    Tag tag;
    StringHandler s0 = new StringHandler();
    tag = this.ConstructorDataTest((ByteVector)null, s0);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorDataThrowsCorruptFileException858()
{
    ByteVector byteVector;
    Tag tag;
    byte[] bs = new byte[3];
    byteVector = ByteVectorFactory.Create(bs, 1);
    StringHandler s0 = new StringHandler();
    tag = this.ConstructorDataTest(byteVector, s0);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorDataTestThrowsCorruptFileException171()
{
    ByteVector byteVector;
    Tag tag;
    byte[] bs = new byte[192];
    byteVector = ByteVectorFactory.Create(bs, 129);
    StringHandler s0 = new StringHandler();
    tag = this.ConstructorDataTest(byteVector, s0);
}
	}
}
