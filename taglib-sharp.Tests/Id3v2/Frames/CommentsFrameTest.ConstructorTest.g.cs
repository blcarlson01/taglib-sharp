using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Id3v2;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Id3v2.Tests
{
	public partial class CommentsFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(CommentsFrameTest))]
public void ConstructorTest775()
{
    CommentsFrame commentsFrame;
    commentsFrame =
      this.ConstructorTest((string)null, (string)null, StringType.Latin1);
    Assert.IsNotNull((object)commentsFrame);
    Assert.AreEqual<StringType>(StringType.Latin1, commentsFrame.TextEncoding);
    Assert.AreEqual<string>("", commentsFrame.Description);
    Assert.AreEqual<string>("", commentsFrame.Text);
}
	}
}
