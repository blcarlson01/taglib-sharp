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
public void PerformersGetTest876()
{
    Tag tag;
    string[] ss;
    tag = TagFactory.Create();
    ss = this.PerformersGetTest(tag);
    Assert.IsNotNull((object)ss);
    Assert.AreEqual<int>(0, ss.Length);
    Assert.IsNotNull((object)tag);
}
	}
}
