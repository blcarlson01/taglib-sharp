using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Tests
{
	public partial class PictureTest
	{

[TestMethod]
[PexGeneratedBy(typeof(PictureTest))]
public void TypeGetTest76()
{
    PictureType i;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    i = this.TypeGetTest(s0);
    Assert.AreEqual<PictureType>(PictureType.Other, i);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<string>((string)null, s0.MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, s0.Type);
    Assert.AreEqual<string>((string)null, s0.Filename);
    Assert.AreEqual<string>((string)null, s0.Description);
    Assert.IsNull(s0.Data);
}
	}
}
