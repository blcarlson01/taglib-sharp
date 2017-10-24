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
public void CloneTest47()
{
    AttachedPictureFrame attachedPictureFrame;
    Frame frame;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)32;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    frame = this.CloneTest(attachedPictureFrame);
    Assert.IsNotNull((object)frame);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void CloneTest4701()
{
    ByteVector byteVector;
    AttachedPictureFrame attachedPictureFrame;
    Frame frame;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = byteVector;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)0;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    frame = this.CloneTest(attachedPictureFrame);
    Assert.IsNotNull((object)frame);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void CloneTest4702()
{
    ByteVector byteVector;
    AttachedPictureFrame attachedPictureFrame;
    Frame frame;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 1);
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = byteVector;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)256;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    frame = this.CloneTest(attachedPictureFrame);
    Assert.IsNotNull((object)frame);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void CloneTest4703()
{
    Picture picture;
    Picture picture1;
    AttachedPictureFrame attachedPictureFrame;
    Frame frame;
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
    ((Frame)attachedPictureFrame).EncryptionId = (short)2048;
    frame = this.CloneTest(attachedPictureFrame);
    Assert.IsNotNull((object)frame);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}
	}
}
