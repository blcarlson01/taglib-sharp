using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TagLib.Matroska;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Matroska.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsSetTest201()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.AlbumArtistsSetTest(tag, (string[])null);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsSetTest483()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.AlbumArtistsSetTest(tag, (string[])null);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsSetTest515()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, TargetType.SEASON, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.AlbumArtistsSetTest(tag, (string[])null);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>(TargetType.SEASON, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void AlbumArtistsSetTestThrowsNullReferenceException559()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)56), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.AlbumArtistsSetTest(tag, (string[])null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsSetTest48301()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = true;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.AlbumArtistsSetTest(tag, (string[])null);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(true, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsSetTest51501()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)71), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.AlbumArtistsSetTest(tag, (string[])null);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>((TargetType)((ushort)71), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void AlbumArtistsSetTestThrowsNullReferenceException255()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = true;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)71), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    string[] ss = new string[0];
    this.AlbumArtistsSetTest(tag, ss);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsSetTest795()
{
    Tags tags;
    Dictionary<string, List<SimpleTag>> dictionary;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    dictionary = new Dictionary<string, List<SimpleTag>>(0);
    dictionary[""] = (List<SimpleTag>)null;
    tag = new Tag(tags, (TargetType)((ushort)57), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = dictionary;
    this.AlbumArtistsSetTest(tag, (string[])null);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNotNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.SimpleTags.Comparer);
    Assert.AreEqual<int>(1, tag.SimpleTags.Count);
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>((TargetType)((ushort)57), tag.TargetType);
}
	}
}
