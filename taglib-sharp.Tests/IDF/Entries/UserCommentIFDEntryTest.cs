using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Entries;

namespace TagLib.IFD.Entries.Tests
{
    /// <summary>This class contains parameterized unit tests for UserCommentIFDEntry</summary>
    [TestClass]
    [PexClass(typeof(UserCommentIFDEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UserCommentIFDEntryTest
    {

		/// <summary>Test stub for .ctor(UInt16, String)</summary>
		[PexMethod]
		public UserCommentIFDEntry ConstructorTest(ushort tag, string value)
		{
			UserCommentIFDEntry target = new UserCommentIFDEntry(tag, value);
			return target;
			// TODO: add assertions to method UserCommentIFDEntryTest.ConstructorTest(UInt16, String)
		}

		/// <summary>Test stub for .ctor(UInt16, ByteVector, File)</summary>
		[PexMethod]
		public UserCommentIFDEntry ConstructorTest01(
			ushort tag,
			ByteVector data,
			File file
		)
		{
			UserCommentIFDEntry target = new UserCommentIFDEntry(tag, data, file);
			return target;
			// TODO: add assertions to method UserCommentIFDEntryTest.ConstructorTest01(UInt16, ByteVector, File)
		}

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]UserCommentIFDEntry target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method UserCommentIFDEntryTest.RenderTest(UserCommentIFDEntry, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
