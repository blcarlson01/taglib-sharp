using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Asf.Tests
{
	public partial class ContentDescriptorTest
	{

[TestMethod]
[PexGeneratedBy(typeof(ContentDescriptorTest))]
public void ConstructorTest058()
{
    ContentDescriptor contentDescriptor;
    contentDescriptor = this.ConstructorTest05((string)null, false);
    Assert.IsNotNull((object)contentDescriptor);
    Assert.AreEqual<string>((string)null, contentDescriptor.Name);
    Assert.AreEqual<DataType>(DataType.Bool, contentDescriptor.Type);
}

[TestMethod]
[PexGeneratedBy(typeof(ContentDescriptorTest))]
public void ConstructorTest05471()
{
    ContentDescriptor contentDescriptor;
    contentDescriptor = this.ConstructorTest05((string)null, true);
    Assert.IsNotNull((object)contentDescriptor);
    Assert.AreEqual<string>((string)null, contentDescriptor.Name);
    Assert.AreEqual<DataType>(DataType.Bool, contentDescriptor.Type);
}
	}
}
