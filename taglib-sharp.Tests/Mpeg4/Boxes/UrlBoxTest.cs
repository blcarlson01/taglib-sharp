using TagLib.Mpeg4;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for UrlBox</summary>
    [TestClass]
    [PexClass(typeof(UrlBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UrlBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public UrlBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			UrlBox target = new UrlBox(header, file, handler);
			return target;
			// TODO: add assertions to method UrlBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]UrlBox target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method UrlBoxTest.DataGetTest(UrlBox)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]UrlBox target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method UrlBoxTest.DataSetTest(UrlBox, ByteVector)
		}
	}
}
