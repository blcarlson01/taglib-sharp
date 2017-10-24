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
public void ReplayGainTrackPeakSetTest725()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[11];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 9);
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = (IPicture[])null;
    this.ReplayGainTrackPeakSetTest(xiphComment, 0);
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("\0", xiphComment.VendorId);
}

[TestMethod]
[PexGeneratedBy(typeof(XiphCommentTest))]
public void ReplayGainTrackPeakSetTest582()
{
    ByteVector byteVector;
    XiphComment xiphComment;
    byte[] bs = new byte[9];
    byteVector = new ByteVector(bs, 8);
    IPicture[] iPictures = new IPicture[9];
    xiphComment = new XiphComment(byteVector);
    xiphComment.Pictures = iPictures;
    this.ReplayGainTrackPeakSetTest(xiphComment, double.NaN);
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>("", xiphComment.VendorId);
}
	}
}
