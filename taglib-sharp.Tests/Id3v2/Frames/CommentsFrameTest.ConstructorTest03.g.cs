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
	public partial class CommentsFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(CommentsFrameTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest03ThrowsArgumentNullException116()
{
    CommentsFrame commentsFrame;
    commentsFrame = this.ConstructorTest03((ByteVector)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(CommentsFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest03ThrowsArgumentException945()
{
    ByteVector byteVector;
    CommentsFrame commentsFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    commentsFrame = this.ConstructorTest03(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(CommentsFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest03ThrowsArgumentException64()
{
    ByteVector byteVector;
    CommentsFrame commentsFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    commentsFrame = this.ConstructorTest03(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(CommentsFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest03ThrowsArgumentException94501()
{
    ByteVector byteVector;
    CommentsFrame commentsFrame;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    commentsFrame = this.ConstructorTest03(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(CommentsFrameTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorTest03ThrowsCorruptFileException426()
{
    ByteVector byteVector;
    CommentsFrame commentsFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    commentsFrame = this.ConstructorTest03(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(CommentsFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest03ThrowsCorruptFileException99()
{
    ByteVector byteVector;
    CommentsFrame commentsFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    commentsFrame = this.ConstructorTest03(byteVector, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(CommentsFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest03ThrowsCorruptFileException280()
{
    ByteVector byteVector;
    CommentsFrame commentsFrame;
    byte[] bs = new byte[6];
    byteVector = new ByteVector(bs, 6);
    commentsFrame = this.ConstructorTest03(byteVector, (byte)2);
}
	}
}
