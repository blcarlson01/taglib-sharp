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
public void CopyrightGetTest466()
{
    PngTag pngTag;
    string s;
    pngTag = new PngTag();
    s = this.CopyrightGetTest(pngTag);
    Assert.AreEqual<string>((string)null, s);
    Assert.IsNotNull((object)pngTag);
}
	}
}
