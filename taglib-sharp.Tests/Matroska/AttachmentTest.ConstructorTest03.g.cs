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
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest03ThrowsArgumentNullException358()
{
    Attachment attachment;
    attachment = this.ConstructorTest03((ByteVector)null);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03757()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(7620733904846787591uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03720()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 0);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(4205694098729971025uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03352()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 1);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(3110261428074132826uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03543()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(5806402864555671068uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest0382()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    bs[1] = (byte)80;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(2910173560048078732uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03341()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    bs[0] = (byte)78;
    bs[1] = (byte)80;
    bs[2] = (byte)78;
    bs[3] = (byte)78;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(7818419598169148202uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03149()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    bs[0] = (byte)71;
    bs[1] = (byte)80;
    bs[2] = (byte)78;
    bs[3] = (byte)71;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1753490222662633892uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("image/png", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.FrontCover, ((Picture)attachment).Type);
    Assert.AreEqual<string>("cover.png", ((Picture)attachment).Filename);
    Assert.AreEqual<string>("cover.png", ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03698()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    bs[0] = (byte)71;
    bs[1] = (byte)80;
    bs[2] = (byte)78;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(8415187015729513821uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03794()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    bs[0] = (byte)byte.MaxValue;
    bs[1] = (byte)80;
    bs[2] = (byte)78;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(8700256352400988742uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03204()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    bs[0] = (byte)66;
    bs[1] = (byte)80;
    bs[2] = (byte)78;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(6946402419463084618uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03945()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[5];
    bs[0] = (byte)71;
    bs[1] = (byte)73;
    bs[2] = (byte)73;
    bs[3] = (byte)73;
    bs[4] = (byte)73;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1299533049131416871uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03390()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[5];
    bs[0] = (byte)71;
    bs[1] = (byte)73;
    bs[2] = (byte)70;
    bs[3] = (byte)70;
    bs[4] = (byte)70;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(8852259495319690114uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("image/gif", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.FrontCover, ((Picture)attachment).Type);
    Assert.AreEqual<string>("cover.gif", ((Picture)attachment).Filename);
    Assert.AreEqual<string>("cover.gif", ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03897()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[5];
    bs[0] = (byte)66;
    bs[1] = (byte)77;
    bs[2] = (byte)77;
    bs[3] = (byte)77;
    bs[4] = (byte)77;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(4207897009794616192uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("image/bmp", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.FrontCover, ((Picture)attachment).Type);
    Assert.AreEqual<string>("cover.bmp", ((Picture)attachment).Filename);
    Assert.AreEqual<string>("cover.bmp", ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest0315()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    bs[0] = (byte)byte.MaxValue;
    bs[1] = (byte)216;
    bs[2] = (byte)216;
    bs[3] = (byte)216;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(6545562539721818532uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03724()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    bs[0] = (byte)byte.MaxValue;
    bs[1] = (byte)216;
    bs[2] = (byte)byte.MaxValue;
    bs[3] = (byte)byte.MaxValue;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(242564094482902240uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>
        (PictureType.NotAPicture, ((Picture)attachment).Type);
    Assert.AreEqual<string>("UnknownType", ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}

[TestMethod]
[PexGeneratedBy(typeof(AttachmentTest))]
public void ConstructorTest03523()
{
    ByteVector byteVector;
    Attachment attachment;
    byte[] bs = new byte[4];
    bs[0] = (byte)byte.MaxValue;
    bs[1] = (byte)216;
    bs[2] = (byte)byte.MaxValue;
    bs[3] = (byte)224;
    byteVector = new ByteVector(bs, 4);
    attachment = this.ConstructorTest03(byteVector);
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(1646549270564839979uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>("image/jpeg", ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.FrontCover, ((Picture)attachment).Type);
    Assert.AreEqual<string>("cover.jpg", ((Picture)attachment).Filename);
    Assert.AreEqual<string>("cover.jpg", ((Picture)attachment).Description);
    Assert.IsNotNull(((Picture)attachment).Data);
    Assert.AreEqual<bool>(false, ((Picture)attachment).Data.IsSynchronized);
    Assert.IsNotNull(((Picture)attachment).Data.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (((Picture)attachment).Data.SyncRoot, ((Picture)attachment).Data));
}
	}
}
