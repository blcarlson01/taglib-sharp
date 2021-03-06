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
public void DiscSetTest122()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.DiscSetTest(tag, 0u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void DiscSetTest422()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.DiscSetTest(tag, 1u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void DiscSetTest528()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, TargetType.SEQUEL, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.DiscSetTest(tag, 0u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>(TargetType.SEQUEL, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void DiscSetTestThrowsNullReferenceException450()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = true;
    tags.Title = (string)null;
    tag = new Tag(tags, TargetType.SEQUEL, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.DiscSetTest(tag, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void DiscSetTest654()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)71), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.DiscSetTest(tag, 0u);
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
public void DiscSetTest203()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = PexSafeHelpers.ByteToBoolean((byte)2);
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)48), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.DiscSetTest(tag, 0u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(PexSafeHelpers.ByteToBoolean((byte)2), tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>((TargetType)((ushort)48), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void DiscSetTest340()
{
    Tags tags;
    Dictionary<string, List<SimpleTag>> dictionary;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    dictionary = new Dictionary<string, List<SimpleTag>>(0);
    dictionary[""] = (List<SimpleTag>)null;
    tag = new Tag(tags, (TargetType)((ushort)48), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = dictionary;
    this.DiscSetTest(tag, 0u);
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
    Assert.AreEqual<TargetType>((TargetType)((ushort)48), tag.TargetType);
}
	}
}
