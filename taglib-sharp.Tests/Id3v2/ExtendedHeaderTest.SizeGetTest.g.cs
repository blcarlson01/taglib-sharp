using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Id3v2.Tests
{
	public partial class ExtendedHeaderTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ExtendedHeaderTest))]
public void SizeGetTest749()
{
    ByteVector byteVector;
    ExtendedHeader extendedHeader;
    uint u;
    byte[] bs = new byte[7];
    byteVector = new ByteVector(bs, 6);
    extendedHeader = new ExtendedHeader(byteVector, (byte)0);
    u = this.SizeGetTest(extendedHeader);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)extendedHeader);
    Assert.AreEqual<uint>(0u, extendedHeader.Size);
}
	}
}
