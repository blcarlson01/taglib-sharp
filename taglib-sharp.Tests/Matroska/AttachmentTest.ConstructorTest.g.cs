using Microsoft.Pex.Framework.Generated;
using TagLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
public void ConstructorTest37()
{
    Attachment attachment;
    attachment = this.ConstructorTest();
    Assert.IsNotNull((object)attachment);
    Assert.AreEqual<ulong>(4443110194151338453uL, attachment.UID);
    Assert.AreEqual<MatroskaID>(MatroskaID.TagAttachmentUID, attachment.UIDType);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).MimeType);
    Assert.AreEqual<PictureType>(PictureType.Other, ((Picture)attachment).Type);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Filename);
    Assert.AreEqual<string>((string)null, ((Picture)attachment).Description);
    Assert.IsNull(((Picture)attachment).Data);
}
	}
}
