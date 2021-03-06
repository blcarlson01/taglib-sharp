using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Riff.Tests
{
	public partial class DivXTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void TagTypesGetTest645()
{
    DivXTag divXTag;
    TagTypes u;
    divXTag = DivXTagFactory.Create();
    u = this.TagTypesGetTest(divXTag);
    Assert.AreEqual<TagTypes>(TagTypes.DivX, u);
    Assert.IsNotNull((object)divXTag);
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
public void TagTypesGetTest64501()
{
    ByteVector byteVector;
    DivXTag divXTag;
    TagTypes u;
    byte[] bs = new byte[129];
    bs[121] = (byte)68;
    bs[122] = (byte)73;
    bs[123] = (byte)86;
    bs[124] = (byte)88;
    bs[125] = (byte)84;
    bs[126] = (byte)65;
    bs[sbyte.MaxValue] = (byte)71;
    byteVector = ByteVectorFactory.Create(bs, 128);
    divXTag = DivXTagFactory.Create(byteVector);
    u = this.TagTypesGetTest(divXTag);
    Assert.AreEqual<TagTypes>(TagTypes.DivX, u);
    Assert.IsNotNull((object)divXTag);
}
	}
}
