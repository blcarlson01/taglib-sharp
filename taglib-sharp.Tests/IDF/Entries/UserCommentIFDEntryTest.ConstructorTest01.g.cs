using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.IFD.Entries;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.IFD.Entries.Tests
{
	public partial class UserCommentIFDEntryTest
	{

[TestMethod]
[PexGeneratedBy(typeof(UserCommentIFDEntryTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConstructorTest01ThrowsNullReferenceException614()
{
    UserCommentIFDEntry userCommentIFDEntry;
    userCommentIFDEntry =
      this.ConstructorTest01((ushort)32, (ByteVector)null, (File)null);
}

[TestMethod]
[PexGeneratedBy(typeof(UserCommentIFDEntryTest))]
public void ConstructorTest01102()
{
    ByteVector byteVector;
    UserCommentIFDEntry userCommentIFDEntry;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 1);
    userCommentIFDEntry = this.ConstructorTest01((ushort)32, byteVector, (File)null);
    Assert.IsNotNull((object)userCommentIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, userCommentIFDEntry.Tag);
    Assert.AreEqual<string>("", userCommentIFDEntry.Value);
}

[TestMethod]
[PexGeneratedBy(typeof(UserCommentIFDEntryTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConstructorTest01ThrowsNullReferenceException809()
{
    ByteVector byteVector;
    UserCommentIFDEntry userCommentIFDEntry;
    byte[] bs = new byte[6];
    bs[0] = (byte)1;
    byteVector = new ByteVector(bs, 5);
    userCommentIFDEntry = this.ConstructorTest01((ushort)32, byteVector, (File)null);
}

[TestMethod]
[PexGeneratedBy(typeof(UserCommentIFDEntryTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConstructorTest01ThrowsNullReferenceException80901()
{
    ByteVector byteVector;
    UserCommentIFDEntry userCommentIFDEntry;
    byte[] bs = new byte[6];
    byteVector = new ByteVector(bs, 5);
    userCommentIFDEntry = this.ConstructorTest01((ushort)32, byteVector, (File)null);
}

[TestMethod]
[PexGeneratedBy(typeof(UserCommentIFDEntryTest))]
public void ConstructorTest0110201()
{
    ByteVector byteVector;
    UserCommentIFDEntry userCommentIFDEntry;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    userCommentIFDEntry = this.ConstructorTest01((ushort)32, byteVector, (File)null);
    Assert.IsNotNull((object)userCommentIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, userCommentIFDEntry.Tag);
    Assert.AreEqual<string>("", userCommentIFDEntry.Value);
}

[TestMethod]
[PexGeneratedBy(typeof(UserCommentIFDEntryTest))]
public void ConstructorTest0110202()
{
    ByteVector byteVector;
    UserCommentIFDEntry userCommentIFDEntry;
    byte[] bs = new byte[9];
    byteVector = new ByteVector(bs, 8);
    userCommentIFDEntry = this.ConstructorTest01((ushort)32, byteVector, (File)null);
    Assert.IsNotNull((object)userCommentIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, userCommentIFDEntry.Tag);
    Assert.AreEqual<string>("", userCommentIFDEntry.Value);
}

[TestMethod]
[PexGeneratedBy(typeof(UserCommentIFDEntryTest))]
public void ConstructorTest01108()
{
    ByteVector byteVector;
    UserCommentIFDEntry userCommentIFDEntry;
    byte[] bs = new byte[15];
    bs[8] = (byte)1;
    bs[9] = (byte)1;
    byteVector = new ByteVector(bs, 11);
    userCommentIFDEntry = this.ConstructorTest01((ushort)32, byteVector, (File)null);
    Assert.IsNotNull((object)userCommentIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, userCommentIFDEntry.Tag);
    Assert.AreEqual<string>("", userCommentIFDEntry.Value);
}

[TestMethod]
[PexGeneratedBy(typeof(UserCommentIFDEntryTest))]
public void ConstructorTest01107()
{
    ByteVector byteVector;
    UserCommentIFDEntry userCommentIFDEntry;
    byte[] bs = new byte[12];
    bs[8] = (byte)1;
    byteVector = new ByteVector(bs, 9);
    userCommentIFDEntry = this.ConstructorTest01((ushort)32, byteVector, (File)null);
    Assert.IsNotNull((object)userCommentIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, userCommentIFDEntry.Tag);
    Assert.AreEqual<string>("", userCommentIFDEntry.Value);
}

[TestMethod]
[PexGeneratedBy(typeof(UserCommentIFDEntryTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConstructorTest01ThrowsNullReferenceException80902()
{
    ByteVector byteVector;
    UserCommentIFDEntry userCommentIFDEntry;
    byte[] bs = new byte[11];
    bs[0] = (byte)65;
    bs[1] = (byte)83;
    bs[2] = (byte)67;
    byteVector = new ByteVector(bs, 10);
    userCommentIFDEntry = this.ConstructorTest01((ushort)32, byteVector, (File)null);
}
	}
}
