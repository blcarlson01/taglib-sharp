using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using System.Collections.Generic;
using TagLib.Ogg;
using TagLib.Flac;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Flac.Tests
{
	public partial class MetadataTest
	{

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
public void GetCommentTest566()
{
    Metadata metadata;
    XiphComment xiphComment;
    Block[] blocks = new Block[0];
    metadata = new Metadata((IEnumerable<Block>)blocks);
    xiphComment = this.GetCommentTest(metadata, false, (Tag)null);
    Assert.IsNull((object)xiphComment);
    Assert.IsNotNull((object)metadata);
}

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
public void GetCommentTest855()
{
    Metadata metadata;
    XiphComment xiphComment;
    Block[] blocks = new Block[0];
    metadata = new Metadata((IEnumerable<Block>)blocks);
    xiphComment = this.GetCommentTest(metadata, true, (Tag)null);
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>((string)null, xiphComment.VendorId);
    Assert.IsNotNull((object)metadata);
}

[TestMethod]
[PexGeneratedBy(typeof(MetadataTest))]
public void GetCommentTest878()
{
    Metadata metadata;
    XiphComment xiphComment;
    Block[] blocks = new Block[0];
    metadata = new Metadata((IEnumerable<Block>)blocks);
    xiphComment = this.GetCommentTest(metadata, true, (Tag)metadata);
    Assert.IsNotNull((object)xiphComment);
    Assert.AreEqual<string>((string)null, xiphComment.VendorId);
    Assert.IsNotNull((object)metadata);
}
	}
}
