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
public void MakeTargetTypeTest242()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)32);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest438()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)63);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest521()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)50);
    Assert.AreEqual<TargetType>(TargetType.MOVIE, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest847()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)60);
    Assert.AreEqual<TargetType>(TargetType.SEASON, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest434()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)40);
    Assert.AreEqual<TargetType>(TargetType.PART, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest5()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)0);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest683()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)30);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest546()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)70);
    Assert.AreEqual<TargetType>(TargetType.COLLECTION, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest262()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)10);
    Assert.AreEqual<TargetType>(TargetType.SHOT, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest609()
{
    Tag tag;
    TargetType w;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)20);
    Assert.AreEqual<TargetType>(TargetType.SCENE, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.CHAPTER, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest916()
{
    List<IUIDElement> list;
    Tag tag;
    TargetType w;
    IUIDElement[] iUIDElements = new IUIDElement[0];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)50);
    Assert.AreEqual<TargetType>(TargetType.ALBUM, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(0, tag.Elements.Capacity);
    Assert.AreEqual<int>(0, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest223()
{
    List<IUIDElement> list;
    Tag tag;
    TargetType w;
    IUIDElement[] iUIDElements = new IUIDElement[0];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)1), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)20);
    Assert.AreEqual<TargetType>(TargetType.MOVEMENT, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(0, tag.Elements.Capacity);
    Assert.AreEqual<int>(0, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)1), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest393()
{
    Tags tags;
    Tag tag;
    TargetType w;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, TargetType.SEQUEL, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)32);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), w);
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
public void MakeTargetTypeTest466()
{
    UIDElement uIDElement;
    Tag tag;
    TargetType w;
    uIDElement = new UIDElement((MatroskaID)0u, 0uL);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)uIDElement);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)32);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest887()
{
    List<IUIDElement> list;
    Tag tag;
    TargetType w;
    IUIDElement[] iUIDElements = new IUIDElement[0];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)60);
    Assert.AreEqual<TargetType>(TargetType.VOLUME, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(0, tag.Elements.Capacity);
    Assert.AreEqual<int>(0, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest682()
{
    EBMLreader eBMLreader;
    Track track;
    Tag tag;
    TargetType w;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    track = new Track((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)track);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)0);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.DEFAULT, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest68201()
{
    EBMLreader eBMLreader;
    VideoTrack videoTrack;
    Tag tag;
    TargetType w;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    videoTrack = new VideoTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)videoTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)0);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.DEFAULT, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest68202()
{
    EBMLreader eBMLreader;
    AudioTrack audioTrack;
    Tag tag;
    TargetType w;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    audioTrack = new AudioTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)audioTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)0);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.DEFAULT, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest68203()
{
    EBMLreader eBMLreader;
    SubtitleTrack subtitleTrack;
    Tag tag;
    TargetType w;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    subtitleTrack = new SubtitleTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)subtitleTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)0);
    Assert.AreEqual<TargetType>((TargetType)((ushort)0), w);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.DEFAULT, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest606()
{
    List<IUIDElement> list;
    Tag tag;
    TargetType w;
    IUIDElement[] iUIDElements = new IUIDElement[1];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)50);
    Assert.AreEqual<TargetType>(TargetType.ALBUM, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(1, tag.Elements.Capacity);
    Assert.AreEqual<int>(1, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest426()
{
    List<IUIDElement> list;
    Tag tag;
    TargetType w;
    IUIDElement[] iUIDElements = new IUIDElement[2];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)50);
    Assert.AreEqual<TargetType>(TargetType.ALBUM, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(2, tag.Elements.Capacity);
    Assert.AreEqual<int>(2, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest374()
{
    List<IUIDElement> list;
    Tag tag;
    TargetType w;
    IUIDElement[] iUIDElements = new IUIDElement[0];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)1), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)30);
    Assert.AreEqual<TargetType>(TargetType.TRACK, w);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull((object)(tag.Elements));
    Assert.AreEqual<int>(0, tag.Elements.Capacity);
    Assert.AreEqual<int>(0, tag.Elements.Count);
    Assert.IsNull((object)(tag.SimpleTags));
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)1), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void MakeTargetTypeTest860()
{
    EBMLreader eBMLreader;
    Track track;
    Tags tags;
    Tag tag;
    TargetType w;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    track = new Track((File)null, eBMLreader);
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)0), (IUIDElement)track);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    w = this.MakeTargetTypeTest(tag, (ushort)20);
    Assert.AreEqual<TargetType>(TargetType.MOVEMENT, w);
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
	}
}
