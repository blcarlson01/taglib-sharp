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
public void ConstructorTest02ThrowsArgumentNullException668()
{
    UserUrlLinkFrame userUrlLinkFrame;
    userUrlLinkFrame = this.ConstructorTest02((ByteVector)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException945()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException330()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException94501()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException683()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException536()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
public void ConstructorTest02849()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[6];
    byteVector = new ByteVector(bs, 6);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)2);
    Assert.IsNotNull((object)userUrlLinkFrame);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException258()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
public void ConstructorTest02687()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[10];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 10);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)3);
    Assert.IsNotNull((object)userUrlLinkFrame);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException25801()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[10];
    bs[0] = (byte)96;
    bs[1] = (byte)3;
    bs[2] = (byte)3;
    bs[3] = (byte)3;
    bs[4] = (byte)3;
    bs[5] = (byte)3;
    bs[6] = (byte)3;
    bs[7] = (byte)3;
    bs[9] = (byte)128;
    byteVector = new ByteVector(bs, 10);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException188()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)4);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
public void ConstructorTest02741()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 10);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)4);
    Assert.IsNotNull((object)userUrlLinkFrame);
}

[TestMethod]
[PexGeneratedBy(typeof(UserUrlLinkFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException670()
{
    ByteVector byteVector;
    UserUrlLinkFrame userUrlLinkFrame;
    byte[] bs = new byte[10];
    bs[0] = (byte)97;
    bs[9] = (byte)32;
    byteVector = new ByteVector(bs, 10);
    userUrlLinkFrame = this.ConstructorTest02(byteVector, (byte)3);
}
	}
}
