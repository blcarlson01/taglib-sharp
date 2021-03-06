using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for StringIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(StringIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StringIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, String)</summary>
		[PexMethod]
		public StringIFDEntry ConstructorTest(ushort tag, string value)
		{
			StringIFDEntry target = new StringIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method StringIFDEntryTest.ConstructorTest(UInt16, String)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]StringIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method StringIFDEntryTest.RenderTest(StringIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
