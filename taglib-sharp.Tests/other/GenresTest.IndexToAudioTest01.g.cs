using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Tests
{
	public partial class GenresTest
	{

[TestMethod]
[PexGeneratedBy(typeof(GenresTest))]
public void IndexToAudioTest0113()
{
    string s;
    s = this.IndexToAudioTest01((string)null);
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(GenresTest))]
public void IndexToAudioTest01223()
{
    string s;
    s = this.IndexToAudioTest01("");
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(GenresTest))]
public void IndexToAudioTest01162()
{
    string s;
    s = this.IndexToAudioTest01("\0");
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(GenresTest))]
public void IndexToAudioTest01705()
{
    string s;
    s = this.IndexToAudioTest01("2");
    Assert.AreEqual<string>("Country", s);
}

[TestMethod]
[PexGeneratedBy(typeof(GenresTest))]
public void IndexToAudioTest01464()
{
    string s;
    s = this.IndexToAudioTest01("\0\0\0");
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(GenresTest))]
public void IndexToAudioTest01778()
{
    string s;
    s = this.IndexToAudioTest01("(\0\0");
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(GenresTest))]
public void IndexToAudioTest01633()
{
    string s;
    s = this.IndexToAudioTest01("()\0");
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(GenresTest))]
public void IndexToAudioTest01948()
{
    string s;
    s = this.IndexToAudioTest01("(\0)");
    Assert.AreEqual<string>((string)null, s);
}

[TestMethod]
[PexGeneratedBy(typeof(GenresTest))]
public void IndexToAudioTest01274()
{
    string s;
    s = this.IndexToAudioTest01("(2)");
    Assert.AreEqual<string>("Country", s);
}
	}
}
