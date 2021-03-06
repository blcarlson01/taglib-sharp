using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for SByteIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(SByteIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SByteIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, SByte)</summary>
		[PexMethod]
		public SByteIFDEntry ConstructorTest(ushort tag, sbyte value)
		{
			SByteIFDEntry target = new SByteIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method SByteIFDEntryTest.ConstructorTest(UInt16, SByte)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]SByteIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method SByteIFDEntryTest.RenderTest(SByteIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
