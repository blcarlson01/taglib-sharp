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
public void GetDoubleTest66()
{
    EBMLelement eBMLelement;
    double d;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    d = this.GetDoubleTest(eBMLelement);
    Assert.AreEqual<double>(0, d);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNull((object)(eBMLelement.Data));
    Assert.IsNull((object)(eBMLelement.Children));
    Assert.AreEqual<bool>(false, eBMLelement.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(UnsupportedFormatException))]
public void GetDoubleTestThrowsUnsupportedFormatException618()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    double d;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    d = this.GetDoubleTest(eBMLelement);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(UnsupportedFormatException))]
public void GetDoubleTestThrowsUnsupportedFormatException61801()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    double d;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    d = this.GetDoubleTest(eBMLelement);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(UnsupportedFormatException))]
public void GetDoubleTestThrowsUnsupportedFormatException61802()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    double d;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    d = this.GetDoubleTest(eBMLelement);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void GetDoubleTest789()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    double d;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 4);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    d = this.GetDoubleTest(eBMLelement);
    Assert.AreEqual<double>(0, d);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNotNull((object)(eBMLelement.Data));
    Assert.AreEqual<bool>(false, eBMLelement.Data.IsSynchronized);
    Assert.IsNotNull(eBMLelement.Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (eBMLelement.Data.SyncRoot, (object)(eBMLelement.Data)));
    Assert.IsNull((object)(eBMLelement.Children));
    Assert.AreEqual<bool>(false, eBMLelement.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void GetDoubleTest78901()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    double d;
    byte[] bs = new byte[9];
    byteVector = new ByteVector(bs, 8);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    d = this.GetDoubleTest(eBMLelement);
    Assert.AreEqual<double>(0, d);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNotNull((object)(eBMLelement.Data));
    Assert.AreEqual<bool>(false, eBMLelement.Data.IsSynchronized);
    Assert.IsNotNull(eBMLelement.Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (eBMLelement.Data.SyncRoot, (object)(eBMLelement.Data)));
    Assert.IsNull((object)(eBMLelement.Children));
    Assert.AreEqual<bool>(false, eBMLelement.IncSize);
}
	}
}
