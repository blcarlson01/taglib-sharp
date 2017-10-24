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
	public partial class TermsOfUseFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest02ThrowsArgumentNullException68()
{
    TermsOfUseFrame termsOfUseFrame;
    termsOfUseFrame = this.ConstructorTest02((ByteVector)null, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException90()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException925()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest02ThrowsArgumentException9001()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException822()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)0);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException256()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException63()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[6];
    byteVector = new ByteVector(bs, 6);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)2);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException826()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException223()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[10];
    bs[0] = (byte)64;
    byteVector = new ByteVector(bs, 10);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException707()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[10];
    bs[0] = (byte)68;
    bs[9] = (byte)32;
    byteVector = new ByteVector(bs, 10);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException82601()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[10];
    bs[1] = (byte)3;
    bs[2] = (byte)3;
    bs[3] = (byte)3;
    bs[4] = (byte)3;
    bs[5] = (byte)3;
    bs[6] = (byte)3;
    bs[7] = (byte)3;
    bs[9] = (byte)128;
    byteVector = new ByteVector(bs, 10);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException786()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[10];
    bs[0] = (byte)97;
    bs[1] = (byte)3;
    bs[2] = (byte)3;
    bs[3] = (byte)3;
    bs[4] = (byte)3;
    bs[5] = (byte)3;
    bs[6] = (byte)3;
    bs[7] = (byte)3;
    bs[9] = (byte)64;
    byteVector = new ByteVector(bs, 10);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)3);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException740()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)4);
}

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void ConstructorTest02ThrowsCorruptFileException627()
{
    ByteVector byteVector;
    TermsOfUseFrame termsOfUseFrame;
    byte[] bs = new byte[10];
    byteVector = new ByteVector(bs, 10);
    termsOfUseFrame = this.ConstructorTest02(byteVector, (byte)4);
}
	}
}
