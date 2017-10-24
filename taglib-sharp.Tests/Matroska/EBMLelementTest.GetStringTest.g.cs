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
public void GetStringTest549()
{
    EBMLelement eBMLelement;
    string s;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    s = this.GetStringTest(eBMLelement);
    Assert.AreEqual<string>((string)null, s);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNull((object)(eBMLelement.Data));
    Assert.IsNull((object)(eBMLelement.Children));
    Assert.AreEqual<bool>(false, eBMLelement.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void GetStringTest533()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    string s;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    s = this.GetStringTest(eBMLelement);
    Assert.AreEqual<string>("", s);
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
public void GetStringTest53301()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    string s;
    byte[] bs = new byte[3];
    byteVector = new ByteVector(bs, 1);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    s = this.GetStringTest(eBMLelement);
    Assert.AreEqual<string>("", s);
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
