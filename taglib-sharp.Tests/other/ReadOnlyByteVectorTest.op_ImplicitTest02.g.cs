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
public void op_ImplicitTest02790()
{
    ReadOnlyByteVector readOnlyByteVector;
    readOnlyByteVector = this.op_ImplicitTest02((string)null);
    Assert.IsNotNull((object)readOnlyByteVector);
    Assert.AreEqual<bool>(false, ((ByteVector)readOnlyByteVector).IsSynchronized);
    Assert.IsNotNull(((ByteVector)readOnlyByteVector).SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((ByteVector)readOnlyByteVector).SyncRoot, (object)readOnlyByteVector));
}

[TestMethod]
[PexGeneratedBy(typeof(ReadOnlyByteVectorTest))]
public void op_ImplicitTest0277()
{
    ReadOnlyByteVector readOnlyByteVector;
    readOnlyByteVector = this.op_ImplicitTest02("");
    Assert.IsNotNull((object)readOnlyByteVector);
    Assert.AreEqual<bool>(false, ((ByteVector)readOnlyByteVector).IsSynchronized);
    Assert.IsNotNull(((ByteVector)readOnlyByteVector).SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((ByteVector)readOnlyByteVector).SyncRoot, (object)readOnlyByteVector));
}
	}
}
