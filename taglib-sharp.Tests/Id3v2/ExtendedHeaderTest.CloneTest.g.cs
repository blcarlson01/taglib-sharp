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
public void CloneTest148()
{
    ByteVector byteVector;
    ExtendedHeader extendedHeader;
    ExtendedHeader extendedHeader1;
    byte[] bs = new byte[7];
    byteVector = new ByteVector(bs, 6);
    extendedHeader = new ExtendedHeader(byteVector, (byte)0);
    extendedHeader1 = this.CloneTest(extendedHeader);
    Assert.IsNotNull((object)extendedHeader1);
    Assert.AreEqual<uint>(0u, extendedHeader1.Size);
    Assert.IsNotNull((object)extendedHeader);
    Assert.AreEqual<uint>(0u, extendedHeader.Size);
}
	}
}
