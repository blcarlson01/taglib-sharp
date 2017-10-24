using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Matroska.Tests
{
	public partial class EBMLreaderTest
	{

[TestMethod]
[PexGeneratedBy(typeof(EBMLreaderTest))]
public void OffsetSetTest558()
{
    EBMLreader eBMLreader;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    this.OffsetSetTest(eBMLreader, 0uL);
    Assert.IsNotNull((object)eBMLreader);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLreader.ID);
    Assert.IsNull(eBMLreader.Parent);
    Assert.AreEqual<ulong>(0uL, eBMLreader.Size);
    Assert.AreEqual<ulong>(0uL, eBMLreader.DataSize);
    Assert.AreEqual<ulong>(0uL, eBMLreader.DataOffset);
    Assert.AreEqual<ulong>(0uL, eBMLreader.Offset);
    Assert.AreEqual<bool>(true, eBMLreader.Abstract);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLreaderTest))]
[PexRaisedException(typeof(OverflowException))]
public void OffsetSetTestThrowsOverflowException530()
{
    EBMLreader eBMLreader;
    eBMLreader =
      new EBMLreader((EBMLreader)null, 1230608873056894976uL, (MatroskaID)0u, 0uL);
    this.OffsetSetTest(eBMLreader, 9585911806947229764uL);
}
	}
}
