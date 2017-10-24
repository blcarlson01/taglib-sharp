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
	public partial class UnsynchronisedLyricsFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(UnsynchronisedLyricsFrameTest))]
public void DescriptionSetTest894()
{
    UnsynchronisedLyricsFrame unsynchronisedLyricsFrame;
    unsynchronisedLyricsFrame =
      new UnsynchronisedLyricsFrame((string)null, (string)null, StringType.Latin1);
    unsynchronisedLyricsFrame.Text = (string)null;
    ((Frame)unsynchronisedLyricsFrame).GroupId = (short)64;
    ((Frame)unsynchronisedLyricsFrame).EncryptionId = (short)256;
    this.DescriptionSetTest(unsynchronisedLyricsFrame, (string)null);
    Assert.IsNotNull((object)unsynchronisedLyricsFrame);
    Assert.AreEqual<StringType>
        (StringType.Latin1, unsynchronisedLyricsFrame.TextEncoding);
    Assert.AreEqual<string>("", unsynchronisedLyricsFrame.Description);
    Assert.AreEqual<string>("", unsynchronisedLyricsFrame.Text);
}
	}
}
