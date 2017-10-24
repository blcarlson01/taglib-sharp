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
public void TitleSetTest240()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[14];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 12);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.TitleSetTest(xiphComment, (string)null);
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("\0", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void TitleSetTest604()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[9];
    byteVector = new ByteVector(bs, 8);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.TitleSetTest(xiphComment, "");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void TitleSetTest819()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[9];
    byteVector = new ByteVector(bs, 8);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.TitleSetTest(xiphComment, "\0");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void TitleSetTest525()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 9);
    IPicture[] iPictures = new IPicture[10];
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = iPictures;
    this.TitleSetTest(xiphComment, " ﻿﻿");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void TitleSetTest445()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[9];
    byteVector = new ByteVector(bs, 8);
    IPicture[] iPictures = new IPicture[9];
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = iPictures;
    this.TitleSetTest(xiphComment, "\0﻿");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void TitleSetTest990()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[9];
    byteVector = new ByteVector(bs, 8);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.TitleSetTest(xiphComment, "\0﻿﻿");
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}
	}
}
