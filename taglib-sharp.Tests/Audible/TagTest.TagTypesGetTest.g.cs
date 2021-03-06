using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Audible;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Audible.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TagTypesGetTest485()
{
    ByteVector byteVector;
    Tag tag;
    TagTypes u;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    tag = new Tag(byteVector);
    u = this.TagTypesGetTest(tag);
    Assert.AreEqual<TagTypes>(TagTypes.AudibleMetadata, u);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TagTypesGetTest48501()
{
    ByteVector byteVector;
    Tag tag;
    TagTypes u;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    tag = new Tag(byteVector);
    u = this.TagTypesGetTest(tag);
    Assert.AreEqual<TagTypes>(TagTypes.AudibleMetadata, u);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TagTypesGetTest48502()
{
    ByteVector byteVector;
    Tag tag;
    TagTypes u;
    byte[] bs = new byte[8];
    bs[3] = (byte)1;
    byteVector = new ByteVector(bs, 8);
    tag = new Tag(byteVector);
    u = this.TagTypesGetTest(tag);
    Assert.AreEqual<TagTypes>(TagTypes.AudibleMetadata, u);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TagTypesGetTest48503()
{
    ByteVector byteVector;
    Tag tag;
    TagTypes u;
    byte[] bs = new byte[8];
    byteVector = new ByteVector(bs, 8);
    tag = new Tag(byteVector);
    u = this.TagTypesGetTest(tag);
    Assert.AreEqual<TagTypes>(TagTypes.AudibleMetadata, u);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TagTypesGetTest48504()
{
    ByteVector byteVector;
    Tag tag;
    TagTypes u;
    byte[] bs = new byte[10];
    bs[3] = (byte)1;
    byteVector = new ByteVector(bs, 9);
    tag = new Tag(byteVector);
    u = this.TagTypesGetTest(tag);
    Assert.AreEqual<TagTypes>(TagTypes.AudibleMetadata, u);
    Assert.IsNotNull((object)tag);
}
	}
}
