using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;
using TagLib;
using TagLib.IFD.Makernotes;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.IFD.Makernotes.Tests
{
	public partial class Nikon3MakernoteReaderTest
	{

[TestMethod]
[PexGeneratedBy(typeof(Nikon3MakernoteReaderTest))]
public void ConstructorTest910()
{
    Nikon3MakernoteReader nikon3MakernoteReader;
    nikon3MakernoteReader =
      this.ConstructorTest((File)null, false, (IFDStructure)null, 0L, 0u, 0u);
    Assert.IsNotNull((object)nikon3MakernoteReader);
}
	}
}
