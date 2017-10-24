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
[PexRaisedException(typeof(NullReferenceException))]
public void ConductorSetTestThrowsNullReferenceException730()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.ConductorSetTest(tag, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConductorSetTestThrowsNullReferenceException405()
{
    Tag tag;
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.ConductorSetTest(tag, "");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void ConductorSetTest99()
{
    Dictionary<string, List<SimpleTag>> dictionary;
    Tag tag;
    dictionary = new Dictionary<string, List<SimpleTag>>(0);
    dictionary[""] = (List<SimpleTag>)null;
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = dictionary;
    this.ConductorSetTest(tag, "");
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNotNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.SimpleTags.Comparer);
    Assert.AreEqual<int>(2, tag.SimpleTags.Count);
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void ConductorSetTest479()
{
    Dictionary<string, List<SimpleTag>> dictionary;
    Tag tag;
    dictionary = new Dictionary<string, List<SimpleTag>>(0);
    dictionary[""] = (List<SimpleTag>)null;
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = dictionary;
    this.ConductorSetTest(tag, (string)null);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNotNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.SimpleTags.Comparer);
    Assert.AreEqual<int>(1, tag.SimpleTags.Count);
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>(TargetType.DEFAULT, tag.TargetType);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConductorSetTestThrowsNullReferenceException764()
{
    List<IUIDElement> list;
    Tag tag;
    IUIDElement[] iUIDElements = new IUIDElement[0];
    list = new List<IUIDElement>((IEnumerable<IUIDElement>)iUIDElements);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = list;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.ConductorSetTest(tag, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConductorSetTestThrowsNullReferenceException132()
{
    UIDElement uIDElement;
    Tag tag;
    uIDElement = new UIDElement((MatroskaID)0u, 0uL);
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)uIDElement);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.ConductorSetTest(tag, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConductorSetTestThrowsNullReferenceException584()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = new Tag(tags, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.ConductorSetTest(tag, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConductorSetTestThrowsNullReferenceException603()
{
    EBMLreader eBMLreader;
    AudioTrack audioTrack;
    Tag tag;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    audioTrack = new AudioTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)audioTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.ConductorSetTest(tag, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConductorSetTestThrowsNullReferenceException783()
{
    EBMLreader eBMLreader;
    Track track;
    Tag tag;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    track = new Track((File)null, eBMLreader);
    tag = new Tag((Tags)null, TargetType.SEQUEL, (IUIDElement)track);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.ConductorSetTest(tag, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConductorSetTestThrowsNullReferenceException60301()
{
    EBMLreader eBMLreader;
    VideoTrack videoTrack;
    Tag tag;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    videoTrack = new VideoTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)videoTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.ConductorSetTest(tag, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void ConductorSetTestThrowsNullReferenceException60302()
{
    EBMLreader eBMLreader;
    SubtitleTrack subtitleTrack;
    Tag tag;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    subtitleTrack = new SubtitleTrack((File)null, eBMLreader);
    tag = new Tag((Tags)null, (TargetType)((ushort)0), (IUIDElement)subtitleTrack);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.ConductorSetTest(tag, (string)null);
}
	}
}
