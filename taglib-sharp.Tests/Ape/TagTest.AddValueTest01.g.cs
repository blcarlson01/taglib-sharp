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
[ExpectedException(typeof(ArgumentNullException))]
public void AddValueTest01ThrowsArgumentNullException898()
{
    Tag tag;
    tag = TagFactory.Create();
    this.AddValueTest01(tag, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AddValueTest01696()
{
    Tag tag;
    tag = TagFactory.Create();
    this.AddValueTest01(tag, "", (string)null);
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void AddValueTest01546()
{
    Tag tag;
    tag = TagFactory.Create();
    this.AddValueTest01(tag, "\0", "\0");
    Assert.IsNotNull((object)tag);
}
	}
}
