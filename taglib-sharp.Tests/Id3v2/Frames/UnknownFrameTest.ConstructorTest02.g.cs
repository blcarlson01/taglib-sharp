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
	public partial class UnknownFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(UnknownFrameTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest02ThrowsArgumentNullException364()
{
    UnknownFrame unknownFrame;
    unknownFrame = this.ConstructorTest02((ByteVector)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UnknownFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException645()
{
    ByteVector byteVector;
    UnknownFrame unknownFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    unknownFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UnknownFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException924()
{
    ByteVector byteVector;
    UnknownFrame unknownFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    unknownFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(UnknownFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException64501()
{
    ByteVector byteVector;
    UnknownFrame unknownFrame;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    unknownFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UnknownFrameTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException53()
{
    ByteVector byteVector;
    UnknownFrame unknownFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    unknownFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UnknownFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException47()
{
    ByteVector byteVector;
    UnknownFrame unknownFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    unknownFrame = this.ConstructorTest02(byteVector, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(UnknownFrameTest))]
public void ConstructorTest02289()
{
    ByteVector byteVector;
    UnknownFrame unknownFrame;
    byte[] bs = new byte[6];
    byteVector = new ByteVector(bs, 6);
    unknownFrame = this.ConstructorTest02(byteVector, (byte)2);
    Assert.IsNotNull((object)unknownFrame);
    Assert.IsNotNull(unknownFrame.Data);
    Assert.AreEqual<bool>(false, unknownFrame.Data.IsSynchronized);
    Assert.IsNotNull(unknownFrame.Data.SyncRoot);
    Assert.IsTrue
        (object.ReferenceEquals(unknownFrame.Data.SyncRoot, unknownFrame.Data));
}
	}
}
