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
	public partial class PropertiesTest
	{

[TestMethod]
[PexGeneratedBy(typeof(PropertiesTest))]
public void ConstructorTest01829()
{
    Properties properties;
    properties = this.ConstructorTest01(default(TimeSpan), (ICodec[])null);
    Assert.IsNotNull((object)properties);
    Assert.IsNotNull(properties.Codecs);
}

[TestMethod]
[PexGeneratedBy(typeof(PropertiesTest))]
public void ConstructorTest01189()
{
    Properties properties;
    ICodec[] iCodecs = new ICodec[0];
    properties = this.ConstructorTest01(default(TimeSpan), iCodecs);
    Assert.IsNotNull((object)properties);
    Assert.IsNotNull(properties.Codecs);
}
	}
}
