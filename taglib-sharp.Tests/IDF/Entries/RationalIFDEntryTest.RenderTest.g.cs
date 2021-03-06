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
	public partial class RationalIFDEntryTest
	{

[TestMethod]
[PexGeneratedBy(typeof(RationalIFDEntryTest))]
public void RenderTest506()
{
    RationalIFDEntry rationalIFDEntry;
    ByteVector byteVector;
    rationalIFDEntry = new RationalIFDEntry((ushort)32, default(Rational));
    ushort w = (ushort)0;
    uint u = 0u;
    byteVector = this.RenderTest(rationalIFDEntry, false, 0u, out w, out u);
    Assert.IsNotNull((object)byteVector);
    Assert.AreEqual<bool>(false, byteVector.IsSynchronized);
    Assert.IsNotNull(byteVector.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector.SyncRoot, (object)byteVector));
    Assert.IsNotNull((object)rationalIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, rationalIFDEntry.Tag);
    Assert.AreEqual<uint>(0u, rationalIFDEntry.Value.Numerator);
    Assert.AreEqual<uint>(0u, rationalIFDEntry.Value.Denominator);
    Assert.AreEqual<ushort>((ushort)5, w);
    Assert.AreEqual<uint>(1u, u);
}

[TestMethod]
[PexGeneratedBy(typeof(RationalIFDEntryTest))]
public void RenderTest816()
{
    RationalIFDEntry rationalIFDEntry;
    ByteVector byteVector;
    rationalIFDEntry = new RationalIFDEntry((ushort)32, default(Rational));
    ushort w = (ushort)0;
    uint u = 0u;
    byteVector = this.RenderTest(rationalIFDEntry, true, 0u, out w, out u);
    Assert.IsNotNull((object)byteVector);
    Assert.AreEqual<bool>(false, byteVector.IsSynchronized);
    Assert.IsNotNull(byteVector.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector.SyncRoot, (object)byteVector));
    Assert.IsNotNull((object)rationalIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, rationalIFDEntry.Tag);
    Assert.AreEqual<uint>(0u, rationalIFDEntry.Value.Numerator);
    Assert.AreEqual<uint>(0u, rationalIFDEntry.Value.Denominator);
    Assert.AreEqual<ushort>((ushort)5, w);
    Assert.AreEqual<uint>(1u, u);
}
	}
}
