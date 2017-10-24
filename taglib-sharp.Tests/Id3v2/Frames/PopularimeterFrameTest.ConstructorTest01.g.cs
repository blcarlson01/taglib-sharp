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
	public partial class PopularimeterFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest01ThrowsArgumentNullException325()
{
    PopularimeterFrame popularimeterFrame;
    popularimeterFrame = this.ConstructorTest01((ByteVector)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest01ThrowsArgumentException939()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest01ThrowsArgumentException958()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest01ThrowsArgumentException93901()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorTest01ThrowsCorruptFileException259()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest01ThrowsCorruptFileException617()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest01ThrowsCorruptFileException667()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[6];
    byteVector = new ByteVector(bs, 6);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest01ThrowsCorruptFileException935()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest01ThrowsCorruptFileException195()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)4);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest01ThrowsCorruptFileException715()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 10);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest01ThrowsCorruptFileException174()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[10];
    bs[9] = (byte)64;
    byteVector = new ByteVector(bs, 10);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(PopularimeterFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest01ThrowsCorruptFileException489()
{
    ByteVector byteVector;
    PopularimeterFrame popularimeterFrame;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 10);
    popularimeterFrame = this.ConstructorTest01(byteVector, (byte)4);
}
	}
}
