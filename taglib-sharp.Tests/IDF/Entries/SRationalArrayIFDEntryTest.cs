using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for SRationalArrayIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(SRationalArrayIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SRationalArrayIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, SRational[])</summary>
		[PexMethod]
		public SRationalArrayIFDEntry ConstructorTest(ushort tag, SRational[] entries)
		{
			SRationalArrayIFDEntry target = new SRationalArrayIFDEntry(tag, entries);
			return target;
			// TODO: add assertions to method SRationalArrayIFDEntryTest.ConstructorTest(UInt16, SRational[])
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]SRationalArrayIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method SRationalArrayIFDEntryTest.RenderTest(SRationalArrayIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
