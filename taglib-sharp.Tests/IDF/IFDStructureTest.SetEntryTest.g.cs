using System.Collections.Generic;
using TagLib;
using TagLib.IFD.Entries;
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
[PexRaisedException(typeof(NullReferenceException))]
public void SetEntryTestThrowsNullReferenceException828()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)null);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest746()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    ShortIFDEntry s0 = new ShortIFDEntry((ushort)0, (ushort)0);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)s0);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void SetEntryTestThrowsArgumentOutOfRangeException962()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    ShortIFDEntry s0 = new ShortIFDEntry((ushort)0, (ushort)0);
    this.SetEntryTest(iFDStructure, int.MinValue, (IFDEntry)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void SetEntryTest927()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    ShortIFDEntry s0 = new ShortIFDEntry((ushort)0, (ushort)0);
    this.SetEntryTest(iFDStructure, 512, (IFDEntry)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest81()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    SLongIFDEntry s0 = new SLongIFDEntry((ushort)0, 0);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)s0);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest513()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    LongIFDEntry s0 = new LongIFDEntry((ushort)0, 0u);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)s0);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest531()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    ByteIFDEntry s0 = new ByteIFDEntry((ushort)0, (byte)0);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)s0);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest110()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    SByteIFDEntry s0 = new SByteIFDEntry((ushort)0, (sbyte)0);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)s0);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest950()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    SShortIFDEntry s0 = new SShortIFDEntry((ushort)0, (ushort)0);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)s0);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest271()
{
    IFDStructure iFDStructure;
    MakernoteIFDEntry makernoteIFDEntry;
    iFDStructure = new IFDStructure();
    makernoteIFDEntry =
      new MakernoteIFDEntry((ushort)32, (IFDStructure)null, MakernoteType.Unknown, 
                            (ByteVector)null, 0u, false, new bool?(true));
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)makernoteIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest954()
{
    IFDStructure iFDStructure;
    SubIFDEntry subIFDEntry;
    iFDStructure = new IFDStructure();
    subIFDEntry = new SubIFDEntry((ushort)64, (ushort)64, 0u, (IFDStructure)null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)subIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest335()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    StringIFDEntry s0 = new StringIFDEntry((ushort)0, (string)null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)s0);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest926()
{
    IFDStructure iFDStructure;
    StripOffsetsIFDEntry stripOffsetsIFDEntry;
    iFDStructure = new IFDStructure();
    uint[] us = new uint[0];
    uint[] us1 = new uint[0];
    stripOffsetsIFDEntry = new StripOffsetsIFDEntry((ushort)32, us, us1, (File)null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)stripOffsetsIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest456()
{
    IFDStructure iFDStructure;
    iFDStructure = new IFDStructure();
    UserCommentIFDEntry s0 = new UserCommentIFDEntry((ushort)0, (string)null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)s0);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest921()
{
    IFDStructure iFDStructure;
    ThumbnailDataIFDEntry thumbnailDataIFDEntry;
    iFDStructure = new IFDStructure();
    thumbnailDataIFDEntry = new ThumbnailDataIFDEntry((ushort)32, (ByteVector)null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)thumbnailDataIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest317()
{
    IFDStructure iFDStructure;
    UndefinedIFDEntry undefinedIFDEntry;
    iFDStructure = new IFDStructure();
    undefinedIFDEntry = new UndefinedIFDEntry((ushort)32, (ByteVector)null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)undefinedIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest700()
{
    IFDStructure iFDStructure;
    ShortArrayIFDEntry shortArrayIFDEntry;
    iFDStructure = new IFDStructure();
    shortArrayIFDEntry = new ShortArrayIFDEntry((ushort)32, (ushort[])null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)shortArrayIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest455()
{
    IFDStructure iFDStructure;
    RationalArrayIFDEntry rationalArrayIFDEntry;
    iFDStructure = new IFDStructure();
    rationalArrayIFDEntry = new RationalArrayIFDEntry((ushort)32, (Rational[])null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)rationalArrayIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest748()
{
    IFDStructure iFDStructure;
    RationalIFDEntry rationalIFDEntry;
    iFDStructure = new IFDStructure();
    rationalIFDEntry = new RationalIFDEntry((ushort)32, default(Rational));
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)rationalIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest272()
{
    IFDStructure iFDStructure;
    ByteVectorIFDEntry byteVectorIFDEntry;
    iFDStructure = new IFDStructure();
    byteVectorIFDEntry = new ByteVectorIFDEntry((ushort)32, (ByteVector)null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)byteVectorIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest279()
{
    IFDStructure iFDStructure;
    LongArrayIFDEntry longArrayIFDEntry;
    iFDStructure = new IFDStructure();
    longArrayIFDEntry = new LongArrayIFDEntry((ushort)32, (uint[])null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)longArrayIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest290()
{
    IFDStructure iFDStructure;
    SRationalIFDEntry sRationalIFDEntry;
    iFDStructure = new IFDStructure();
    sRationalIFDEntry = new SRationalIFDEntry((ushort)32, default(SRational));
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)sRationalIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest859()
{
    IFDStructure iFDStructure;
    SShortArrayIFDEntry sShortArrayIFDEntry;
    iFDStructure = new IFDStructure();
    sShortArrayIFDEntry = new SShortArrayIFDEntry((ushort)32, (short[])null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)sShortArrayIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest685()
{
    IFDStructure iFDStructure;
    SLongArrayIFDEntry sLongArrayIFDEntry;
    iFDStructure = new IFDStructure();
    sLongArrayIFDEntry = new SLongArrayIFDEntry((ushort)32, (int[])null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)sLongArrayIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest212()
{
    IFDStructure iFDStructure;
    SRationalArrayIFDEntry sRationalArrayIFDEntry;
    iFDStructure = new IFDStructure();
    sRationalArrayIFDEntry =
      new SRationalArrayIFDEntry((ushort)32, (SRational[])null);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)sRationalArrayIFDEntry);
    Assert.IsNotNull((object)iFDStructure);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDStructureTest))]
public void SetEntryTest230()
{
    IFDStructure iFDStructure;
    List<IFDStructure> list;
    SubIFDArrayEntry subIFDArrayEntry;
    iFDStructure = new IFDStructure();
    IFDStructure[] iFDStructures = new IFDStructure[1];
    list = new List<IFDStructure>((IEnumerable<IFDStructure>)iFDStructures);
    subIFDArrayEntry = new SubIFDArrayEntry((ushort)32, list);
    this.SetEntryTest(iFDStructure, 0, (IFDEntry)subIFDArrayEntry);
    Assert.IsNotNull((object)iFDStructure);
}
	}
}
