using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Gif;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Gif.Tests
{
	public partial class GifCommentTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(GifCommentTagTest))]
public void CommentSetTest468()
{
    GifCommentTag s0 = new GifCommentTag((string)null);
    this.CommentSetTest(s0, (string)null);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<string>((string)null, s0.Value);
}
	}
}
