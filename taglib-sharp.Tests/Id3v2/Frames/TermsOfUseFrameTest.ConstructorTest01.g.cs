using Microsoft.Pex.Framework.Generated;
using TagLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
	public partial class TermsOfUseFrameTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TermsOfUseFrameTest))]
public void ConstructorTest01135()
{
    TermsOfUseFrame termsOfUseFrame;
    termsOfUseFrame = this.ConstructorTest01((string)null);
    Assert.IsNotNull((object)termsOfUseFrame);
    Assert.AreEqual<StringType>(StringType.UTF8, termsOfUseFrame.TextEncoding);
    Assert.AreEqual<string>((string)null, termsOfUseFrame.Text);
}
	}
}
