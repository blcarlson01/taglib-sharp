using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.NonContainer;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.NonContainer.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void EndTagGetTest565()
{
    Tag tag;
    EndTag endTag;
    tag = new Tag((File)null);
    endTag = this.EndTagGetTest(tag);
    Assert.IsNotNull((object)endTag);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.StartTag);
    Assert.IsNotNull(tag.EndTag);
    Assert.IsTrue(object.ReferenceEquals(tag.EndTag, (object)endTag));
}
	}
}
