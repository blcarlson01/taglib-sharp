using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Riff.Tests
{
	public partial class AviAudioStreamTest
	{

[TestMethod]
[PexGeneratedBy(typeof(AviAudioStreamTest))]
public void ConstructorTest481()
{
    AviAudioStream aviAudioStream;
    aviAudioStream = this.ConstructorTest(default(AviStreamHeader));
    Assert.IsNotNull((object)aviAudioStream);
    Assert.IsNull(((AviStream)aviAudioStream).Header.Type);
    Assert.IsNull(((AviStream)aviAudioStream).Header.Handler);
    Assert.AreEqual<uint>(0u, ((AviStream)aviAudioStream).Header.Flags);
    Assert.AreEqual<uint>(0u, ((AviStream)aviAudioStream).Header.Priority);
    Assert.AreEqual<uint>(0u, ((AviStream)aviAudioStream).Header.InitialFrames);
    Assert.AreEqual<uint>(0u, ((AviStream)aviAudioStream).Header.Scale);
    Assert.AreEqual<uint>(0u, ((AviStream)aviAudioStream).Header.Rate);
    Assert.AreEqual<uint>(0u, ((AviStream)aviAudioStream).Header.Start);
    Assert.AreEqual<uint>(0u, ((AviStream)aviAudioStream).Header.Length);
    Assert.AreEqual<uint>
        (0u, ((AviStream)aviAudioStream).Header.SuggestedBufferSize);
    Assert.AreEqual<uint>(0u, ((AviStream)aviAudioStream).Header.Quality);
    Assert.AreEqual<uint>(0u, ((AviStream)aviAudioStream).Header.SampleSize);
    Assert.AreEqual<ushort>((ushort)0, ((AviStream)aviAudioStream).Header.Left);
    Assert.AreEqual<ushort>((ushort)0, ((AviStream)aviAudioStream).Header.Top);
    Assert.AreEqual<ushort>((ushort)0, ((AviStream)aviAudioStream).Header.Right);
    Assert.AreEqual<ushort>((ushort)0, ((AviStream)aviAudioStream).Header.Bottom);
    Assert.IsNull(((AviStream)aviAudioStream).Codec);
}
	}
}
