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
public void SetFilenameFromTypeTest377()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(4420853072238750785uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest211()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(2959960911011950738uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest6()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(8899960429457458651uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
[PexRaisedException(typeof(ArgumentException))]
public void SetFilenameFromTypeTestThrowsArgumentException399()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = "\0";
    s0.Type = PictureType.Other;
    s0.Filename = "\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest167()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.NotAPicture;
    s0.Filename = "\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(5529154547282267172uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("\0", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
[PexRaisedException(typeof(ArgumentException))]
public void SetFilenameFromTypeTestThrowsArgumentException25()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = "\0\0\0\0\0\0";
    s0.Type = PictureType.Other;
    s0.Filename = "\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
[PexRaisedException(typeof(ArgumentException))]
public void SetFilenameFromTypeTestThrowsArgumentException549()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = "\0\0\0\0\0\0\0";
    s0.Type = PictureType.Other;
    s0.Filename = "\0\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest175()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(2486521164284555915uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("\0", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest952()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "H";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1906373810644708147uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("H", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest998()
{
    Picture picture;
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    attachment = new Attachment((IPicture)picture);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(2808383119294892504uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest933()
{
    AttachedPictureFrame attachedPictureFrame;
    Attachment attachment;
    bool b;
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
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(8470468724968982643uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other", ((Picture)attachment).Filename);
    Assert.AreEqual<string>("", ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest411()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = "image/";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1196333153548337527uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("image/", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest576()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = "image//";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(8461437688543548933uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("image//", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other./", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest612()
{
    ByteVector byteVector;
    AttachedPictureFrame attachedPictureFrame;
    Attachment attachment;
    bool b;
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
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(5424394698250789422uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other", ((Picture)attachment).Filename);
    Assert.AreEqual<string>("", ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest636()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = (PictureType)256;
    s0.Filename = "H";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(742205198570397238uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>((PictureType)256, ((Picture)attachment).Type);
    Assert.AreEqual<string>("256", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest822()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = (PictureType)int.MinValue;
    s0.Filename = "H";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(883743311417202315uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        ((PictureType)int.MinValue, ((Picture)attachment).Type);
    Assert.AreEqual<string>("-2147483648", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest588()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "\0\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(5253395142229424108uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("\0\0", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest414()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "\0\0\0\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(5449872759169473661uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("\0\0\0\0", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest399()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "band";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(2638966056054429575uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest986()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "\0\0\0\0\0";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(7634435667383586616uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("\0\0\0\0\0", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void SetFilenameFromTypeTest594()
{
    Attachment attachment;
    bool b;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = "cover";
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachment = new Attachment((IPicture)s0);
    b = this.SetFilenameFromTypeTest(attachment);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(874734417177257628uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>("Other", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}
	}
}
