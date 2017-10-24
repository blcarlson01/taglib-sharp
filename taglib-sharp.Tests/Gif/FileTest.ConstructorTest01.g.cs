using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Gif;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Gif.Tests
{
	public partial class FileTest
	{

[TestMethod]
[PexGeneratedBy(typeof(FileTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest01ThrowsArgumentNullException46()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      file = this.ConstructorTest01((string)null);
      disposables.Add((IDisposable)file);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(FileTest))]
[PexRaisedException(typeof(ArgumentException))]
public void ConstructorTest01ThrowsArgumentException577()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      file = this.ConstructorTest01("");
      disposables.Add((IDisposable)file);
      disposables.Dispose();
    }
}
	}
}
