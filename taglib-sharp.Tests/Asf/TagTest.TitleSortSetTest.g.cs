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
public void TitleSortSetTest704()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.TitleSortSetTest(tag, (string)null);
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
public void TitleSortSetTest35()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.TitleSortSetTest(tag, "");
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
public void TitleSortSetTest221()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.TitleSortSetTest(tag, "\0");
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
public void TitleSortSetTest788()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.TitleSortSetTest(tag, "　");
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
public void TitleSortSetTest669()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.TitleSortSetTest(tag, "\0﻿");
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
public void TitleSortSetTest333()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.TitleSortSetTest(tag, "\0﻿﻿");
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
public void TitleSortSetTest482()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.TitleSortSetTest(tag, "﻿\0");
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
public void TitleSortSetTest652()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.TitleSortSetTest(tag, "﻿﻿");
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
