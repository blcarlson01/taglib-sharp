using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Jpeg;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Jpeg.Tests
{
	public partial class FileTest
	{

[TestMethod]
[PexGeneratedBy(typeof(FileTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTestThrowsArgumentNullException851()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      file = this.ConstructorTest((string)null, ReadStyle.None);
      disposables.Add((IDisposable)file);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(FileTest))]
[PexRaisedException(typeof(ArgumentException))]
public void ConstructorTestThrowsArgumentException927()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      file = this.ConstructorTest("", ReadStyle.None);
      disposables.Add((IDisposable)file);
      disposables.Dispose();
    }
}
	}
}
