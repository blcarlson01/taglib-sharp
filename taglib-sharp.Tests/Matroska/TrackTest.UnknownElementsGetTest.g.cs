using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
	public partial class TrackTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TrackTest))]
public void UnknownElementsGetTest390()
{
    EBMLreader eBMLreader;
    Track track;
    List<EBMLreader> list;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    track = new Track((File)null, eBMLreader);
    list = this.UnknownElementsGetTest(track);
    Assert.IsNotNull((object)list);
    Assert.AreEqual<int>(0, list.Capacity);
    Assert.AreEqual<int>(0, list.Count);
    Assert.IsNotNull((object)track);
    Assert.IsNotNull(track.UnknownElements);
    Assert.IsTrue(object.ReferenceEquals(track.UnknownElements, (object)list));
    Assert.AreEqual<ulong>(7317757446383750903uL, track.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagTrackUID, track.UIDType);
}
	}
}
