using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for SLongArrayIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(SLongArrayIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SLongArrayIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, Int32[])</summary>
		[PexMethod]
		public SLongArrayIFDEntry ConstructorTest(ushort tag, int[] values)
		{
			SLongArrayIFDEntry target = new SLongArrayIFDEntry(tag, values);
			return target;
			// TODO: add assertions to method SLongArrayIFDEntryTest.ConstructorTest(UInt16, Int32[])
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]SLongArrayIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method SLongArrayIFDEntryTest.RenderTest(SLongArrayIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
