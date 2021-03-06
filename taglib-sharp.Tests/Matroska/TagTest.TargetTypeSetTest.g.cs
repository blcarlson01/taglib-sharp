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
public void TargetTypeSetTest56()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.TargetTypeSetTest(tag, TargetType.CHAPTER);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TargetTypeSetTest609()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, TargetType.SEQUEL, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.TargetTypeSetTest(tag, TargetType.CHAPTER);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TargetTypeSetTest112()
{
    UIDElement uIDElement;
    Tag tag;
    uIDElement = new UIDElement((MatroskaID)0u, 0uL);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)uIDElement);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.TargetTypeSetTest(tag, TargetType.CHAPTER);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TargetTypeSetTest275()
{
    EBMLreader eBMLreader;
    AudioTrack audioTrack;
    Tag tag;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    audioTrack = new AudioTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)audioTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.TargetTypeSetTest(tag, (TargetType)((ushort)0));
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TargetTypeSetTest27501()
{
    EBMLreader eBMLreader;
    VideoTrack videoTrack;
    Tag tag;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    videoTrack = new VideoTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)videoTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.TargetTypeSetTest(tag, (TargetType)((ushort)0));
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TargetTypeSetTest27502()
{
    EBMLreader eBMLreader;
    Track track;
    Tag tag;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    track = new Track((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)track);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.TargetTypeSetTest(tag, (TargetType)((ushort)0));
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TargetTypeSetTest11201()
{
    EBMLreader eBMLreader;
    SubtitleTrack subtitleTrack;
    Tag tag;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    subtitleTrack = new SubtitleTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)subtitleTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.TargetTypeSetTest(tag, TargetType.CHAPTER);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}
	}
}
