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
public void DateTimeSetTest859()
{
    IFDTag iFDTag;
    iFDTag = new IFDTag();
    iFDTag.Comment = (string)null;
    iFDTag.Latitude = new double?(0);
    this.DateTimeSetTest(iFDTag, default(DateTime?));
    Assert.IsNotNull((object)iFDTag);
    Assert.IsNotNull(iFDTag.Structure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDTagTest))]
public void DateTimeSetTest240()
{
    IFDTag iFDTag;
    iFDTag = new IFDTag();
    iFDTag.Comment = (string)null;
    iFDTag.Latitude = new double?(0);
    this.DateTimeSetTest(iFDTag, new DateTime?(default(DateTime)));
    Assert.IsNotNull((object)iFDTag);
    Assert.IsNotNull(iFDTag.Structure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDTagTest))]
public void DateTimeSetTest85901()
{
    IFDTag iFDTag;
    iFDTag = new IFDTag();
    iFDTag.Comment = "";
    iFDTag.Latitude = new double?(0);
    this.DateTimeSetTest(iFDTag, default(DateTime?));
    Assert.IsNotNull((object)iFDTag);
    Assert.IsNotNull(iFDTag.Structure);
}
	}
}
