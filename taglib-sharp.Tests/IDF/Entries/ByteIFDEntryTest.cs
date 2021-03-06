using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for ByteIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(ByteIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ByteIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, Byte)</summary>
		[PexMethod]
		public ByteIFDEntry ConstructorTest(ushort tag, byte value)
		{
			ByteIFDEntry target = new ByteIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method ByteIFDEntryTest.ConstructorTest(UInt16, Byte)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]ByteIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method ByteIFDEntryTest.RenderTest(ByteIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
