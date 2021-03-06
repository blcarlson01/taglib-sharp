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
public void AttachmentsGetTest788()
{
    Tags tags;
    Attachment[] attachments;
    tags = new Tags((List<Track>)null);
    tags.IsVideo = false;
    tags.Title = (string)null;
    attachments = this.AttachmentsGetTest(tags);
    Assert.IsNotNull((object)attachments);
    Assert.AreEqual<int>(0, attachments.Length);
    Assert.IsNotNull((object)tags);
    Assert.AreEqual<bool>(false, tags.IsVideo);
    Assert.AreEqual<string>((string)null, tags.Title);
    Assert.IsNotNull(tags.Attachments);
    Assert.IsTrue(object.ReferenceEquals(tags.Attachments, (object)attachments));
}
	}
}
