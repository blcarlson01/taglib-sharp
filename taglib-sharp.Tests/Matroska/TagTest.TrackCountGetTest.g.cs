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
public void TrackCountGetTest609()
{
    Tag tag;
    uint u;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest857()
{
    Tag tag;
    uint u;
    tag = new Tag((Tags)null, (TargetType)((ushort)1), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)1), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest411()
{
    Tag tag;
    uint u;
    tag = new Tag((Tags)null, (TargetType)((ushort)56), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)56), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest486()
{
    Tag tag;
    uint u;
    tag = new Tag((Tags)null, TargetType.PART, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.PART, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest647()
{
    Tag tag;
    uint u;
    tag = new Tag((Tags)null, (TargetType)((ushort)18), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)18), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest832()
{
    Tag tag;
    uint u;
    tag = new Tag((Tags)null, (TargetType)((ushort)85), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)85), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest651()
{
    Tag tag;
    uint u;
    tag = new Tag((Tags)null, TargetType.SEQUEL, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.SEQUEL, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest557()
{
    Tag tag;
    uint u;
    tag = new Tag((Tags)null, TargetType.SCENE, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.SCENE, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest643()
{
    List<IUIDElement> list;
    Tag tag;
    uint u;
    IUIDElement[] iUIDElements = new IUIDElement[0];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)57), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(0, tag.Elements.Capacity);
    Assert.AreEqual<int>(0, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)57), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest867()
{
    List<IUIDElement> list;
    Tag tag;
    uint u;
    IUIDElement[] iUIDElements = new IUIDElement[0];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)13), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(0, tag.Elements.Capacity);
    Assert.AreEqual<int>(0, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)13), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest65101()
{
    UIDElement uIDElement;
    Tag tag;
    uint u;
    uIDElement = new UIDElement((MatroskaID)0u, 0uL);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)uIDElement);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest318()
{
    Tags tags;
    Tag tag;
    uint u;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, TargetType.SEQUEL, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
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
public void TrackCountGetTest249()
{
    Tags tags;
    Tag tag;
    uint u;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)0), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>(TargetType.DEFAULT, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest94()
{
    List<IUIDElement> list;
    Tag tag;
    uint u;
    IUIDElement[] iUIDElements = new IUIDElement[1];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)16), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(1, tag.Elements.Capacity);
    Assert.AreEqual<int>(1, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)16), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest65102()
{
    EBMLreader eBMLreader;
    VideoTrack videoTrack;
    Tag tag;
    uint u;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    videoTrack = new VideoTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)videoTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest65103()
{
    EBMLreader eBMLreader;
    SubtitleTrack subtitleTrack;
    Tag tag;
    uint u;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    subtitleTrack = new SubtitleTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)subtitleTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest60901()
{
    EBMLreader eBMLreader;
    Track track;
    Tag tag;
    uint u;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    track = new Track((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)track);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.DEFAULT, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest65104()
{
    EBMLreader eBMLreader;
    AudioTrack audioTrack;
    Tag tag;
    uint u;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    audioTrack = new AudioTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)audioTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest205()
{
    EBMLreader eBMLreader;
    SubtitleTrack subtitleTrack;
    List<IUIDElement> list;
    Tag tag;
    uint u;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    subtitleTrack = new SubtitleTrack((File)null, eBMLreader);
    IUIDElement[] iUIDElements = new IUIDElement[1];
    iUIDElements[0] = (IUIDElement)subtitleTrack;
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)16), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(1, tag.Elements.Capacity);
    Assert.AreEqual<int>(1, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)16), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest872()
{
    Tags tags;
    Tag tag;
    uint u;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)109), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>((TargetType)((ushort)109), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest983()
{
    EBMLreader eBMLreader;
    VideoTrack videoTrack;
    List<IUIDElement> list;
    Tag tag;
    uint u;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    videoTrack = new VideoTrack((File)null, eBMLreader);
    IUIDElement[] iUIDElements = new IUIDElement[1];
    iUIDElements[0] = (IUIDElement)videoTrack;
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(1, tag.Elements.Capacity);
    Assert.AreEqual<int>(1, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.DEFAULT, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest195()
{
    EBMLreader eBMLreader;
    AudioTrack audioTrack;
    List<IUIDElement> list;
    Tag tag;
    uint u;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    audioTrack = new AudioTrack((File)null, eBMLreader);
    IUIDElement[] iUIDElements = new IUIDElement[0];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)49), (IUIDElement)audioTrack);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(0, tag.Elements.Capacity);
    Assert.AreEqual<int>(0, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)49), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest737()
{
    Tags tags;
    Tag tag;
    uint u;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)24), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>((TargetType)((ushort)24), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountGetTest20501()
{
    Tags tags;
    List<IUIDElement> list;
    Tag tag;
    uint u;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    IUIDElement[] iUIDElements = new IUIDElement[2];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag(tags, TargetType.SUBTRACK, (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    u = this.TrackCountGetTest(tag);
    Assert.AreEqual<uint>(0u, u);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(2, tag.Elements.Capacity);
    Assert.AreEqual<int>(2, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.Tags);
    Assert.AreEqual<bool>(false, tag.Tags.IsVideo);
    Assert.AreEqual<string>((string)null, tag.Tags.Title);
    Assert.IsNotNull(tag.Tags.Attachments);
    Assert.AreEqual<int>(0, tag.Tags.Attachments.Length);
    Assert.AreEqual<TargetType>(TargetType.SUBTRACK, tag.TargetType);
}
	}
}
