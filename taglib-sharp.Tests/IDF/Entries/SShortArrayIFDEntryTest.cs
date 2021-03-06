using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for SShortArrayIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(SShortArrayIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SShortArrayIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, Int16[])</summary>
		[PexMethod]
		public SShortArrayIFDEntry ConstructorTest(ushort tag, short[] values)
		{
			SShortArrayIFDEntry target = new SShortArrayIFDEntry(tag, values);
			return target;
			// TODO: add assertions to method SShortArrayIFDEntryTest.ConstructorTest(UInt16, Int16[])
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]SShortArrayIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method SShortArrayIFDEntryTest.RenderTest(SShortArrayIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
