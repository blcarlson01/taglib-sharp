using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Tests
{
	public partial class ReadOnlyByteVectorTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ReadOnlyByteVectorTest))]
public void ConstructorTest04105()
{
    ReadOnlyByteVector readOnlyByteVector;
    readOnlyByteVector = this.ConstructorTest04((byte[])null);
    Assert.IsNotNull((object)readOnlyByteVector);
    Assert.AreEqual<bool>(false, ((ByteVector)readOnlyByteVector).IsSynchronized);
    Assert.IsNotNull(((ByteVector)readOnlyByteVector).SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((ByteVector)readOnlyByteVector).SyncRoot, (object)readOnlyByteVector));
}

[TestMethod]
[PexGeneratedBy(typeof(ReadOnlyByteVectorTest))]
public void ConstructorTest04506()
{
    ReadOnlyByteVector readOnlyByteVector;
    byte[] bs = new byte[0];
    readOnlyByteVector = this.ConstructorTest04(bs);
    Assert.IsNotNull((object)readOnlyByteVector);
    Assert.AreEqual<bool>(false, ((ByteVector)readOnlyByteVector).IsSynchronized);
    Assert.IsNotNull(((ByteVector)readOnlyByteVector).SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((ByteVector)readOnlyByteVector).SyncRoot, (object)readOnlyByteVector));
}

[TestMethod]
[PexGeneratedBy(typeof(ReadOnlyByteVectorTest))]
public void ConstructorTest04213()
{
    ReadOnlyByteVector readOnlyByteVector;
    byte[] bs = new byte[1];
    readOnlyByteVector = this.ConstructorTest04(bs);
    Assert.IsNotNull((object)readOnlyByteVector);
    Assert.AreEqual<bool>(false, ((ByteVector)readOnlyByteVector).IsSynchronized);
    Assert.IsNotNull(((ByteVector)readOnlyByteVector).SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((ByteVector)readOnlyByteVector).SyncRoot, (object)readOnlyByteVector));
}
	}
}
