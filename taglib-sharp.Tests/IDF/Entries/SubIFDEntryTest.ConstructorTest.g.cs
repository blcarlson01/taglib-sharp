using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;
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
	public partial class SubIFDEntryTest
	{

[TestMethod]
[PexGeneratedBy(typeof(SubIFDEntryTest))]
public void ConstructorTest727()
{
    SubIFDEntry subIFDEntry;
    subIFDEntry =
      this.ConstructorTest((ushort)64, (ushort)32, 0u, (IFDStructure)null);
    Assert.IsNotNull((object)subIFDEntry);
    Assert.AreEqual<ushort>((ushort)64, subIFDEntry.Tag);
    Assert.AreEqual<ushort>((ushort)32, subIFDEntry.Type);
    Assert.AreEqual<uint>(0u, subIFDEntry.Count);
    Assert.IsNull(subIFDEntry.Structure);
}
	}
}
