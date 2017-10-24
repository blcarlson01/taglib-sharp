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
public void SetTestThrowsNullReferenceException216()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.CHAPTER, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.SetTest(tag, (string)null, (string)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void SetTestThrowsNullReferenceException744()
{
    Tag tag;
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.SetTest(tag, (string)null, (string)null, "");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(ArgumentNullException))]
public void SetTestThrowsArgumentNullException560()
{
    Dictionary<string, List<SimpleTag>> dictionary;
    Tag tag;
    dictionary = new Dictionary<string, List<SimpleTag>>(0);
    dictionary[""] = (List<SimpleTag>)null;
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = dictionary;
    this.SetTest(tag, (string)null, (string)null, "");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void SetTest541()
{
    Dictionary<string, List<SimpleTag>> dictionary;
    Tag tag;
    dictionary = new Dictionary<string, List<SimpleTag>>(0);
    dictionary[""] = (List<SimpleTag>)null;
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = dictionary;
    this.SetTest(tag, "", (string)null, "");
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNotNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.SimpleTags.Comparer);
    Assert.AreEqual<int>(1, tag.SimpleTags.Count);
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}
	}
}
