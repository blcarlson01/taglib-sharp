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
	public partial class SShortIFDEntryTest
	{

[TestMethod]
[PexGeneratedBy(typeof(SShortIFDEntryTest))]
public void ConstructorTest891()
{
    SShortIFDEntry sShortIFDEntry;
    sShortIFDEntry = this.ConstructorTest((ushort)32, (ushort)32);
    Assert.IsNotNull((object)sShortIFDEntry);
    Assert.AreEqual<ushort>((ushort)32, sShortIFDEntry.Tag);
    Assert.AreEqual<ushort>((ushort)32, sShortIFDEntry.Value);
}
	}
}
