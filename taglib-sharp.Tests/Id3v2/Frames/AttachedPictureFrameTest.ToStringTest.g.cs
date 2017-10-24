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
public void ToStringTest852()
{
    AttachedPictureFrame attachedPictureFrame;
    string s;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)32;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    s = this.ToStringTest(attachedPictureFrame);
    Assert.AreEqual<string>(" [] 0 bytes", s);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void ToStringTest85201()
{
    AttachedPictureFrame attachedPictureFrame;
    string s;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = "";
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)0;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    s = this.ToStringTest(attachedPictureFrame);
    Assert.AreEqual<string>(" [] 0 bytes", s);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void ToStringTest85202()
{
    AttachedPictureFrame attachedPictureFrame;
    string s;
    Picture s0 = new Picture();
    s0.MimeType = "";
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)0;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    s = this.ToStringTest(attachedPictureFrame);
    Assert.AreEqual<string>(" [] 0 bytes", s);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void ToStringTest640()
{
    AttachedPictureFrame attachedPictureFrame;
    string s;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = "\0";
    s0.Data = (ByteVector)null;
    attachedPictureFrame = new AttachedPictureFrame((IPicture)s0);
    ((Frame)attachedPictureFrame).GroupId = (short)0;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    s = this.ToStringTest(attachedPictureFrame);
    Assert.AreEqual<string>("[] 0 bytes", s);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void ToStringTest85203()
{
    Picture picture;
    AttachedPictureFrame attachedPictureFrame;
    string s;
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = PictureType.Other;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    picture = new Picture((IPicture)s0);
    attachedPictureFrame = new AttachedPictureFrame((IPicture)picture);
    ((Frame)attachedPictureFrame).GroupId = (short)32;
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    s = this.ToStringTest(attachedPictureFrame);
    Assert.AreEqual<string>(" [] 0 bytes", s);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}

[TestMethod]
[PexGeneratedBy(typeof(AttachedPictureFrameTest))]
public void ToStringTest85204()
{
    ByteVector byteVector;
    AttachedPictureFrame attachedPictureFrame;
    string s;
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
    ((Frame)attachedPictureFrame).EncryptionId = (short)short.MinValue;
    s = this.ToStringTest(attachedPictureFrame);
    Assert.AreEqual<string>(" [] 0 bytes", s);
    Assert.IsNotNull((object)attachedPictureFrame);
    Assert.AreEqual<string>((string)null, attachedPictureFrame.Filename);
}
	}
}
