using TagLib;
using TagLib.IFD;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for SubIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(SubIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SubIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, UInt16, UInt32, IFDStructure)</summary>
		[PexMethod]
		public SubIFDEntry ConstructorTest(
			ushort tag,
			ushort type,
			uint count,
			IFDStructure structure
		)
		{
			SubIFDEntry target = new SubIFDEntry(tag, type, count, structure);
			return target;
			// TODO: add assertions to method SubIFDEntryTest.ConstructorTest(UInt16, UInt16, UInt32, IFDStructure)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]SubIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method SubIFDEntryTest.RenderTest(SubIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}

		/// <summary>Test stub for get_ChildCount()</summary>
		[PexMethod]
		public int ChildCountGetTest([PexAssumeUnderTest]SubIFDEntry target)
		{
			int result = target.ChildCount;
			return result;
			// TODO: add assertions to method SubIFDEntryTest.ChildCountGetTest(SubIFDEntry)
		}
	}
}
