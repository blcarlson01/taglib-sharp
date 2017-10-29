using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Audible;
using TagLib;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Audible.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(PexAssertFailedException))]
public void SetTagClearTestThrowsPexAssertFailedException472()
{
    ByteVector byteVector;
    Tag tag;
    byteVector = ByteVectorFactory.Create();
    tag = new Tag(byteVector);
    this.SetTagClearTest(tag, "\0");
}
	}
}
