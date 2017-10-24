using TagLib;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Id3v2.Tests
{
	public partial class TermsOfUseFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void GetPreferredTestThrowsNullReferenceException985()
{
    TermsOfUseFrame termsOfUseFrame;
    termsOfUseFrame = this.GetPreferredTest((Tag)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
public void GetPreferredTest765()
{
    ByteVector byteVector;
    Tag tag;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[11];
    bs[0] = (byte)73;
    bs[1] = (byte)68;
    bs[2] = (byte)51;
    bs[3] = (byte)2;
    byteVector = new ByteVector(bs, 10);
    tag = new Tag(byteVector);
    tag.PerformersRole = (string[])null;
    termsOfUseFrame = this.GetPreferredTest(tag, (string)null);
    Assert.IsNull((object)termsOfUseFrame);
}
	}
}
