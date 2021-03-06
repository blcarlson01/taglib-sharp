using TagLib.Id3v2;
using TagLib.Flac;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Asf;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Asf.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest704()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    this.PicturesSetTest(tag, (IPicture[])null);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest578()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    IPicture[] iPictures = new IPicture[0];
    this.PicturesSetTest(tag, iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void PicturesSetTestThrowsNullReferenceException98()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    IPicture[] iPictures = new IPicture[1];
    this.PicturesSetTest(tag, iPictures);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void PicturesSetTestThrowsNullReferenceException677()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    IPicture[] iPictures = new IPicture[1];
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    iPictures[0] = (IPicture)s0;
    this.PicturesSetTest(tag, iPictures);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(OverflowException))]
public void PicturesSetTestThrowsOverflowException411()
{
    Tag tag;
    tag = TagFactory.Create((HeaderObject)null);
    IPicture[] iPictures = new IPicture[1];
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = (PictureType)256;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    iPictures[0] = (IPicture)s0;
    this.PicturesSetTest(tag, iPictures);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void PicturesSetTestThrowsNullReferenceException182()
{
    Tag tag;
    Picture picture;
    tag = TagFactory.Create((HeaderObject)null);
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    IPicture[] iPictures = new IPicture[1];
    iPictures[0] = (IPicture)picture;
    this.PicturesSetTest(tag, iPictures);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void PicturesSetTestThrowsNullReferenceException18201()
{
    Tag tag;
    Picture picture;
    Picture picture1;
    tag = TagFactory.Create((HeaderObject)null);
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    picture1 = new Picture((IPicture)picture);
    IPicture[] iPictures = new IPicture[1];
    iPictures[0] = (IPicture)picture1;
    this.PicturesSetTest(tag, iPictures);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest38705()
{
    Tag tag;
    AttachedPictureFrame attachedPictureFrame;
    tag = TagFactory.Create((HeaderObject)null);
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)32;
    ((Frame)attachedPictureFrame).EncryptionId = (short)512;
    IPicture[] iPictures = new IPicture[1];
    iPictures[0] = (IPicture)attachedPictureFrame;
    this.PicturesSetTest(tag, iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest38706()
{
    Tag tag;
    AttachedPictureFrame attachedPictureFrame;
    tag = TagFactory.Create((HeaderObject)null);
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)0;
    ((Frame)attachedPictureFrame).EncryptionId = (short)256;
    IPicture[] iPictures = new IPicture[1];
    iPictures[0] = (IPicture)attachedPictureFrame;
    this.PicturesSetTest(tag, iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest38707()
{
    Tag tag;
    AttachedPictureFrame attachedPictureFrame;
    tag = TagFactory.Create((HeaderObject)null);
    Picture s0 = new Picture();
    s0.MimeType = "\0";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)0;
    ((Frame)attachedPictureFrame).EncryptionId = (short)256;
    IPicture[] iPictures = new IPicture[1];
    iPictures[0] = (IPicture)attachedPictureFrame;
    this.PicturesSetTest(tag, iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest38708()
{
    Tag tag;
    AttachedPictureFrame attachedPictureFrame;
    tag = TagFactory.Create((HeaderObject)null);
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = "";
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)0;
    ((Frame)attachedPictureFrame).EncryptionId = (short)256;
    IPicture[] iPictures = new IPicture[1];
    iPictures[0] = (IPicture)attachedPictureFrame;
    this.PicturesSetTest(tag, iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void PicturesSetTestThrowsNullReferenceException349()
{
    Tag tag;
    ByteVector byteVector;
    tag = TagFactory.Create((HeaderObject)null);
    byte[] bs = new byte[2];
    byteVector = ByteVectorFactory.Create(bs, 1);
    IPicture[] iPictures = new IPicture[2];
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = byteVector;
    iPictures[0] = (IPicture)s0;
    Picture s1 = new Picture();
    s1.MimeType = (string)null;
    s1.Type = PictureType.Other;
    s1.Filename = (string)null;
    s1.Description = (string)null;
    s1.Data = (ByteVector)null;
    iPictures[1] = (IPicture)s1;
    this.PicturesSetTest(tag, iPictures);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(OverflowException))]
public void PicturesSetTestThrowsOverflowException877()
{
    Tag tag;
    ByteVector byteVector;
    tag = TagFactory.Create((HeaderObject)null);
    byte[] bs = new byte[7];
    byteVector = ByteVectorFactory.Create(bs, 6);
    IPicture[] iPictures = new IPicture[2];
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = "\0\0\0\0";
    s0.Data = byteVector;
    iPictures[0] = (IPicture)s0;
    Picture s1 = new Picture();
    s1.MimeType = (string)null;
    s1.Type = (PictureType)256;
    s1.Filename = (string)null;
    s1.Description = (string)null;
    s1.Data = (ByteVector)null;
    iPictures[1] = (IPicture)s1;
    this.PicturesSetTest(tag, iPictures);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest38709()
{
    Tag tag;
    AttachedPictureFrame attachedPictureFrame;
    tag = TagFactory.Create((HeaderObject)null);
    Picture s0 = new Picture();
    s0.MimeType = "\0";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = "\0";
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)short.MinValue;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    IPicture[] iPictures = new IPicture[1];
    iPictures[0] = (IPicture)attachedPictureFrame;
    this.PicturesSetTest(tag, iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest611()
{
    Tag tag;
    ByteVector byteVector;
    tag = TagFactory.Create((HeaderObject)null);
    byte[] bs = new byte[6];
    byteVector = ByteVectorFactory.Create(bs, 5);
    IPicture[] iPictures = new IPicture[1];
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = byteVector;
    iPictures[0] = (IPicture)s0;
    this.PicturesSetTest(tag, iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest258()
{
    Tag tag;
    Picture picture;
    Picture picture1;
    AttachedPictureFrame attachedPictureFrame;
    AttachedPictureFrame attachedPictureFrame1;
    Picture picture2;
    tag = TagFactory.Create((HeaderObject)null);
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    picture1 = new Picture((IPicture)picture);
    attachedPictureFrame = new AttachedPictureFrame((IPicture)picture1);
    ((Frame)attachedPictureFrame).GroupId = (short)32;
    ((Frame)attachedPictureFrame).EncryptionId = (short)256;
    attachedPictureFrame1 = new AttachedPictureFrame((IPicture)attachedPictureFrame);
    ((Frame)attachedPictureFrame1).GroupId = (short)32;
    ((Frame)attachedPictureFrame1).EncryptionId = (short)short.MinValue;
    picture2 = new Picture((IPicture)attachedPictureFrame1);
    IPicture[] iPictures = new IPicture[1];
    iPictures[0] = (IPicture)picture2;
    this.PicturesSetTest(tag, iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void PicturesSetTest25201()
{
    Tag tag;
    AttachedPictureFrame attachedPictureFrame;
    ByteVector byteVector;
    tag = TagFactory.Create((HeaderObject)null);
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = "";
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)short.MinValue;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    byte[] bs = new byte[2];
    byteVector = ByteVectorFactory.Create(bs, 1);
    IPicture[] iPictures = new IPicture[2];
    iPictures[0] = (IPicture)attachedPictureFrame;
    Picture s1 = new Picture();
    s1.MimeType = (string)null;
    s1.Type = PictureType.Other;
    s1.Filename = (string)null;
    s1.Description = (string)null;
    s1.Data = byteVector;
    iPictures[1] = (IPicture)s1;
    this.PicturesSetTest(tag, iPictures);
    Assert.IsNotNull((object)tag);
    Assert.IsNotNull(tag.ContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.ExtendedContentDescriptionObject);
    Assert.AreEqual<ulong>(0uL, tag.ExtendedContentDescriptionObject.OriginalSize);
    Assert.IsNotNull(tag.MetadataLibraryObject);
    Assert.AreEqual<ulong>(0uL, tag.MetadataLibraryObject.OriginalSize);
}
	}
}
