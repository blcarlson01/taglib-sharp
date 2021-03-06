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
public void AudioSampleRateGetTest402()
{
    Properties properties;
    int i;
    properties = new Properties(default(TimeSpan), (IEnumerable<ICodec>)null);
    i = this.AudioSampleRateGetTest(properties);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)properties);
    Assert.IsNotNull(properties.Codecs);
}

[TestMethod]
[PexGeneratedBy(typeof(PropertiesTest))]
public void AudioSampleRateGetTest40201()
{
    Properties properties;
    int i;
    ICodec[] iCodecs = new ICodec[0];
    properties = new Properties(default(TimeSpan), (IEnumerable<ICodec>)iCodecs);
    i = this.AudioSampleRateGetTest(properties);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)properties);
    Assert.IsNotNull(properties.Codecs);
}

[TestMethod]
[PexGeneratedBy(typeof(PropertiesTest))]
public void AudioSampleRateGetTest40202()
{
    Properties properties;
    int i;
    ICodec[] iCodecs = new ICodec[1];
    properties = new Properties(default(TimeSpan), (IEnumerable<ICodec>)iCodecs);
    i = this.AudioSampleRateGetTest(properties);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)properties);
    Assert.IsNotNull(properties.Codecs);
}

[TestMethod]
[PexGeneratedBy(typeof(PropertiesTest))]
public void AudioSampleRateGetTest40203()
{
    Properties properties;
    int i;
    ICodec[] iCodecs = new ICodec[2];
    properties = new Properties(default(TimeSpan), (IEnumerable<ICodec>)iCodecs);
    i = this.AudioSampleRateGetTest(properties);
    Assert.AreEqual<int>(0, i);
    Assert.IsNotNull((object)properties);
    Assert.IsNotNull(properties.Codecs);
}
	}
}
