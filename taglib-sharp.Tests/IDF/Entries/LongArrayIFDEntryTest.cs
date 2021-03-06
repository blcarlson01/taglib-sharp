using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for LongArrayIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(LongArrayIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class LongArrayIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, UInt32[])</summary>
		[PexMethod]
		public LongArrayIFDEntry ConstructorTest(ushort tag, uint[] values)
		{
			LongArrayIFDEntry target = new LongArrayIFDEntry(tag, values);
			return target;
			// TODO: add assertions to method LongArrayIFDEntryTest.ConstructorTest(UInt16, UInt32[])
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]LongArrayIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method LongArrayIFDEntryTest.RenderTest(LongArrayIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
