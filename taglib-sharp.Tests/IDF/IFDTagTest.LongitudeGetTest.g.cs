using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.IFD.Tests
{
	public partial class IFDTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(IFDTagTest))]
public void LongitudeGetTest821()
{
    IFDTag iFDTag;
    double? nulld;
    iFDTag = new IFDTag();
    iFDTag.Comment = (string)null;
    iFDTag.Latitude = new double?(0);
    nulld = this.LongitudeGetTest(iFDTag);
    Assert.IsNull((object)nulld);
    Assert.IsNotNull((object)iFDTag);
    Assert.IsNotNull(iFDTag.Structure);
}
	}
}
