using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Image;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Image.Tests
{
	public partial class CombinedImageTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(CombinedImageTagTest))]
public void ConstructorTest573()
{
    CombinedImageTag combinedImageTag;
    combinedImageTag = this.ConstructorTest(TagTypes.None);
    Assert.IsNotNull((object)combinedImageTag);
    Assert.IsNull(combinedImageTag.Exif);
    Assert.IsNull(combinedImageTag.Xmp);
    Assert.IsNotNull(combinedImageTag.OtherTags);
    Assert.AreEqual<int>(0, combinedImageTag.OtherTags.Capacity);
    Assert.AreEqual<int>(0, combinedImageTag.OtherTags.Count);
}
	}
}
