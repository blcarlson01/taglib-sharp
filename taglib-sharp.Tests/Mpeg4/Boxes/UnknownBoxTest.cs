using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for UnknownBox</summary>
    [TestClass]
    [PexClass(typeof(UnknownBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnknownBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public UnknownBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			UnknownBox target = new UnknownBox(header, file, handler);
			return target;
			// TODO: add assertions to method UnknownBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]UnknownBox target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method UnknownBoxTest.DataGetTest(UnknownBox)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]UnknownBox target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method UnknownBoxTest.DataSetTest(UnknownBox, ByteVector)
		}
	}
}
