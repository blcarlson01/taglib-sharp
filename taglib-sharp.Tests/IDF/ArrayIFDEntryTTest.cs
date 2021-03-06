using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;

namespace TagLib.IFD.Tests
{
    /// <summary>This class contains parameterized unit tests for ArrayIFDEntry`1</summary>
    [TestClass]
    [PexClass(typeof(ArrayIFDEntry<>))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ArrayIFDEntryTTest
    {

		/// <summary>Test stub for Render(Boolean, UInt32, UInt16&amp;, UInt32&amp;)</summary>
		[PexGenericArguments(typeof(int))]
		[PexMethod]
		public ByteVector RenderTest<T>(
			[PexAssumeNotNull]ArrayIFDEntry<T> target,
			bool is_bigendian,
			uint offset,
			out ushort type,
			out uint count
		)
		{
			ByteVector result = target.Render(is_bigendian, offset, out type, out count);
			return result;
			// TODO: add assertions to method ArrayIFDEntryTTest.RenderTest(ArrayIFDEntry`1<!!0>, Boolean, UInt32, UInt16&, UInt32&)
		}
	}
}
