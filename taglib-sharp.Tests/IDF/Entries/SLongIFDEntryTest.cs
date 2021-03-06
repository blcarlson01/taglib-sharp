using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for SLongIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(SLongIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SLongIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, Int32)</summary>
		[PexMethod]
		public SLongIFDEntry ConstructorTest(ushort tag, int value)
		{
			SLongIFDEntry target = new SLongIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method SLongIFDEntryTest.ConstructorTest(UInt16, Int32)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]SLongIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method SLongIFDEntryTest.RenderTest(SLongIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
