using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;
using TagLib.Tiff;
using TagLib.Tiff.Rw2;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Tiff.Rw2.Tests
{
	public partial class IFDReaderTest
	{

[TestMethod]
[PexGeneratedBy(typeof(IFDReaderTest))]
public void ConstructorTest874()
{
    IFDReader iFDReader;
    iFDReader = this.ConstructorTest
                    ((BaseTiffFile)null, false, (IFDStructure)null, 0L, 0u, 0u);
    Assert.IsNotNull((object)iFDReader);
}
	}
}
