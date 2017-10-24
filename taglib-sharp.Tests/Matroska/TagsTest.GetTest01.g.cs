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
	public partial class TagsTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagsTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void GetTest01ThrowsNullReferenceException838()
{
    Tags tags;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    tag = this.GetTest01(tags, (IUIDElement)null, (ushort)32);
}

[TestMethod]
[PexGeneratedBy(typeof(TagsTest))]
public void GetTest01940()
{
    Tags tags;
    UIDElement uIDElement;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    uIDElement = new UIDElement((MatroskaID)0u, 0uL);
    tag = this.GetTest01(tags, (IUIDElement)uIDElement, (ushort)32);
    Assert.IsNull((object)tag);
    Assert.IsNotNull((object)tags);
    Assert.AreEqual<bool>(false, tags.IsVideo);
    Assert.AreEqual<string>((string)null, tags.Title);
    Assert.IsNotNull(tags.Attachments);
    Assert.AreEqual<int>(0, tags.Attachments.Length);
}

[TestMethod]
[PexGeneratedBy(typeof(TagsTest))]
public void GetTest01342()
{
    Tags tags;
    EBMLreader eBMLreader;
    VideoTrack videoTrack;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    videoTrack = new VideoTrack((File)null, eBMLreader);
    tag = this.GetTest01(tags, (IUIDElement)videoTrack, (ushort)32);
    Assert.IsNull((object)tag);
    Assert.IsNotNull((object)tags);
    Assert.AreEqual<bool>(false, tags.IsVideo);
    Assert.AreEqual<string>((string)null, tags.Title);
    Assert.IsNotNull(tags.Attachments);
    Assert.AreEqual<int>(0, tags.Attachments.Length);
}

[TestMethod]
[PexGeneratedBy(typeof(TagsTest))]
public void GetTest01923()
{
    Tags tags;
    EBMLreader eBMLreader;
    Track track;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    track = new Track((File)null, eBMLreader);
    tag = this.GetTest01(tags, (IUIDElement)track, (ushort)32);
    Assert.IsNull((object)tag);
    Assert.IsNotNull((object)tags);
    Assert.AreEqual<bool>(false, tags.IsVideo);
    Assert.AreEqual<string>((string)null, tags.Title);
    Assert.IsNotNull(tags.Attachments);
    Assert.AreEqual<int>(0, tags.Attachments.Length);
}

[TestMethod]
[PexGeneratedBy(typeof(TagsTest))]
public void GetTest01677()
{
    Tags tags;
    EBMLreader eBMLreader;
    SubtitleTrack subtitleTrack;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    subtitleTrack = new SubtitleTrack((File)null, eBMLreader);
    tag = this.GetTest01(tags, (IUIDElement)subtitleTrack, (ushort)32);
    Assert.IsNull((object)tag);
    Assert.IsNotNull((object)tags);
    Assert.AreEqual<bool>(false, tags.IsVideo);
    Assert.AreEqual<string>((string)null, tags.Title);
    Assert.IsNotNull(tags.Attachments);
    Assert.AreEqual<int>(0, tags.Attachments.Length);
}

[TestMethod]
[PexGeneratedBy(typeof(TagsTest))]
public void GetTest01882()
{
    Tags tags;
    EBMLreader eBMLreader;
    AudioTrack audioTrack;
    Tag tag;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    audioTrack = new AudioTrack((File)null, eBMLreader);
    tag = this.GetTest01(tags, (IUIDElement)audioTrack, (ushort)32);
    Assert.IsNull((object)tag);
    Assert.IsNotNull((object)tags);
    Assert.AreEqual<bool>(false, tags.IsVideo);
    Assert.AreEqual<string>((string)null, tags.Title);
    Assert.IsNotNull(tags.Attachments);
    Assert.AreEqual<int>(0, tags.Attachments.Length);
}
	}
}
