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
public void SetDataTest579()
{
    EBMLelement eBMLelement;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    this.SetDataTest(eBMLelement, (string)null);
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
public void SetDataTest640()
{
    EBMLelement eBMLelement;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    this.SetDataTest(eBMLelement, "");
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
public void SetDataTest55()
{
    EBMLelement eBMLelement;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    this.SetDataTest(eBMLelement, "�");
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
public void SetDataTest637()
{
    EBMLelement eBMLelement;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    this.SetDataTest(eBMLelement, "�ࠀ");
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
