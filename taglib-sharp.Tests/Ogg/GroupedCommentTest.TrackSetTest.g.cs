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
public void TrackSetTest817()
{
    GroupedComment groupedComment;
    groupedComment = new GroupedComment();
    this.TrackSetTest(groupedComment, 0u);
    Assert.IsNotNull((object)groupedComment);
    Assert.IsNotNull(groupedComment.Comments);
}
	}
}
