using Microsoft.Pex.Framework.Exceptions;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Ape;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Ape.Tests
{
	public partial class TagTest
	{


[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(IndexOutOfRangeException))]
public void FullTagAndClearThrowsIndexOutOfRangeException892()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    string[] ss2 = new string[1];
    string[] ss3 = new string[1];
    Picture[] pictures = new Picture[1];
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = (PictureType)(-2147483628);
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    pictures[0] = s0;
    this.FullTagAndClear
        (tag, "\0", "\0", ss, ss1, ss2, "\0", ss3, 0u, 0u, 0u, 0u, 0u, "\0", 
         "\0", 0u, "\0", "\0", pictures, "\0", "\0", 
         "\0", "\0", "\0", "\0", "\0", "\0", "\0", "\0");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void FullTagAndClear29()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    string[] ss2 = new string[1];
    string[] ss3 = new string[1];
    Picture[] pictures = new Picture[1];
    Picture s0 = new Picture();
    s0.MimeType = (string)null;
    s0.Type = (PictureType)21;
    s0.Filename = (string)null;
    s0.Description = (string)null;
    s0.Data = (ByteVector)null;
    pictures[0] = s0;
    this.FullTagAndClear
        (tag, "\0", "\0", ss, ss1, ss2, "\0", ss3, 0u, 0u, 0u, 0u, 0u, "\0", 
         "\0", 0u, "\0", "\0", pictures, "\0", "\0", 
         "\0", "\0", "\0", "\0", "\0", "\0", "\0", "\0");
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagAndClearThrowsNullReferenceException676()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    string[] ss2 = new string[1];
    string[] ss3 = new string[1];
    Picture[] pictures = new Picture[1];
    this.FullTagAndClear
        (tag, "Albu", "A", ss, ss1, ss2, "Albu", ss3, 0u, 0u, 0u, 0u, 0u, "A", 
         "A", 0u, "A", "A", pictures, "A", "Albu", 
         "A", "A", "A", "A", "A", "A", "A", "A");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void FullTagAndClear920()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    string[] ss2 = new string[1];
    string[] ss3 = new string[1];
    Picture[] pictures = new Picture[0];
    this.FullTagAndClear
        (tag, "Albu", "A", ss, ss1, ss2, "Albu", ss3, 0u, 0u, 0u, 0u, 0u, "A", 
         "A", 0u, "A", "A", pictures, "A", "Albu", 
         "A", "A", "A", "A", "A", "A", "A", "A");
    Assert.IsNotNull((object)tag);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagAndClearThrowsNullReferenceException732()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    string[] ss2 = new string[1];
    string[] ss3 = new string[1];
    Picture[] pictures = new Picture[1];
    this.FullTagAndClear
        (tag, "Albu", "A", ss, ss1, ss2, "Albu", ss3, 0u, 0u, 0u, 0u, 1u, "A", 
         "A", 0u, "A", "A", pictures, "A", "Albu", 
         "A", "A", "A", "A", "A", "A", "A", "A");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagAndClearThrowsNullReferenceException869()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    string[] ss2 = new string[1];
    string[] ss3 = new string[1];
    Picture[] pictures = new Picture[1];
    this.FullTagAndClear
        (tag, "Albu", "A", ss, ss1, ss2, "Albu", ss3, 1u, 0u, 0u, 0u, 0u, "A", 
         "A", 0u, "A", "A", pictures, "A", "Albu", 
         "A", "A", "A", "A", "A", "A", "A", "A");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void FullTagAndClearThrowsNullReferenceException705()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    string[] ss2 = new string[1];
    string[] ss3 = new string[1];
    Picture[] pictures = new Picture[1];
    this.FullTagAndClear
        (tag, "Albu", "A", ss, ss1, ss2, "Albu", ss3, 520u, 0u, 0u, 0u, 0u, "A", 
         "A", 0u, "A", "A", pictures, "A", "Albu", 
         "A", "A", "A", "A", "A", "A", "A", "A");
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
public void FullTagAndClear383()
{
    Tag tag;
    tag = TagFactory.Create();
    string[] ss = new string[1];
    string[] ss1 = new string[1];
    string[] ss2 = new string[1];
    string[] ss3 = new string[1];
    Picture[] pictures = new Picture[0];
    this.FullTagAndClear
        (tag, "Albu", "A", ss, ss1, ss2, "Albu", ss3, 0u, 0u, 0u, 0u, 1u, "A", 
         "A", 0u, "A", "A", pictures, "A", "Albu", 
         "A", "A", "A", "A", "A", "A", "A", "A");
    Assert.IsNotNull((object)tag);
}
	}
}
