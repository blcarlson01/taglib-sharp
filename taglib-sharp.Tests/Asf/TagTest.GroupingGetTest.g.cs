using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Asf.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void GroupingGetTest294()
{
    Tag tag;
    string s;
    tag = TagFactory.Create((HeaderObject)null);
    s = this.GroupingGetTest(tag);
    Assert.AreEqual<string>((string)null, s);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}
	}
}
