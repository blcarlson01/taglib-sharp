using TagLib;
using TagLib.IFD;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for MakernoteIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(MakernoteIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MakernoteIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, IFDStructure, MakernoteType, ByteVector, UInt32, Boolean, Nullable`1&lt;Boolean&gt;)</summary>
		[PexMethod]
		public MakernoteIFDEntry ConstructorTest(
			ushort tag,
			IFDStructure structure,
			MakernoteType makernote_type,
			ByteVector prefix,
			uint ifd_offset,
			bool absolute_offset,
			bool? is_bigendian
		)
		{
			MakernoteIFDEntry target = new MakernoteIFDEntry
										   (tag, structure, makernote_type, prefix, ifd_offset, absolute_offset, is_bigendian);
			return target;
			// TODO: add assertions to method MakernoteIFDEntryTest.ConstructorTest(UInt16, IFDStructure, MakernoteType, ByteVector, UInt32, Boolean, Nullable`1<Boolean>)
		}

		/// <summary>Test stub for .ctor(UInt16, IFDStructure, MakernoteType)</summary>
		[PexMethod]
		public MakernoteIFDEntry ConstructorTest01(
			ushort tag,
			IFDStructure structure,
			MakernoteType makernote_type
		)
		{
			MakernoteIFDEntry target = new MakernoteIFDEntry(tag, structure, makernote_type);
			return target;
			// TODO: add assertions to method MakernoteIFDEntryTest.ConstructorTest01(UInt16, IFDStructure, MakernoteType)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]MakernoteIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method MakernoteIFDEntryTest.RenderTest(MakernoteIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
