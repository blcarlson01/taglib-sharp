using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Asf.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void DiscSetTest148()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.DiscSetTest(tag, 0u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void DiscSetTest630()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.DiscSetTest(tag, 1u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void DiscSetTest538()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.DiscSetTest(tag, 260u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}
	}
}
