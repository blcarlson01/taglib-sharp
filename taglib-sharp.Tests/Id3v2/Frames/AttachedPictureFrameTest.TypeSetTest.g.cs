using TagLib.Flac;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Id3v2;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Id3v2.Tests
{
	public partial class AttachedPictureFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void TypeSetTest987()
{
    AttachedPictureFrame attachedPictureFrame;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)32;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    this.TypeSetTest(attachedPictureFrame, PictureType.Other);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void TypeSetTest98701()
{
    Picture picture;
    AttachedPictureFrame attachedPictureFrame;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    attachedPictureFrame = new AttachedPictureFrame((IPicture)picture);
    ((Frame)attachedPictureFrame).GroupId = (short)short.MinValue;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    this.TypeSetTest(attachedPictureFrame, PictureType.Other);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void TypeSetTest98702()
{
    Picture picture;
    Picture picture1;
    Picture picture2;
    AttachedPictureFrame attachedPictureFrame;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    picture1 = new Picture((IPicture)picture);
    picture2 = new Picture((IPicture)picture1);
    attachedPictureFrame = new AttachedPictureFrame((IPicture)picture2);
    ((Frame)attachedPictureFrame).GroupId = (short)32;
    ((Frame)attachedPictureFrame).EncryptionId = (short)256;
    this.TypeSetTest(attachedPictureFrame, PictureType.Other);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}
	}
}
