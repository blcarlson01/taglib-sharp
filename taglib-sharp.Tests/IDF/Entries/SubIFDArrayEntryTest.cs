using TagLib;
using System.Collections.Generic;
using TagLib.IFD;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for SubIFDArrayEntry</summary>
    [TestClass]
    [PexClass(typeof(SubIFDArrayEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SubIFDArrayEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, List`1&lt;IFDStructure&gt;)</summary>
		[PexMethod]
		public SubIFDArrayEntry ConstructorTest(ushort tag, List<IFDStructure> entries)
		{
			SubIFDArrayEntry target = new SubIFDArrayEntry(tag, entries);
			return target;
			// TODO: add assertions to method SubIFDArrayEntryTest.ConstructorTest(UInt16, List`1<IFDStructure>)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]SubIFDArrayEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method SubIFDArrayEntryTest.RenderTest(SubIFDArrayEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
