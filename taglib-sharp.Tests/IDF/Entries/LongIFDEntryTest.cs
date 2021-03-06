using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for LongIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(LongIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class LongIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, UInt32)</summary>
		[PexMethod]
		public LongIFDEntry ConstructorTest(ushort tag, uint value)
		{
			LongIFDEntry target = new LongIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method LongIFDEntryTest.ConstructorTest(UInt16, UInt32)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]LongIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method LongIFDEntryTest.RenderTest(LongIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
