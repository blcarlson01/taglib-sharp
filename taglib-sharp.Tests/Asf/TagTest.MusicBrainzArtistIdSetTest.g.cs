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
public void MusicBrainzArtistIdSetTest704()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.MusicBrainzArtistIdSetTest(tag, (string)null);
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
public void MusicBrainzArtistIdSetTest35()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.MusicBrainzArtistIdSetTest(tag, "");
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
public void MusicBrainzArtistIdSetTest221()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.MusicBrainzArtistIdSetTest(tag, "\0");
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
public void MusicBrainzArtistIdSetTest788()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.MusicBrainzArtistIdSetTest(tag, "　");
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
public void MusicBrainzArtistIdSetTest669()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.MusicBrainzArtistIdSetTest(tag, "\0﻿");
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
public void MusicBrainzArtistIdSetTest333()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.MusicBrainzArtistIdSetTest(tag, "\0﻿﻿");
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
public void MusicBrainzArtistIdSetTest482()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.MusicBrainzArtistIdSetTest(tag, "﻿\0");
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
public void MusicBrainzArtistIdSetTest652()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.MusicBrainzArtistIdSetTest(tag, "﻿﻿");
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
