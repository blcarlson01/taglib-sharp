using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TagLib;
using TagLib.Matroska;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Matroska.Tests
{
	public partial class EBMLelementTest
	{

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void WriteTestThrowsArgumentNullException507()
{
    EBMLelement eBMLelement;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    this.WriteTest(eBMLelement, (File)null, 0L, 0L);
}
	}
}
