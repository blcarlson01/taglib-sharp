using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for SRationalIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(SRationalIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SRationalIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, SRational)</summary>
		[PexMethod]
		public SRationalIFDEntry ConstructorTest(ushort tag, SRational value)
		{
			SRationalIFDEntry target = new SRationalIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method SRationalIFDEntryTest.ConstructorTest(UInt16, SRational)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]SRationalIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method SRationalIFDEntryTest.RenderTest(SRationalIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
