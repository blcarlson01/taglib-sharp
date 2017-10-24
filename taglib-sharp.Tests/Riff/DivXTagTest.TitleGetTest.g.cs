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
public void TitleGetTest616()
{
    ByteVector byteVector;
    DivXTag divXTag;
    string s;
    byte[] bs = new byte[136];
    bs[122] = (byte)68;
    bs[123] = (byte)73;
    bs[124] = (byte)86;
    bs[125] = (byte)88;
    bs[126] = (byte)84;
    bs[sbyte.MaxValue] = (byte)65;
    bs[128] = (byte)71;
    byteVector = new ByteVector(bs, 129);
    divXTag = new DivXTag(byteVector);
    s = this.TitleGetTest(divXTag);
    Assert.AreEqual<string>(new string('\0', 32), s);
    Assert.IsNotNull((object)divXTag);
}
	}
}
