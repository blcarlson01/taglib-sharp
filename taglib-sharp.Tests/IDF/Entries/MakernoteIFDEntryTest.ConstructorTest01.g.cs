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
	public partial class MakernoteIFDEntryTest
	{

[TestMethod]
[PexGeneratedBy(typeof(MakernoteIFDEntryTest))]
public void ConstructorTest01637()
{
    MakernoteIFDEntry makernoteIFDEntry;
    makernoteIFDEntry =
      this.ConstructorTest01((ushort)64, (IFDStructure)null, MakernoteType.Unknown);
    Assert.IsNotNull((object)makernoteIFDEntry);
    Assert.AreEqual<ushort>((ushort)64, makernoteIFDEntry.Tag);
    Assert.AreEqual<MakernoteType>
        (MakernoteType.Unknown, makernoteIFDEntry.MakernoteType);
    Assert.IsNull(makernoteIFDEntry.Structure);
}
	}
}
