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
public void CloneTest674()
{
    ByteVector byteVector;
    Tag tag;
    Tag tag1;
    byte[] bs = new byte[13];
    bs[0] = (byte)73;
    bs[1] = (byte)68;
    bs[2] = (byte)51;
    bs[3] = (byte)2;
    byteVector = new ByteVector(bs, 12);
    tag = new Tag(byteVector);
    tag.PerformersRole = (string[])null;
    tag1 = this.CloneTest(tag);
    Assert.IsNotNull((object)tag1);
    Assert.IsNotNull((object)tag);
}
	}
}
