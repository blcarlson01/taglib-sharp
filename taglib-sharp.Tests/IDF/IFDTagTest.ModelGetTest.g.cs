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
public void ModelGetTest821()
{
    IFDTag iFDTag;
    string s;
    iFDTag = new IFDTag();
    iFDTag.Comment = (string)null;
    iFDTag.Latitude = new double?(0);
    s = this.ModelGetTest(iFDTag);
    Assert.AreEqual<string>((string)null, s);
    Assert.IsNotNull((object)iFDTag);
    Assert.IsNotNull(iFDTag.Structure);
}
	}
}
