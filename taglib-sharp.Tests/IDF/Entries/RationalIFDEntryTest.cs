using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for RationalIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(RationalIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class RationalIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, Rational)</summary>
		[PexMethod]
		public RationalIFDEntry ConstructorTest(ushort tag, Rational value)
		{
			RationalIFDEntry target = new RationalIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method RationalIFDEntryTest.ConstructorTest(UInt16, Rational)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]RationalIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method RationalIFDEntryTest.RenderTest(RationalIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
