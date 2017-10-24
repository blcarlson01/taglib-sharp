using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
	public partial class TrackTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TrackTest))]
public void MediaTypesGetTest215()
{
    EBMLreader eBMLreader;
    Track track;
    MediaTypes i;
    eBMLreader = new EBMLreader((EBMLreader)null, 0uL, (MatroskaID)0u, 0uL);
    track = new Track((File)null, eBMLreader);
    i = this.MediaTypesGetTest(track);
    Assert.AreEqual<MediaTypes>(MediaTypes.None, i);
    Assert.IsNotNull((object)track);
    Assert.IsNotNull(track.UnknownElements);
    Assert.AreEqual<int>(0, track.UnknownElements.Capacity);
    Assert.AreEqual<int>(0, track.UnknownElements.Count);
    Assert.AreEqual<ulong>(1449788514881423548uL, track.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagTrackUID, track.UIDType);
}
	}
}
