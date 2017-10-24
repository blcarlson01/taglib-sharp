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
public void SetTypeFromFilenameTest921()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(4017042015490933778uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest815()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(3245321735321258461uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest11()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = "\0\0\0\0\0\0";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(740951979099285504uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("\0\0\0\0\0\0", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest953()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = "\0\0\0\0\0\0\0";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(6077380112052256473uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("\0\0\0\0\0\0\0", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest392()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(4628145739059987260uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest61()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(4384175482430917858uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("\0", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest342()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "H";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(7101388401269455536uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("H", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest63()
{
    Picture picture;
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    attachment = new Attachment((IPicture)picture);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(6853061535744674165uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest616()
{
    AttachedPictureFrame attachedPictureFrame;
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)2048;
    ((Frame)attachedPictureFrame).EncryptionId = (short)2048;
    attachment = new Attachment((IPicture)attachedPictureFrame);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(29634167047548505uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
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
public void SetTypeFromFilenameTest407()
{
    ByteVector byteVector;
    AttachedPictureFrame attachedPictureFrame;
    Attachment attachment;
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
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1698711283007991521uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
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
public void SetTypeFromFilenameTest712()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "\0\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(5728468810437251505uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("\0\0", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest51()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "\0\0\0\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(5817270381610466750uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("\0\0\0\0", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest607()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "band";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(2025337893045971267uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Band, ((Picture)attachment).Type);
    Assert.AreEqual<string>("band", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest78()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "\0\0\0\0\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(918378032772957330uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("\0\0\0\0\0", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetTypeFromFilenameTest161()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "cover";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    this.SetTypeFromFilenameTest(attachment);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(8694001010630006111uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.FrontCover, ((Picture)attachment).Type);
    Assert.AreEqual<string>("cover", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}
	}
}
