using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Mpeg4.Tests
{
	public partial class UnknownBoxTest
	{

[TestMethod]
[PexGeneratedBy(typeof(UnknownBoxTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTestThrowsArgumentNullException974()
{
    UnknownBox unknownBox;
    unknownBox =
      this.ConstructorTest(default(BoxHeader), (File)null, (IsoHandlerBox)null);
}
	}
}
