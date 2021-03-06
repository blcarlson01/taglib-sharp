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
public void UIDGetTest2()
{
    UIDElement uIDElement;
    ulong l;
    uIDElement = new UIDElement((MatroskaID)0u, 0uL);
    l = this.UIDGetTest(uIDElement);
    Assert.AreEqual<ulong>(6539801424460427136uL, l);
    Assert.IsNotNull((object)uIDElement);
    Assert.AreEqual<ulong>(6539801424460427136uL, uIDElement.UID);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, uIDElement.UIDType);
}
	}
}
