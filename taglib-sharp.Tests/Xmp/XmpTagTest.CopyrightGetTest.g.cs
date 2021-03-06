using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Xmp;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Xmp.Tests
{
	public partial class XmpTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(XmpTagTest))]
public void CopyrightGetTest603()
{
    XmpTag xmpTag;
    string s;
    xmpTag = new XmpTag();
    s = this.CopyrightGetTest(xmpTag);
    Assert.AreEqual<string>((string)null, s);
    Assert.IsNotNull((object)xmpTag);
    Assert.IsNotNull(xmpTag.NodeTree);
    Assert.AreEqual<string>("", xmpTag.NodeTree.Namespace);
    Assert.AreEqual<string>("", xmpTag.NodeTree.Name);
    Assert.AreEqual<string>("", xmpTag.NodeTree.Value);
    Assert.AreEqual<XmpNodeType>(XmpNodeType.Simple, xmpTag.NodeTree.Type);
}
	}
}
