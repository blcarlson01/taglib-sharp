using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TagLib;
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
public void PicturesGetTest272()
{
    Tag tag;
    IPicture[] iPictures;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    iPictures = this.PicturesGetTest(tag);
    Assert.IsNull((object)iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesGetTest155()
{
    Tags tags;
    Tag tag;
    IPicture[] iPictures;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    iPictures = this.PicturesGetTest(tag);
    Assert.IsNotNull((object)iPictures);
    Assert.AreEqual<int>(0, iPictures.Length);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.IsTrue(object.ReferenceEquals(tag.Tags.Attachments, (object)iPictures));
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesGetTest982()
{
    UIDElement uIDElement;
    Tag tag;
    IPicture[] iPictures;
    uIDElement = new UIDElement((MatroskaID)0u, 0uL);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)uIDElement);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    iPictures = this.PicturesGetTest(tag);
    Assert.IsNull((object)iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesGetTest98201()
{
    EBMLreader eBMLreader;
    Track track;
    Tag tag;
    IPicture[] iPictures;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    track = new Track((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)track);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    iPictures = this.PicturesGetTest(tag);
    Assert.IsNull((object)iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesGetTest98202()
{
    EBMLreader eBMLreader;
    VideoTrack videoTrack;
    Tag tag;
    IPicture[] iPictures;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    videoTrack = new VideoTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)videoTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    iPictures = this.PicturesGetTest(tag);
    Assert.IsNull((object)iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesGetTest98203()
{
    EBMLreader eBMLreader;
    AudioTrack audioTrack;
    Tag tag;
    IPicture[] iPictures;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    audioTrack = new AudioTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)audioTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    iPictures = this.PicturesGetTest(tag);
    Assert.IsNull((object)iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesGetTest504()
{
    EBMLreader eBMLreader;
    SubtitleTrack subtitleTrack;
    Tag tag;
    IPicture[] iPictures;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    subtitleTrack = new SubtitleTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)subtitleTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    iPictures = this.PicturesGetTest(tag);
    Assert.IsNull((object)iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.DEFAULT, tag.TargetType);
}
	}
}
