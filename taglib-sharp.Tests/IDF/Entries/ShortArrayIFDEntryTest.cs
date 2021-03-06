using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for ShortArrayIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(ShortArrayIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ShortArrayIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, UInt16[])</summary>
		[PexMethod]
		public ShortArrayIFDEntry ConstructorTest(ushort tag, ushort[] values)
		{
			ShortArrayIFDEntry target = new ShortArrayIFDEntry(tag, values);
			return target;
			// TODO: add assertions to method ShortArrayIFDEntryTest.ConstructorTest(UInt16, UInt16[])
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]ShortArrayIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method ShortArrayIFDEntryTest.RenderTest(ShortArrayIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
