using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for ShortIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(ShortIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ShortIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, UInt16)</summary>
		[PexMethod]
		public ShortIFDEntry ConstructorTest(ushort tag, ushort value)
		{
			ShortIFDEntry target = new ShortIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method ShortIFDEntryTest.ConstructorTest(UInt16, UInt16)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]ShortIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method ShortIFDEntryTest.RenderTest(ShortIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
