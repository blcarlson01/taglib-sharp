using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for UndefinedIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(UndefinedIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UndefinedIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, ByteVector)</summary>
		[PexMethod]
		public UndefinedIFDEntry ConstructorTest(ushort tag, ByteVector data)
		{
			UndefinedIFDEntry target = new UndefinedIFDEntry(tag, data);
			return target;
			// TODO: add assertions to method UndefinedIFDEntryTest.ConstructorTest(UInt16, ByteVector)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]UndefinedIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method UndefinedIFDEntryTest.RenderTest(UndefinedIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
