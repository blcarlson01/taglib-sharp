using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
public void CodecsGetTest216()
{
    Properties properties;
    IEnumerable<ICodec> iEnumerable;
    properties = new Properties(default(TimeSpan), (IEnumerable<ICodec>)null);
    iEnumerable = this.CodecsGetTest(properties);
    Assert.IsNotNull((object)iEnumerable);
    Assert.IsNotNull((object)properties);
    Assert.IsNotNull(properties.Codecs);
    Assert.IsTrue(object.ReferenceEquals(properties.Codecs, (object)iEnumerable));
}

[TestMethod]
[PexGeneratedBy(typeof(PropertiesTest))]
public void CodecsGetTest21601()
{
    Properties properties;
    IEnumerable<ICodec> iEnumerable;
    ICodec[] iCodecs = new ICodec[0];
    properties = new Properties(default(TimeSpan), (IEnumerable<ICodec>)iCodecs);
    iEnumerable = this.CodecsGetTest(properties);
    Assert.IsNotNull((object)iEnumerable);
    Assert.IsNotNull((object)properties);
    Assert.IsNotNull(properties.Codecs);
    Assert.IsTrue(object.ReferenceEquals(properties.Codecs, (object)iEnumerable));
}

[TestMethod]
[PexGeneratedBy(typeof(PropertiesTest))]
public void CodecsGetTest992()
{
    Properties properties;
    IEnumerable<ICodec> iEnumerable;
    ICodec[] iCodecs = new ICodec[1];
    properties = new Properties(default(TimeSpan), (IEnumerable<ICodec>)iCodecs);
    iEnumerable = this.CodecsGetTest(properties);
    Assert.IsNotNull((object)iEnumerable);
    Assert.IsNotNull((object)properties);
    Assert.IsNotNull(properties.Codecs);
    Assert.IsTrue(object.ReferenceEquals(properties.Codecs, (object)iEnumerable));
}
	}
}
