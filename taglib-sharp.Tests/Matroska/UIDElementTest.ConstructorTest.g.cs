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
public void ConstructorTest511()
{
    UIDElement uIDElement;
    uIDElement = this.ConstructorTest((MatroskaID)0u, 0uL);
    Assert.IsNotNull((object)uIDElement);
    Assert.AreEqual<ulong>(6269378008861922814uL, uIDElement.UID);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, uIDElement.UIDType);
}

[TestMethod]
[PexGeneratedBy(typeof(UIDElementTest))]
public void ConstructorTest338()
{
    UIDElement uIDElement;
    uIDElement = this.ConstructorTest(MatroskaID.TagChapterUID, 0uL);
    Assert.IsNotNull((object)uIDElement);
    Assert.AreEqual<ulong>(6715944992144524741uL, uIDElement.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagChapterUID, uIDElement.UIDType);
}

[TestMethod]
[PexGeneratedBy(typeof(UIDElementTest))]
public void ConstructorTest843()
{
    UIDElement uIDElement;
    uIDElement = this.ConstructorTest(MatroskaID.TagEditionUID, 0uL);
    Assert.IsNotNull((object)uIDElement);
    Assert.AreEqual<ulong>(2803674542068635896uL, uIDElement.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagEditionUID, uIDElement.UIDType);
}

[TestMethod]
[PexGeneratedBy(typeof(UIDElementTest))]
public void ConstructorTest500()
{
    UIDElement uIDElement;
    uIDElement = this.ConstructorTest(MatroskaID.TagTrackUID, 0uL);
    Assert.IsNotNull((object)uIDElement);
    Assert.AreEqual<ulong>(6373196748624358074uL, uIDElement.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagTrackUID, uIDElement.UIDType);
}
	}
}
