using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Ogg.Tests
{
	public partial class GroupedCommentTest
	{

[TestMethod]
[PexGeneratedBy(typeof(GroupedCommentTest))]
public void MusicBrainzTrackIdGetTest637()
{
    GroupedComment groupedComment;
    string s;
    groupedComment = new GroupedComment();
    s = this.MusicBrainzTrackIdGetTest(groupedComment);
    Assert.AreEqual<string>((string)null, s);
    Assert.IsNotNull((object)groupedComment);
    Assert.IsNotNull(groupedComment.Comments);
}
	}
}
