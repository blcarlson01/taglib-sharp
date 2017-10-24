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
	public partial class SynchronisedLyricsFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(SynchronisedLyricsFrameTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void GetPreferredTestThrowsNullReferenceException681()
{
    SynchronisedLyricsFrame synchronisedLyricsFrame;
    synchronisedLyricsFrame = this.GetPreferredTest
                                  ((Tag)null, (string)null, (string)null, SynchedTextType.Other);
}

[TestMethod]
[PexGeneratedBy(typeof(SynchronisedLyricsFrameTest))]
public void GetPreferredTest220()
{
    ByteVector byteVector;
    Tag tag;
    SynchronisedLyricsFrame synchronisedLyricsFrame;
    byte[] bs = new byte[12];
    bs[0] = (byte)73;
    bs[1] = (byte)68;
    bs[2] = (byte)51;
    bs[3] = (byte)2;
    byteVector = new ByteVector(bs, 11);
    tag = new Tag(byteVector);
    tag.PerformersRole = (string[])null;
    synchronisedLyricsFrame =
      this.GetPreferredTest(tag, (string)null, (string)null, SynchedTextType.Other);
    Assert.IsNull((object)synchronisedLyricsFrame);
}
	}
}
