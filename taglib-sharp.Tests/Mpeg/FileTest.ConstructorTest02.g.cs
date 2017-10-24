using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;
using TagLib.Mpeg;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Mpeg.Tests
{
	public partial class FileTest
	{

[TestMethod]
[PexGeneratedBy(typeof(FileTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest02ThrowsArgumentNullException495()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      file = this.ConstructorTest02((File.IFileAbstraction)null, ReadStyle.None);
      disposables.Add((IDisposable)file);
      disposables.Dispose();
    }
}
	}
}
