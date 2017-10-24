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
public void AlbumArtistsGetTest385()
{
    ByteVector byteVector;
    Tag tag;
    string[] ss;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    tag = new Tag(byteVector);
    ss = this.AlbumArtistsGetTest(tag);
    Assert.IsNull((object)ss);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsGetTest38501()
{
    ByteVector byteVector;
    Tag tag;
    string[] ss;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    tag = new Tag(byteVector);
    ss = this.AlbumArtistsGetTest(tag);
    Assert.IsNull((object)ss);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsGetTest38502()
{
    ByteVector byteVector;
    Tag tag;
    string[] ss;
    byte[] bs = new byte[12];
    bs[3] = (byte)2;
    byteVector = new ByteVector(bs, 10);
    tag = new Tag(byteVector);
    ss = this.AlbumArtistsGetTest(tag);
    Assert.IsNull((object)ss);
    Assert.IsNotNull((object)tag);
}
	}
}
