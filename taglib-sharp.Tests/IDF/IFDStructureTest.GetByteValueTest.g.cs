using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.IFD.Tests
{
	public partial class IFDStructureTest
	{

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void GetByteValueTest311()
{
    IFDStructure iFDStructure;
    byte? nullb;
    iFDStructure = new IFDStructure();
    nullb = this.GetByteValueTest(iFDStructure, 0, (ushort)32);
    Assert.IsNull((object)nullb);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void GetByteValueTestThrowsArgumentOutOfRangeException697()
{
    IFDStructure iFDStructure;
    byte? nullb;
    iFDStructure = new IFDStructure();
    nullb = this.GetByteValueTest(iFDStructure, int.MinValue, (ushort)32);
}
	}
}
