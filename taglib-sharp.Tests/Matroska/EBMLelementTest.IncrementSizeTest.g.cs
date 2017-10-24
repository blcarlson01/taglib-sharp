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
[PexRaisedException(typeof(NullReferenceException))]
public void IncrementSizeTestThrowsNullReferenceException58()
{
    EBMLelement eBMLelement;
    bool b;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest324()
{
    EBMLelement eBMLelement;
    bool b;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = true;
    b = this.IncrementSizeTest(eBMLelement);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNull((object)(eBMLelement.Data));
    Assert.IsNull((object)(eBMLelement.Children));
    Assert.AreEqual<bool>(true, eBMLelement.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest163()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNotNull((object)(eBMLelement.Data));
    Assert.AreEqual<bool>(false, eBMLelement.Data.IsSynchronized);
    Assert.IsNotNull(eBMLelement.Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (eBMLelement.Data.SyncRoot, (object)(eBMLelement.Data)));
    Assert.IsNull((object)(eBMLelement.Children));
    Assert.AreEqual<bool>(true, eBMLelement.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(UnsupportedFormatException))]
public void IncrementSizeTestThrowsUnsupportedFormatException496()
{
    ByteVector byteVector;
    List<EBMLelement> list;
    EBMLelement eBMLelement;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    EBMLelement[] eBMLelements = new EBMLelement[0];
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = list;
    eBMLelement.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest640()
{
    List<EBMLelement> list;
    EBMLelement eBMLelement;
    bool b;
    EBMLelement[] eBMLelements = new EBMLelement[0];
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = list;
    eBMLelement.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNull((object)(eBMLelement.Data));
    Assert.IsNotNull((object)(eBMLelement.Children));
    Assert.AreEqual<int>(0, eBMLelement.Children.Capacity);
    Assert.AreEqual<int>(0, eBMLelement.Children.Count);
    Assert.AreEqual<bool>(true, eBMLelement.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest901()
{
    List<EBMLelement> list;
    EBMLelement eBMLelement;
    bool b;
    EBMLelement[] eBMLelements = new EBMLelement[0];
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = list;
    eBMLelement.IncSize = PexSafeHelpers.ByteToBoolean((byte)2);
    b = this.IncrementSizeTest(eBMLelement);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNull((object)(eBMLelement.Data));
    Assert.IsNotNull((object)(eBMLelement.Children));
    Assert.AreEqual<int>(0, eBMLelement.Children.Capacity);
    Assert.AreEqual<int>(0, eBMLelement.Children.Count);
    Assert.AreEqual<bool>
        (PexSafeHelpers.ByteToBoolean((byte)2), eBMLelement.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest16301()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    bool b;
    byte[] bs = new byte[5];
    byteVector = new ByteVector(bs, 5);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNotNull((object)(eBMLelement.Data));
    Assert.AreEqual<bool>(false, eBMLelement.Data.IsSynchronized);
    Assert.IsNotNull(eBMLelement.Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (eBMLelement.Data.SyncRoot, (object)(eBMLelement.Data)));
    Assert.IsNull((object)(eBMLelement.Children));
    Assert.AreEqual<bool>(true, eBMLelement.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest16302()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    bool b;
    byte[] bs = new byte[sbyte.MaxValue];
    byteVector = new ByteVector(bs, sbyte.MaxValue);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLelement);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement.ID);
    Assert.IsNotNull((object)(eBMLelement.Data));
    Assert.AreEqual<bool>(false, eBMLelement.Data.IsSynchronized);
    Assert.IsNotNull(eBMLelement.Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (eBMLelement.Data.SyncRoot, (object)(eBMLelement.Data)));
    Assert.IsNull((object)(eBMLelement.Children));
    Assert.AreEqual<bool>(true, eBMLelement.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void IncrementSizeTestThrowsNullReferenceException20()
{
    List<EBMLelement> list;
    EBMLelement eBMLelement;
    bool b;
    EBMLelement[] eBMLelements = new EBMLelement[1];
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = list;
    eBMLelement.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void IncrementSizeTestThrowsNullReferenceException401()
{
    List<EBMLelement> list;
    EBMLelement eBMLelement;
    bool b;
    EBMLelement[] eBMLelements = new EBMLelement[1];
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = list;
    eBMLelement.IncSize = true;
    eBMLelement.IncSize = true;
    b = this.IncrementSizeTest(eBMLelement);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void IncrementSizeTestThrowsNullReferenceException770()
{
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[1];
    eBMLelements[0] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement1);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void IncrementSizeTestThrowsNullReferenceException707()
{
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[1];
    eBMLelements[0] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = PexSafeHelpers.ByteToBoolean((byte)128);
    b = this.IncrementSizeTest(eBMLelement1);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest530()
{
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = PexSafeHelpers.ByteToBoolean((byte)2);
    EBMLelement[] eBMLelements = new EBMLelement[1];
    eBMLelements[0] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = PexSafeHelpers.ByteToBoolean((byte)8);
    b = this.IncrementSizeTest(eBMLelement1);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)eBMLelement1);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement1.ID);
    Assert.IsNull((object)(eBMLelement1.Data));
    Assert.IsNotNull((object)(eBMLelement1.Children));
    Assert.AreEqual<int>(1, eBMLelement1.Children.Capacity);
    Assert.AreEqual<int>(1, eBMLelement1.Children.Count);
    Assert.AreEqual<bool>
        (PexSafeHelpers.ByteToBoolean((byte)8), eBMLelement1.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void IncrementSizeTestThrowsNullReferenceException579()
{
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = true;
    EBMLelement[] eBMLelements = new EBMLelement[2];
    eBMLelements[0] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = PexSafeHelpers.ByteToBoolean((byte)16);
    b = this.IncrementSizeTest(eBMLelement1);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest296()
{
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = (ByteVector)null;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = true;
    EBMLelement[] eBMLelements = new EBMLelement[3];
    eBMLelements[0] = eBMLelement;
    eBMLelements[1] = eBMLelement;
    eBMLelements[2] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = PexSafeHelpers.ByteToBoolean((byte)8);
    b = this.IncrementSizeTest(eBMLelement1);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)eBMLelement1);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement1.ID);
    Assert.IsNull((object)(eBMLelement1.Data));
    Assert.IsNotNull((object)(eBMLelement1.Children));
    Assert.AreEqual<int>(3, eBMLelement1.Children.Capacity);
    Assert.AreEqual<int>(3, eBMLelement1.Children.Count);
    Assert.AreEqual<bool>
        (PexSafeHelpers.ByteToBoolean((byte)8), eBMLelement1.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void IncrementSizeTestThrowsCorruptFileException251()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[1];
    eBMLelements[0] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement1);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest956()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)1073741824u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[1];
    eBMLelements[0] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)1610612736u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement1);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLelement1);
    Assert.AreEqual<MatroskaID>((MatroskaID)1610612736u, eBMLelement1.ID);
    Assert.IsNull((object)(eBMLelement1.Data));
    Assert.IsNotNull((object)(eBMLelement1.Children));
    Assert.AreEqual<int>(1, eBMLelement1.Children.Capacity);
    Assert.AreEqual<int>(1, eBMLelement1.Children.Count);
    Assert.AreEqual<bool>(true, eBMLelement1.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest162()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)2147483648u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = PexSafeHelpers.ByteToBoolean((byte)2);
    EBMLelement[] eBMLelements = new EBMLelement[1];
    eBMLelements[0] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement1);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLelement1);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement1.ID);
    Assert.IsNull((object)(eBMLelement1.Data));
    Assert.IsNotNull((object)(eBMLelement1.Children));
    Assert.AreEqual<int>(1, eBMLelement1.Children.Capacity);
    Assert.AreEqual<int>(1, eBMLelement1.Children.Count);
    Assert.AreEqual<bool>(true, eBMLelement1.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void IncrementSizeTestThrowsNullReferenceException424()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)67108864u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[3];
    eBMLelements[0] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)1u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement1);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest377()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)134217728u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[2];
    eBMLelements[0] = eBMLelement;
    eBMLelements[1] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)512u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement1);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLelement1);
    Assert.AreEqual<MatroskaID>((MatroskaID)512u, eBMLelement1.ID);
    Assert.IsNull((object)(eBMLelement1.Data));
    Assert.IsNotNull((object)(eBMLelement1.Children));
    Assert.AreEqual<int>(2, eBMLelement1.Children.Capacity);
    Assert.AreEqual<int>(2, eBMLelement1.Children.Count);
    Assert.AreEqual<bool>(true, eBMLelement1.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void IncrementSizeTestThrowsCorruptFileException988()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    List<EBMLelement> list1;
    EBMLelement eBMLelement2;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)268435456u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[0];
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    eBMLelement1.ID = (MatroskaID)64u;
    eBMLelement1.Data = byteVector;
    EBMLelement[] eBMLelements1 = new EBMLelement[3];
    eBMLelements1[0] = eBMLelement;
    eBMLelements1[1] = eBMLelement1;
    list1 = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements1);
    eBMLelement2 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement2.ID = (MatroskaID)0u;
    eBMLelement2.Data = (ByteVector)null;
    eBMLelement2.Children = list1;
    eBMLelement2.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement2);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void IncrementSizeTestThrowsNullReferenceException390()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    List<EBMLelement> list1;
    EBMLelement eBMLelement2;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)33554434u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[1];
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    eBMLelement1.Data = byteVector;
    EBMLelement[] eBMLelements1 = new EBMLelement[2];
    eBMLelements1[0] = eBMLelement;
    eBMLelements1[1] = eBMLelement1;
    list1 = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements1);
    eBMLelement2 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement2.ID = (MatroskaID)1u;
    eBMLelement2.Data = (ByteVector)null;
    eBMLelement2.Children = list1;
    eBMLelement2.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement2);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest511()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    List<EBMLelement> list1;
    EBMLelement eBMLelement2;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, byteVector);
    eBMLelement.ID = (MatroskaID)1073750016u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[0];
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)33554432u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    eBMLelement1.Data = byteVector;
    EBMLelement[] eBMLelements1 = new EBMLelement[2];
    eBMLelements1[0] = eBMLelement;
    eBMLelements1[1] = eBMLelement1;
    list1 = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements1);
    eBMLelement2 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement2.ID = (MatroskaID)1u;
    eBMLelement2.Data = (ByteVector)null;
    eBMLelement2.Children = list1;
    eBMLelement2.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement2);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLelement2);
    Assert.AreEqual<MatroskaID>((MatroskaID)1u, eBMLelement2.ID);
    Assert.IsNull((object)(eBMLelement2.Data));
    Assert.IsNotNull((object)(eBMLelement2.Children));
    Assert.AreEqual<int>(2, eBMLelement2.Children.Capacity);
    Assert.AreEqual<int>(2, eBMLelement2.Children.Count);
    Assert.AreEqual<bool>(true, eBMLelement2.IncSize);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void IncrementSizeTestThrowsNullReferenceException750()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    EBMLelement eBMLelement1;
    List<EBMLelement> list;
    EBMLelement eBMLelement2;
    List<EBMLelement> list1;
    EBMLelement eBMLelement3;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, byteVector);
    eBMLelement.ID = (MatroskaID)33554432u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = (List<EBMLelement>)null;
    eBMLelement1.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[1];
    eBMLelements[0] = eBMLelement1;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement2 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement2.ID = (MatroskaID)0u;
    eBMLelement2.Data = (ByteVector)null;
    eBMLelement2.Children = list;
    eBMLelement2.IncSize = false;
    eBMLelement2.Data = byteVector;
    EBMLelement[] eBMLelements1 = new EBMLelement[3];
    eBMLelements1[0] = eBMLelement;
    eBMLelements1[1] = eBMLelement2;
    eBMLelements1[2] = eBMLelement1;
    list1 = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements1);
    eBMLelement3 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement3.ID = (MatroskaID)1u;
    eBMLelement3.Data = (ByteVector)null;
    eBMLelement3.Children = list1;
    eBMLelement3.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement3);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
[PexRaisedException(typeof(CorruptFileException))]
public void IncrementSizeTestThrowsCorruptFileException374()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    List<EBMLelement> list1;
    EBMLelement eBMLelement2;
    List<EBMLelement> list2;
    EBMLelement eBMLelement3;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, byteVector);
    eBMLelement.ID = (MatroskaID)1073741824u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[0];
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = false;
    EBMLelement[] eBMLelements1 = new EBMLelement[1];
    eBMLelements1[0] = eBMLelement1;
    list1 = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements1);
    eBMLelement2 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement2.ID = (MatroskaID)0u;
    eBMLelement2.Data = (ByteVector)null;
    eBMLelement2.Children = list1;
    eBMLelement2.IncSize = false;
    eBMLelement2.Data = byteVector;
    EBMLelement[] eBMLelements2 = new EBMLelement[2];
    eBMLelements2[0] = eBMLelement;
    eBMLelements2[1] = eBMLelement2;
    list2 = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements2);
    eBMLelement3 = new EBMLelement((MatroskaID)0u, byteVector);
    eBMLelement3.ID = (MatroskaID)32u;
    eBMLelement3.Data = (ByteVector)null;
    eBMLelement3.Children = list2;
    eBMLelement3.IncSize = false;
    b = this.IncrementSizeTest(eBMLelement3);
}

[TestMethod]
[PexGeneratedBy(typeof(EBMLelementTest))]
public void IncrementSizeTest291()
{
    ByteVector byteVector;
    EBMLelement eBMLelement;
    List<EBMLelement> list;
    EBMLelement eBMLelement1;
    bool b;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    eBMLelement = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement.ID = (MatroskaID)0u;
    eBMLelement.Data = byteVector;
    eBMLelement.Children = (List<EBMLelement>)null;
    eBMLelement.IncSize = false;
    EBMLelement[] eBMLelements = new EBMLelement[1];
    eBMLelements[0] = eBMLelement;
    list = new List<EBMLelement>((IEnumerable<EBMLelement>)eBMLelements);
    eBMLelement1 = new EBMLelement((MatroskaID)0u, (ByteVector)null);
    eBMLelement1.ID = (MatroskaID)0u;
    eBMLelement1.Data = (ByteVector)null;
    eBMLelement1.Children = list;
    eBMLelement1.IncSize = PexSafeHelpers.ByteToBoolean((byte)128);
    b = this.IncrementSizeTest(eBMLelement1);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)eBMLelement1);
    Assert.AreEqual<MatroskaID>((MatroskaID)0u, eBMLelement1.ID);
    Assert.IsNull((object)(eBMLelement1.Data));
    Assert.IsNotNull((object)(eBMLelement1.Children));
    Assert.AreEqual<int>(1, eBMLelement1.Children.Capacity);
    Assert.AreEqual<int>(1, eBMLelement1.Children.Count);
    Assert.AreEqual<bool>
        (PexSafeHelpers.ByteToBoolean((byte)128), eBMLelement1.IncSize);
}
	}
}
