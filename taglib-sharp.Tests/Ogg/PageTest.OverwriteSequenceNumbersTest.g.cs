using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TagLib.Ogg;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Ogg.Tests
{
	public partial class PageTest
	{

[TestMethod]
[PexGeneratedBy(typeof(PageTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void OverwriteSequenceNumbersTestThrowsArgumentNullException453()
{
    this.OverwriteSequenceNumbersTest((File)null, 0L, (IDictionary<uint, int>)null);
}
	}
}
