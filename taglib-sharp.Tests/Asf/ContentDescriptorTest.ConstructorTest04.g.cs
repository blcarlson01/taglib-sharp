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
public void ConstructorTest04590()
{
    ContentDescriptor contentDescriptor;
    contentDescriptor = this.ConstructorTest04((string)null, (ushort)32);
    Assert.IsNotNull((object)contentDescriptor);
    Assert.AreEqual<string>((string)null, contentDescriptor.Name);
    Assert.AreEqual<DataType>(DataType.Word, contentDescriptor.Type);
}
	}
}
