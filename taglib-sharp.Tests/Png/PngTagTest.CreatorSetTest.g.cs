using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Png;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Png.Tests
{
	public partial class PngTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(PngTagTest))]
public void CreatorSetTest340()
{
    PngTag pngTag;
    pngTag = new PngTag();
    this.CreatorSetTest(pngTag, (string)null);
    Assert.IsNotNull((object)pngTag);
}

[TestMethod]
[PexGeneratedBy(typeof(PngTagTest))]
public void CreatorSetTest364()
{
    PngTag pngTag;
    pngTag = new PngTag();
    this.CreatorSetTest(pngTag, "");
    Assert.IsNotNull((object)pngTag);
}
	}
}
