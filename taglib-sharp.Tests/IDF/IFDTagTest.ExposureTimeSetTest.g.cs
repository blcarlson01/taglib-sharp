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
public void ExposureTimeSetTest858()
{
    IFDTag iFDTag;
    iFDTag = new IFDTag();
    iFDTag.Comment = (string)null;
    iFDTag.Latitude = new double?(0);
    this.ExposureTimeSetTest(iFDTag, new double?(1));
    Assert.IsNotNull((object)iFDTag);
    Assert.IsNotNull(iFDTag.Structure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDTagTest))]
[PexRaisedException(typeof(ArgumentException))]
public void ExposureTimeSetTestThrowsArgumentException757()
{
    IFDTag iFDTag;
    iFDTag = new IFDTag();
    iFDTag.Comment = (string)null;
    iFDTag.Latitude = new double?(0);
    this.ExposureTimeSetTest(iFDTag, new double?(4294967296));
}

[TestMethod]
[PexGeneratedBy(typeof(IFDTagTest))]
public void ExposureTimeSetTest540()
{
    IFDTag iFDTag;
    iFDTag = new IFDTag();
    iFDTag.Comment = (string)null;
    iFDTag.Latitude = new double?(0);
    this.ExposureTimeSetTest(iFDTag, new double?(0.5));
    Assert.IsNotNull((object)iFDTag);
    Assert.IsNotNull(iFDTag.Structure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDTagTest))]
public void ExposureTimeSetTest85801()
{
    IFDTag iFDTag;
    iFDTag = new IFDTag();
    iFDTag.Comment = "";
    iFDTag.Latitude = new double?(0);
    this.ExposureTimeSetTest(iFDTag, new double?(1));
    Assert.IsNotNull((object)iFDTag);
    Assert.IsNotNull(iFDTag.Structure);
}
	}
}
