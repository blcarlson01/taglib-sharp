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
public void AttachmentsSetTest366()
{
    Tags tags;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    this.AttachmentsSetTest(tags, (Attachment[])null);
    Assert.IsNotNull((object)tags);
    Assert.AreEqual<bool>(false, tags.IsVideo);
    Assert.AreEqual<string>((string)null, tags.Title);
    Assert.IsNotNull(tags.Attachments);
    Assert.AreEqual<int>(0, tags.Attachments.Length);
}

[TestMethod]
[PexGeneratedBy(typeof(TagsTest))]
public void AttachmentsSetTest706()
{
    Tags tags;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    Attachment[] attachments = new Attachment[0];
    this.AttachmentsSetTest(tags, attachments);
    Assert.IsNotNull((object)tags);
    Assert.AreEqual<bool>(false, tags.IsVideo);
    Assert.AreEqual<string>((string)null, tags.Title);
    Assert.IsNotNull(tags.Attachments);
    Assert.AreEqual<int>(0, tags.Attachments.Length);
}
	}
}
