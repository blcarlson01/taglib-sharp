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
public void AbstractGetTest187()
{
    EBMLreader eBMLreader;
    bool b;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    b = this.AbstractGetTest(eBMLreader);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLreader);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLreader.ID);
    Assert.IsNull(eBMLreader.Parent);
    Assert.AreEqual<ulong>(0uL, eBMLreader.Size);
    Assert.AreEqual<ulong>(0uL, eBMLreader.DataSize);
    Assert.AreEqual<ulong>(0uL, eBMLreader.DataOffset);
    Assert.AreEqual<ulong>(0uL, eBMLreader.Offset);
    Assert.AreEqual<bool>(true, eBMLreader.Abstract);
}
	}
}
