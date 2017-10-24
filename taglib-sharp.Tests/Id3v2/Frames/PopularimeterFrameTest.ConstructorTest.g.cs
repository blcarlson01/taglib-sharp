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
	public partial class PopularimeterFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
public void ConstructorTest304()
{
    PopularimeterFrame popularimeterFrame;
    popularimeterFrame = this.ConstructorTest((string)null);
    Assert.IsNotNull((object)popularimeterFrame);
    Assert.AreEqual<string>("", popularimeterFrame.User);
    Assert.AreEqual<byte>((byte)0, popularimeterFrame.Rating);
    Assert.AreEqual<ulong>(0uL, popularimeterFrame.PlayCount);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
public void ConstructorTest294()
{
    PopularimeterFrame popularimeterFrame;
    popularimeterFrame = this.ConstructorTest("");
    Assert.IsNotNull((object)popularimeterFrame);
    Assert.AreEqual<string>("", popularimeterFrame.User);
    Assert.AreEqual<byte>((byte)0, popularimeterFrame.Rating);
    Assert.AreEqual<ulong>(0uL, popularimeterFrame.PlayCount);
}
	}
}
