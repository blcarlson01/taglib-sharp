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
public void FindTest_NoFileThrowsArgumentNullException783()
{
    AudioHeader audioHeader = (AudioHeader)null;
    this.FindTest_NoFile(out audioHeader, (File)null, 0L, 0);
}
	}
}
