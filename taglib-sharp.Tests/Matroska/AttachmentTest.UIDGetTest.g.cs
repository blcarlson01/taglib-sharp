using TagLib.Id3v2;
using TagLib.Flac;
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
	public partial class AttachmentTest
	{

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void UIDGetTest801()
{
    Attachment attachment;
    ulong l;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    l = this.UIDGetTest(attachment);
    Assert.AreEqual<ulong>(3530842077180975362uL, l);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(3530842077180975362uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void UIDGetTest773()
{
    Picture picture;
    Attachment attachment;
    ulong l;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    attachment = new Attachment((IPicture)picture);
    l = this.UIDGetTest(attachment);
    Assert.AreEqual<ulong>(757051582345062222uL, l);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(757051582345062222uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void UIDGetTest300()
{
    AttachedPictureFrame attachedPictureFrame;
    Attachment attachment;
    ulong l;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)32;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    attachment = new Attachment((IPicture)attachedPictureFrame);
    l = this.UIDGetTest(attachment);
    Assert.AreEqual<ulong>(5973636457194663689uL, l);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(5973636457194663689uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>("", ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void UIDGetTest16()
{
    ByteVector byteVector;
    AttachedPictureFrame attachedPictureFrame;
    Attachment attachment;
    ulong l;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = byteVector;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)short.MinValue;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    attachment = new Attachment((IPicture)attachedPictureFrame);
    l = this.UIDGetTest(attachment);
    Assert.AreEqual<ulong>(3549778188250250251uL, l);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(3549778188250250251uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>("", ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void UIDGetTest196()
{
    Picture picture;
    Picture picture1;
    Attachment attachment;
    ulong l;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    picture1 = new Picture((IPicture)picture);
    attachment = new Attachment((IPicture)picture1);
    l = this.UIDGetTest(attachment);
    Assert.AreEqual<ulong>(7065548903975943197uL, l);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(7065548903975943197uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}
	}
}
