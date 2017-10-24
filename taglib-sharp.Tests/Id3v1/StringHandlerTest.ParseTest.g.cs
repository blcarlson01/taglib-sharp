using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Id3v1;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Id3v1.Tests
{
	public partial class StringHandlerTest
	{

[TestMethod]
[PexGeneratedBy(typeof(StringHandlerTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ParseTestThrowsArgumentNullException3()
{
    string s;
    StringHandler s0 = new StringHandler();
    s = this.ParseTest(s0, (ByteVector)null);
}

[TestMethod]
[PexGeneratedBy(typeof(StringHandlerTest))]
public void ParseTest396()
{
    ByteVector byteVector;
    string s;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    StringHandler s0 = new StringHandler();
    s = this.ParseTest(s0, byteVector);
    Assert.AreEqual<string>("", s);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(StringHandlerTest))]
public void ParseTest39601()
{
    ByteVector byteVector;
    string s;
    byte[] bs = new byte[1];
    byteVector = new ByteVector(bs, 1);
    StringHandler s0 = new StringHandler();
    s = this.ParseTest(s0, byteVector);
    Assert.AreEqual<string>("", s);
    Assert.IsNotNull((object)s0);
}
	}
}
