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
public void AlbumArtistsSortSetTest384()
{
    Tag tag;
    tag = TagFactory.Create();
    this.AlbumArtistsSortSetTest(tag, (string[])null);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsSortSetTest921()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[0];
    this.AlbumArtistsSortSetTest(tag, ss);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AlbumArtistsSortSetTest964()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[1];
    this.AlbumArtistsSortSetTest(tag, ss);
    Assert.IsNotNull((object)tag);
}
	}
}
