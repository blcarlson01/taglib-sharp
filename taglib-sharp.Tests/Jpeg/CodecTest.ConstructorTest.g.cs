using Microsoft.Pex.Framework.Generated;
using TagLib;
using TagLib.Image;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Jpeg;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Jpeg.Tests
{
	public partial class CodecTest
	{

[TestMethod]
[PexGeneratedBy(typeof(CodecTest))]
public void ConstructorTest520()
{
    Codec codec;
    codec = this.ConstructorTest(0, 0, 0);
    Assert.IsNotNull((object)codec);
    Assert.AreEqual<int>(0, ((Codec)codec).Duration.Days);
    Assert.AreEqual<int>(0, ((Codec)codec).Duration.Hours);
    Assert.AreEqual<int>(0, ((Codec)codec).Duration.Milliseconds);
    Assert.AreEqual<int>(0, ((Codec)codec).Duration.Minutes);
    Assert.AreEqual<int>(0, ((Codec)codec).Duration.Seconds);
    Assert.AreEqual<MediaTypes>(MediaTypes.Photo, ((Codec)codec).MediaTypes);
    Assert.AreEqual<int>(0, ((Codec)codec).PhotoWidth);
    Assert.AreEqual<int>(0, ((Codec)codec).PhotoHeight);
    Assert.AreEqual<int>(0, ((Codec)codec).PhotoQuality);
}
	}
}
