using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;
using TagLib;
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
	public partial class StringIFDEntryTest
	{

[TestMethod]
[PexGeneratedBy(typeof(StringIFDEntryTest))]
public void RenderTest612()
{
    ByteVector byteVector;
    StringIFDEntry s0 = new StringIFDEntry((ushort)0, (string)null);
    ushort w = (ushort)0;
    uint u = 0u;
    byteVector = this.RenderTest(s0, false, 0u, out w, out u);
    Assert.IsNotNull((object)byteVector);
    Assert.AreEqual<bool>(false, byteVector.IsSynchronized);
    Assert.IsNotNull(byteVector.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector.SyncRoot, (object)byteVector));
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<ushort>((ushort)0, s0.Tag);
    Assert.AreEqual<string>((string)null, s0.Value);
    Assert.AreEqual<ushort>((ushort)2, w);
    Assert.AreEqual<uint>(1u, u);
}

[TestMethod]
[PexGeneratedBy(typeof(StringIFDEntryTest))]
public void RenderTest484()
{
    ByteVector byteVector;
    StringIFDEntry s0 = new StringIFDEntry((ushort)0, "");
    ushort w = (ushort)0;
    uint u = 0u;
    byteVector = this.RenderTest(s0, false, 0u, out w, out u);
    Assert.IsNotNull((object)byteVector);
    Assert.AreEqual<bool>(false, byteVector.IsSynchronized);
    Assert.IsNotNull(byteVector.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector.SyncRoot, (object)byteVector));
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<ushort>((ushort)0, s0.Tag);
    Assert.AreEqual<string>("", s0.Value);
    Assert.AreEqual<ushort>((ushort)2, w);
    Assert.AreEqual<uint>(1u, u);
}
	}
}
