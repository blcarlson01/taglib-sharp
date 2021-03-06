using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for AppleDataBox</summary>
    [TestClass]
    [PexClass(typeof(AppleDataBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AppleDataBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public AppleDataBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			AppleDataBox target = new AppleDataBox(header, file, handler);
			return target;
			// TODO: add assertions to method AppleDataBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for .ctor(ByteVector, UInt32)</summary>
		[PexMethod]
		public AppleDataBox ConstructorTest01(ByteVector data, uint flags)
		{
			AppleDataBox target = new AppleDataBox(data, flags);
			return target;
			// TODO: add assertions to method AppleDataBoxTest.ConstructorTest01(ByteVector, UInt32)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]AppleDataBox target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method AppleDataBoxTest.DataGetTest(AppleDataBox)
		}

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public string TextGetTest([PexAssumeUnderTest]AppleDataBox target)
		{
			string result = target.Text;
			return result;
			// TODO: add assertions to method AppleDataBoxTest.TextGetTest(AppleDataBox)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]AppleDataBox target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method AppleDataBoxTest.DataSetTest(AppleDataBox, ByteVector)
		}

		/// <summary>Test stub for set_Text(String)</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]AppleDataBox target, string value)
		{
			target.Text = value;
			// TODO: add assertions to method AppleDataBoxTest.TextSetTest(AppleDataBox, String)
		}
	}
}
