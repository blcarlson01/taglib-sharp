using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Jpeg;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Jpeg.Tests
{
	public partial class JpegCommentTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(JpegCommentTagTest))]
public void CommentSetTest719()
{
    JpegCommentTag s0 = new JpegCommentTag((string)null);
    this.CommentSetTest(s0, (string)null);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<string>((string)null, s0.Value);
}
	}
}
