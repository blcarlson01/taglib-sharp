using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Aac;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Aac.Tests
{
	public partial class AudioHeaderTest
	{

[TestMethod]
[PexGeneratedBy(typeof(AudioHeaderTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void FindTestThrowsArgumentNullException23()
{
    bool b;
    AudioHeader audioHeader = (AudioHeader)null;
    b = this.FindTest(out audioHeader, (File)null, 0L, 0);
}
	}
}
