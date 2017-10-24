using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
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
	public partial class UserUrlLinkFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void GetTestThrowsArgumentNullException728()
{
    UserUrlLinkFrame userUrlLinkFrame;
    userUrlLinkFrame =
      this.GetTest((Tag)null, (string)null, StringType.Latin1, false);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void GetTestThrowsArgumentNullException236()
{
    ByteVector byteVector;
    Tag tag;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[11];
    bs[0] = (byte)73;
    bs[1] = (byte)68;
    bs[2] = (byte)51;
    bs[3] = (byte)2;
    byteVector = new ByteVector(bs, 10);
    tag = new Tag(byteVector);
    tag.PerformersRole = (string[])null;
    userUrlLinkFrame = this.GetTest(tag, (string)null, StringType.Latin1, false);
}
	}
}
