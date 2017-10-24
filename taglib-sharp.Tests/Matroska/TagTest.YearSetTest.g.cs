using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TagLib.Matroska;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Matroska.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void YearSetTestThrowsNullReferenceException492()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.YearSetTest(tag, 0u);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void YearSetTestThrowsNullReferenceException992()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.YearSetTest(tag, 1u);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void YearSetTest804()
{
    Dictionary<string, List<SimpleTag>> dictionary;
    Tag tag;
    dictionary = new Dictionary<string, List<SimpleTag>>(0);
    dictionary[""] = (List<SimpleTag>)null;
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = dictionary;
    this.YearSetTest(tag, 1u);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNotNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.SimpleTags.Comparer);
    Assert.AreEqual<int>(2, tag.SimpleTags.Count);
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}
	}
}
