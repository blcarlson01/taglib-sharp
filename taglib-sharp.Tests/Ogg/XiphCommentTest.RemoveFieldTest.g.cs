using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg;
using TagLib;
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
public void RemoveFieldTestThrowsArgumentNullException522()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[14];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 12);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.RemoveFieldTest(xiphComment, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void RemoveFieldTest312()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[9];
    byteVector = new ByteVector(bs, 8);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.RemoveFieldTest(xiphComment, "");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void RemoveFieldTest694()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 9);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.RemoveFieldTest(xiphComment, "\0");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void RemoveFieldTest304()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 8);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.RemoveFieldTest(xiphComment, "h");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void RemoveFieldTest681()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[9];
    byteVector = new ByteVector(bs, 8);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.RemoveFieldTest(xiphComment, "\0\0");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void RemoveFieldTest921()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 9);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.RemoveFieldTest(xiphComment, "COVERART");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}
	}
}
