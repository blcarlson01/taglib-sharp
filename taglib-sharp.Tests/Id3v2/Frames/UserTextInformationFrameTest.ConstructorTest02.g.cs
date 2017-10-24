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
public void ConstructorTest02ThrowsArgumentNullException664()
{
    UserTextInformationFrame userTextInformationFrame;
    userTextInformationFrame = this.ConstructorTest02((ByteVector)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException8()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException417()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException801()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException569()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException346()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest02ThrowsArgumentOutOfRangeException225()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[6];
    byteVector = new ByteVector(bs, 6);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException456()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest02ThrowsArgumentOutOfRangeException241()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 10);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException45601()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[10];
    bs[0] = (byte)68;
    bs[1] = (byte)3;
    bs[2] = (byte)3;
    bs[3] = (byte)3;
    bs[4] = (byte)3;
    bs[5] = (byte)3;
    bs[6] = (byte)3;
    bs[7] = (byte)3;
    bs[9] = (byte)128;
    byteVector = new ByteVector(bs, 10);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException610()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)4);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException259()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[10];
    bs[1] = (byte)3;
    bs[2] = (byte)3;
    bs[3] = (byte)3;
    bs[4] = (byte)3;
    bs[5] = (byte)3;
    bs[6] = (byte)3;
    bs[7] = (byte)3;
    bs[9] = (byte)64;
    byteVector = new ByteVector(bs, 10);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest02ThrowsArgumentOutOfRangeException723()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 10);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)4);
}

[TestMethod]
[PexGeneratedBy(typeof(UserTextInformationFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException132()
{
    ByteVector byteVector;
    UserTextInformationFrame userTextInformationFrame;
    byte[] bs = new byte[10];
    bs[0] = (byte)89;
    bs[1] = (byte)3;
    bs[2] = (byte)3;
    bs[3] = (byte)3;
    bs[4] = (byte)3;
    bs[5] = (byte)3;
    bs[6] = (byte)3;
    bs[7] = (byte)3;
    bs[9] = (byte)32;
    byteVector = new ByteVector(bs, 10);
    userTextInformationFrame = this.ConstructorTest02(byteVector, (byte)3);
}
	}
}
