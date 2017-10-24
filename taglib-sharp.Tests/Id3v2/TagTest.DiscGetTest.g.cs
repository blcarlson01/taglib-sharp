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
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void DiscGetTest794()
{
    ByteVector byteVector;
    Tag tag;
    uint u;
    byte[] bs = new byte[13];
    bs[0] = (byte)73;
    bs[1] = (byte)68;
    bs[2] = (byte)51;
    bs[3] = (byte)2;
    byteVector = new ByteVector(bs, 12);
    tag = new Tag(byteVector);
    tag.PerformersRole = (string[])null;
    u = this.DiscGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
}
	}
}
