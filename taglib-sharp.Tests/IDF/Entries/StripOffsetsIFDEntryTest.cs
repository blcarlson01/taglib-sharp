using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for StripOffsetsIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(StripOffsetsIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StripOffsetsIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, UInt32[], UInt32[], File)</summary>
		[PexMethod]
		public StripOffsetsIFDEntry ConstructorTest(
			ushort tag,
			uint[] values,
			uint[] byte_counts,
			File file
		)
		{
			StripOffsetsIFDEntry target = new StripOffsetsIFDEntry(tag, values, byte_counts, file);
			return target;
			// TODO: add assertions to method StripOffsetsIFDEntryTest.ConstructorTest(UInt16, UInt32[], UInt32[], File)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]StripOffsetsIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method StripOffsetsIFDEntryTest.RenderTest(StripOffsetsIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
