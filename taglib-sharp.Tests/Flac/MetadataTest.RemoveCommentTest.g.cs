using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
public void RemoveCommentTest803()
{
    Metadata metadata;
    Block[] blocks = new Block[0];
    metadata = new Metadata((IEnumerable<Block>)blocks);
    this.RemoveCommentTest(metadata);
    Assert.IsNotNull((object)metadata);
}
	}
}
