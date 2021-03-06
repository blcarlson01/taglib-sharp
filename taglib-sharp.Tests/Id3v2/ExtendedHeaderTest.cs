using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for ExtendedHeader</summary>
    [TestClass]
    [PexClass(typeof(ExtendedHeader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ExtendedHeaderTest
    {

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public ExtendedHeader ConstructorTest(ByteVector data, byte version)
		{
			ExtendedHeader target = new ExtendedHeader(data, version);
			return target;
			// TODO: add assertions to method ExtendedHeaderTest.ConstructorTest(ByteVector, Byte)
		}

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public ExtendedHeader CloneTest([PexAssumeUnderTest]ExtendedHeader target)
		{
			ExtendedHeader result = target.Clone();
			return result;
			// TODO: add assertions to method ExtendedHeaderTest.CloneTest(ExtendedHeader)
		}

		/// <summary>Test stub for get_Size()</summary>
		[PexMethod]
		public uint SizeGetTest([PexAssumeUnderTest]ExtendedHeader target)
		{
			uint result = target.Size;
			return result;
			// TODO: add assertions to method ExtendedHeaderTest.SizeGetTest(ExtendedHeader)
		}
	}
}
