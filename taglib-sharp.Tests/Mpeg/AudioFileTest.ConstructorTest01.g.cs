using Microsoft.VisualStudio.TestTools.UnitTesting;
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
	public partial class AudioFileTest
	{

[TestMethod]
[PexGeneratedBy(typeof(AudioFileTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ConstructorTest01ThrowsArgumentNullException534()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      AudioFile audioFile;
      audioFile = this.ConstructorTest01((string)null);
      disposables.Add((IDisposable)audioFile);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(AudioFileTest))]
[PexRaisedException(typeof(ArgumentException))]
public void ConstructorTest01ThrowsArgumentException369()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      AudioFile audioFile;
      audioFile = this.ConstructorTest01("");
      disposables.Add((IDisposable)audioFile);
      disposables.Dispose();
    }
}
	}
}
