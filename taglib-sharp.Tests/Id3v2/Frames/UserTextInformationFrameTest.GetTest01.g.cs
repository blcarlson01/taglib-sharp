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
	public partial class UserTextInformationFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void GetTest01ThrowsArgumentNullException999()
{
    UserTextInformationFrame userTextInformationFrame;
    userTextInformationFrame =
      this.GetTest01((Tag)null, (string)null, StringType.Latin1, false);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void GetTest01ThrowsArgumentNullException43()
{
    ByteVector byteVector;
    Tag tag;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[11];
    bs[0] = (byte)73;
    bs[1] = (byte)68;
    bs[2] = (byte)51;
    bs[3] = (byte)2;
    byteVector = new ByteVector(bs, 10);
    tag = new Tag(byteVector);
    tag.PerformersRole = (string[])null;
    userTextInformationFrame =
      this.GetTest01(tag, (string)null, StringType.Latin1, false);
}
	}
}
