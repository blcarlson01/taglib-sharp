using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ape;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Ape.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountSetTest166()
{
    Tag tag;
    tag = TagFactory.Create();
    this.TrackCountSetTest(tag, 0u);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void TrackCountSetTest627()
{
    Tag tag;
    tag = TagFactory.Create();
    this.TrackCountSetTest(tag, 1u);
    Assert.IsNotNull((object)tag);
}
	}
}
