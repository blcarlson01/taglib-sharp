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
public void IsCompilationSetTest991()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 8);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.IsCompilationSetTest(xiphComment, false);
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
[Ignore]
[PexDescription("the test state was: duplicate path")]
public void IsCompilationSetTest355()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[15];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 13);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.IsCompilationSetTest(xiphComment, false);
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("\0", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void IsCompilationSetTest368()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 8);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.IsCompilationSetTest(xiphComment, true);
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}
	}
}
