using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.NonContainer;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.NonContainer.Tests
{
	public partial class EndTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(EndTagTest))]
public void RenderTest911()
{
    EndTag endTag;
    ByteVector byteVector;
    endTag = new EndTag((File)null);
    byteVector = this.RenderTest(endTag);
    Assert.IsNotNull((object)byteVector);
    Assert.AreEqual<bool>(false, byteVector.IsSynchronized);
    Assert.IsNotNull(byteVector.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector.SyncRoot, (object)byteVector));
    Assert.IsNotNull((object)endTag);
}
	}
}
