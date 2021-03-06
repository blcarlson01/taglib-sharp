using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
	public partial class ByteIFDEntryTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ByteIFDEntryTest))]
public void ConstructorTest359()
{
    ByteIFDEntry byteIFDEntry;
    byteIFDEntry = this.ConstructorTest((ushort)32, (byte)0);
    Assert.IsNotNull((object)byteIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, byteIFDEntry.Tag);
    Assert.AreEqual<byte>((byte)0, byteIFDEntry.Value);
}
	}
}
