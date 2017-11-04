using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ape;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Ape.Tests
{
	public partial class TagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest01ThrowsArgumentNullException553()
{
    Tag tag;
    tag = this.ConstructorTest01((File)null, 0L);
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest01ThrowsArgumentOutOfRangeException269()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      Tag tag;
      file = FileFactory.Create();
      disposables.Add((IDisposable)file);
      tag = this.ConstructorTest01(file, 0L);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TagTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest01ThrowsArgumentOutOfRangeException551()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      Tag tag;
      file = FileFactory.Create();
      disposables.Add((IDisposable)file);
      tag = this.ConstructorTest01(file, long.MinValue);
      disposables.Dispose();
    }
}
	}
}
