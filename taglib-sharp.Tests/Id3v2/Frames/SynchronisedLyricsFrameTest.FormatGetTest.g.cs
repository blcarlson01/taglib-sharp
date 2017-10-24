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
	public partial class SynchronisedLyricsFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(SynchronisedLyricsFrameTest))]
public void FormatGetTest130()
{
    SynchronisedLyricsFrame synchronisedLyricsFrame;
    TimestampFormat i;
    synchronisedLyricsFrame = new SynchronisedLyricsFrame
                                  ((string)null, (string)null, SynchedTextType.Other, StringType.Latin1);
    synchronisedLyricsFrame.Format = TimestampFormat.Unknown;
    ((Frame)synchronisedLyricsFrame).GroupId = (short)32;
    ((Frame)synchronisedLyricsFrame).EncryptionId = (short)256;
    i = this.FormatGetTest(synchronisedLyricsFrame);
    Assert.AreEqual<TimestampFormat>(TimestampFormat.Unknown, i);
    Assert.IsNotNull((object)synchronisedLyricsFrame);
    Assert.AreEqual<StringType>
        (StringType.Latin1, synchronisedLyricsFrame.TextEncoding);
    Assert.AreEqual<string>((string)null, synchronisedLyricsFrame.Description);
    Assert.AreEqual<TimestampFormat>
        (TimestampFormat.Unknown, synchronisedLyricsFrame.Format);
    Assert.AreEqual<SynchedTextType>
        (SynchedTextType.Other, synchronisedLyricsFrame.Type);
    Assert.IsNotNull(synchronisedLyricsFrame.Text);
    Assert.AreEqual<int>(0, synchronisedLyricsFrame.Text.Length);
}
	}
}
