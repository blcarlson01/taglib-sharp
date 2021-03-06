using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Mpeg4;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Mpeg4.Tests
{
	public partial class IsoHandlerBoxTest
	{

[TestMethod]
[PexGeneratedBy(typeof(IsoHandlerBoxTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest01ThrowsArgumentNullException163()
{
    IsoHandlerBox isoHandlerBox;
    isoHandlerBox = this.ConstructorTest01((ByteVector)null, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(IsoHandlerBoxTest))]
[ExpectedException(typeof(ArgumentException))]
public void ConstructorTest01ThrowsArgumentException202()
{
    ByteVector byteVector;
    IsoHandlerBox isoHandlerBox;
    byte[] bs = new byte[0];
    byteVector = new ByteVector(bs, 0);
    isoHandlerBox = this.ConstructorTest01(byteVector, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(IsoHandlerBoxTest))]
public void ConstructorTest01862()
{
    ByteVector byteVector;
    IsoHandlerBox isoHandlerBox;
    byte[] bs = new byte[6];
    byteVector = new ByteVector(bs, 4);
    isoHandlerBox = this.ConstructorTest01(byteVector, (string)null);
    Assert.IsNotNull((object)isoHandlerBox);
    Assert.IsNotNull(isoHandlerBox.HandlerType);
    Assert.AreEqual<bool>(false, isoHandlerBox.HandlerType.IsSynchronized);
    Assert.IsNotNull(isoHandlerBox.HandlerType.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals
                      (isoHandlerBox.HandlerType.SyncRoot, isoHandlerBox.HandlerType));
    Assert.AreEqual<string>((string)null, isoHandlerBox.Name);
    Assert.AreEqual<uint>(0u, ((FullBox)isoHandlerBox).Version);
    Assert.AreEqual<uint>(0u, ((FullBox)isoHandlerBox).Flags);
    Assert.IsNull(((Box)isoHandlerBox).Handler);
}
	}
}
