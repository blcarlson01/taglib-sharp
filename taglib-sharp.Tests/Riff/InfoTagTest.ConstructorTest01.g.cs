using TagLib;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Riff.Tests
{
	public partial class InfoTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(InfoTagTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest01ThrowsArgumentNullException143()
{
    InfoTag infoTag;
    infoTag = this.ConstructorTest01((File)null, 0L, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(InfoTagTest))]
[Ignore]
[PexDescription("the test state was: path bounds exceeded")]
public void ConstructorTest0101()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      InfoTag infoTag;
      file = RiffFileFactory.Create();
      disposables.Add((IDisposable)file);
      infoTag = this.ConstructorTest01(file, 0L, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(InfoTagTest))]
[PexRaisedException(typeof(ArgumentNullException))]
public void ConstructorTestThrowsArgumentNullException720()
{
    InfoTag infoTag;
    infoTag = this.ConstructorTest((ByteVector)null);
}

[TestMethod]
[PexGeneratedBy(typeof(InfoTagTest))]
public void ConstructorTest872()
{
    ByteVector byteVector;
    InfoTag infoTag;
    byte[] bs = new byte[2];
    byteVector = ByteVectorFactory.Create(bs, 1);
    infoTag = this.ConstructorTest(byteVector);
    Assert.IsNotNull((object)infoTag);
}

[TestMethod]
[PexGeneratedBy(typeof(InfoTagTest))]
public void ConstructorTest87201()
{
    ByteVector byteVector;
    InfoTag infoTag;
    byte[] bs = new byte[12];
    byteVector = ByteVectorFactory.Create(bs, 9);
    infoTag = this.ConstructorTest(byteVector);
    Assert.IsNotNull((object)infoTag);
}

[TestMethod]
[PexGeneratedBy(typeof(InfoTagTest))]
public void ConstructorTest87202()
{
    ByteVector byteVector;
    InfoTag infoTag;
    byte[] bs = new byte[20];
    byteVector = ByteVectorFactory.Create(bs, 17);
    infoTag = this.ConstructorTest(byteVector);
    Assert.IsNotNull((object)infoTag);
}
	}
}
