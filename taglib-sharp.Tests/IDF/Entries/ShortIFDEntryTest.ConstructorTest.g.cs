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
	public partial class ShortIFDEntryTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ShortIFDEntryTest))]
public void ConstructorTest466()
{
    ShortIFDEntry shortIFDEntry;
    shortIFDEntry = this.ConstructorTest((ushort)32, (ushort)32);
    Assert.IsNotNull((object)shortIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, shortIFDEntry.Tag);
    Assert.AreEqual<ushort>((ushort)32, shortIFDEntry.Value);
}
	}
}
