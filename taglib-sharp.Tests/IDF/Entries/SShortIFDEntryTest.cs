using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for SShortIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(SShortIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SShortIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, UInt16)</summary>
		[PexMethod]
		public SShortIFDEntry ConstructorTest(ushort tag, ushort value)
		{
			SShortIFDEntry target = new SShortIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method SShortIFDEntryTest.ConstructorTest(UInt16, UInt16)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]SShortIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method SShortIFDEntryTest.RenderTest(SShortIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
