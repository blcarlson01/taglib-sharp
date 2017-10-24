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
public void SetTest01ThrowsNullReferenceException740()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.SEASON, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.SetTest01(tag, (string)null, (string)null, 0u, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void SetTest01ThrowsNullReferenceException413()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.SEASON, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.SetTest01(tag, (string)null, (string)null, 1u, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void SetTest01ThrowsNullReferenceException731()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.SEQUEL, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.SetTest01(tag, (string)null, (string)null, 1u, "");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void SetTest01ThrowsNullReferenceException87()
{
    Tag tag;
    tag = new Tag((Tags)null, TargetType.SEQUEL, (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = (Dictionary<string, List<SimpleTag>>)null;
    this.SetTest01(tag, (string)null, (string)null, 580u, "");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(ArgumentNullException))]
public void SetTest01ThrowsArgumentNullException769()
{
    Dictionary<string, List<SimpleTag>> dictionary;
    Tag tag;
    dictionary = new Dictionary<string, List<SimpleTag>>(0);
    dictionary[""] = (List<SimpleTag>)null;
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = dictionary;
    this.SetTest01(tag, (string)null, (string)null, 0u, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void SetTest01913()
{
    Dictionary<string, List<SimpleTag>> dictionary;
    Tag tag;
    dictionary = new Dictionary<string, List<SimpleTag>>(0);
    dictionary[""] = (List<SimpleTag>)null;
    tag = new Tag((Tags)null, (TargetType)((ushort)33), (IUIDElement)null);
    tag.Elements = (List<IUIDElement>)null;
    tag.SimpleTags = dictionary;
    this.SetTest01(tag, "", (string)null, 0u, (string)null);
    Assert.IsNotNull((object)tag);
    Assert.IsNull((object)(tag.Elements));
    Assert.IsNotNull((object)(tag.SimpleTags));
    Assert.IsNotNull(tag.SimpleTags.Comparer);
    Assert.AreEqual<int>(0, tag.SimpleTags.Count);
    Assert.IsNull(tag.Tags);
    Assert.AreEqual<TargetType>((TargetType)((ushort)33), tag.TargetType);
}
	}
}
