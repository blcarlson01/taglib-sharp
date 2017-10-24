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
[PexRaisedException(typeof(NullReferenceException))]
public void ConstructorTest04ThrowsNullReferenceException2()
{
    Attachment attachment;
    attachment = this.ConstructorTest04((IPicture)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest04108()
{
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = this.ConstructorTest04((IPicture)s0);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1686449143049343298uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest04966()
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
    attachment = this.ConstructorTest04((IPicture)picture);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1659097253569806542uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest04152()
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
    ((Frame)attachedPictureFrame).GroupId = (short)32;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    attachment = this.ConstructorTest04((IPicture)attachedPictureFrame);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(3922858588611835696uL, attachment.UID);
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
public void ConstructorTest04121()
{
    AttachedPictureFrame attachedPictureFrame;
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = "";
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)0;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    attachment = this.ConstructorTest04((IPicture)attachedPictureFrame);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1993470979618231656uL, attachment.UID);
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
public void ConstructorTest04328()
{
    AttachedPictureFrame attachedPictureFrame;
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)short.MinValue;
    ((Frame)attachedPictureFrame).EncryptionId = (short)256;
    attachment = this.ConstructorTest04((IPicture)attachedPictureFrame);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(9041880536428086529uL, attachment.UID);
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
public void ConstructorTest0459()
{
    ByteVector byteVector;
    AttachedPictureFrame attachedPictureFrame;
    Attachment attachment;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = byteVector;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)short.MinValue;
    ((Frame)attachedPictureFrame).EncryptionId = (short)256;
    attachment = this.ConstructorTest04((IPicture)attachedPictureFrame);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1691538926674994797uL, attachment.UID);
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
public void ConstructorTest04853()
{
    Picture picture;
    Picture picture1;
    Attachment attachment;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    picture1 = new Picture((IPicture)picture);
    attachment = this.ConstructorTest04((IPicture)picture1);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(7700483051396942282uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}
	}
}
