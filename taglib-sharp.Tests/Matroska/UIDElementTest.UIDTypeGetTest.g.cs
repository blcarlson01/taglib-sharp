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
	public partial class UIDElementTest
	{

[TestMethod]
[PexGeneratedBy(typeof(UIDElementTest))]
public void UIDTypeGetTest102()
{
    UIDElement uIDElement;
    MatroskaID u;
    uIDElement = new UIDElement((MatroskaID)0u, 0uL);
    u = this.UIDTypeGetTest(uIDElement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, u);
    Assert.IsNotNull((object)uIDElement);
    Assert.AreEqual<ulong>(8073874034066044584uL, uIDElement.UID);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, uIDElement.UIDType);
}
	}
}
