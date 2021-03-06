using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for ThumbnailDataIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(ThumbnailDataIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ThumbnailDataIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, ByteVector)</summary>
		[PexMethod]
		public ThumbnailDataIFDEntry ConstructorTest(ushort tag, ByteVector data)
		{
			ThumbnailDataIFDEntry target = new ThumbnailDataIFDEntry(tag, data);
			return target;
			// TODO: add assertions to method ThumbnailDataIFDEntryTest.ConstructorTest(UInt16, ByteVector)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]ThumbnailDataIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method ThumbnailDataIFDEntryTest.RenderTest(ThumbnailDataIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
