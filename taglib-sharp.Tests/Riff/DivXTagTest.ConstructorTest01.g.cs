using TagLib;
using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Riff.Tests
{
	public partial class DivXTagTest
	{

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[ExpectedException(typeof(CorruptFileException))]
public void ConstructorTest01ThrowsCorruptFileException828()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      DivXTag divXTag;
      file = RiffFileFactory.Create();
      disposables.Add((IDisposable)file);
      divXTag = this.ConstructorTest01(file, 0L);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(DivXTagTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ConstructorTest01ThrowsArgumentOutOfRangeException194()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      DivXTag divXTag;
      file = RiffFileFactory.Create();
      disposables.Add((IDisposable)file);
      divXTag = this.ConstructorTest01(file, long.MinValue);
      disposables.Dispose();
    }
}
	}
}
