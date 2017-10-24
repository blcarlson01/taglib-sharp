using TagLib;
using TagLib.Image;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Image.NoMetadata;
using Microsoft.Pex.Framework.Generated;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TagLib.Image.NoMetadata.Tests
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
public void ConstructorTest0183()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      File file;
      file = this.ConstructorTest01("");
      disposables.Add((IDisposable)file);
      disposables.Dispose();
      Assert.IsNotNull((object)file);
      Assert.IsNotNull(((File)file).ImageTag);
      Assert.IsNull(((File)file).ImageTag.Exif);
      Assert.IsNull(((File)file).ImageTag.Xmp);
      Assert.IsNotNull(((File)file).ImageTag.OtherTags);
      Assert.AreEqual<int>(0, ((File)file).ImageTag.OtherTags.Capacity);
      Assert.AreEqual<int>(0, ((File)file).ImageTag.OtherTags.Count);
      Assert.AreEqual<TagTypes>(TagTypes.None, ((File)file).TagTypesOnDisk);
      Assert.AreEqual<string>((string)null, ((File)file).MimeType);
      Assert.AreEqual<long>(-1L, ((File)file).InvariantStartPosition);
      Assert.AreEqual<long>(-1L, ((File)file).InvariantEndPosition);
      Assert.AreEqual<bool>(false, ((File)file).PossiblyCorrupt);
      Assert.IsNull(((File)file).CorruptionReasons);
    }
}
	}
}
