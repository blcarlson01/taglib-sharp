using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ape;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Ape.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void ReplayGainTrackPeakGetTest370()
{
    Tag tag;
    double d;
    tag = TagFactory.Create();
    d = this.ReplayGainTrackPeakGetTest(tag);
    Assert.AreEqual<double>(double.NaN, d);
    Assert.IsNotNull((object)tag);
}
	}
}
