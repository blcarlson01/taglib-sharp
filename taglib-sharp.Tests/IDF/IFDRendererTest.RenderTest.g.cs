using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.IFD;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.IFD.Tests
{
	public partial class IFDRendererTest
	{

[TestMethod]
[PexGeneratedBy(typeof(IFDRendererTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void RenderTestThrowsNullReferenceException131()
{
    IFDRenderer iFDRenderer;
    ByteVector byteVector;
    iFDRenderer = new IFDRenderer(false, (IFDStructure)null, 0u);
    byteVector = this.RenderTest(iFDRenderer);
}

[TestMethod]
[PexGeneratedBy(typeof(IFDRendererTest))]
public void RenderTest811()
{
    IFDStructure iFDStructure;
    IFDRenderer iFDRenderer;
    ByteVector byteVector;
    iFDStructure = new IFDStructure();
    iFDRenderer = new IFDRenderer(false, iFDStructure, 0u);
    byteVector = this.RenderTest(iFDRenderer);
    Assert.IsNotNull((object)byteVector);
    Assert.AreEqual<bool>(false, byteVector.IsSynchronized);
    Assert.IsNotNull(byteVector.SyncRoot);
    Assert.IsTrue(object.ReferenceEquals(byteVector.SyncRoot, (object)byteVector));
    Assert.IsNotNull((object)iFDRenderer);
}
	}
}
