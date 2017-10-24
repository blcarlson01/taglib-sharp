using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Ogg;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Ogg.Tests
{
	public partial class XiphCommentTest
	{

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest01ThrowsArgumentNullException29()
{
    XiphComment xiphComment;
    xiphComment = this.ConstructorTest01((ByteVector)null);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest01ThrowsArgumentOutOfRangeException639()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    xiphComment = this.ConstructorTest01(byteVector);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest01ThrowsArgumentOutOfRangeException63901()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    xiphComment = this.ConstructorTest01(byteVector);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
[PexRaisedException(typeof(OverflowException))]
public void ConstructorTest01ThrowsOverflowException47()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[6];
    bs[3] = (byte)128;
    byteVector = new ByteVector(bs, 6);
    xiphComment = this.ConstructorTest01(byteVector);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest01ThrowsArgumentOutOfRangeException880()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[6];
    bs[0] = (byte)3;
    bs[1] = (byte)240;
    bs[2] = (byte)127;
    bs[3] = (byte)127;
    byteVector = new ByteVector(bs, 6);
    xiphComment = this.ConstructorTest01(byteVector);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
[PexRaisedException(typeof(OverflowException))]
public void ConstructorTest01ThrowsOverflowException931()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[5];
    bs[0] = (byte)252;
    bs[1] = (byte)byte.MaxValue;
    bs[2] = (byte)byte.MaxValue;
    bs[3] = (byte)127;
    byteVector = new ByteVector(bs, 5);
    xiphComment = this.ConstructorTest01(byteVector);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest01ThrowsArgumentOutOfRangeException480()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[6];
    bs[0] = (byte)2;
    byteVector = new ByteVector(bs, 6);
    xiphComment = this.ConstructorTest01(byteVector);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest01ThrowsArgumentOutOfRangeException48001()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 4);
    xiphComment = this.ConstructorTest01(byteVector);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void ConstructorTest01714()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[8];
    byteVector = new ByteVector(bs, 8);
    xiphComment = this.ConstructorTest01(byteVector);
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}
	}
}
