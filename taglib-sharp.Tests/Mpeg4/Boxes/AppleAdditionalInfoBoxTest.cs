using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for AppleAdditionalInfoBox</summary>
    [TestClass]
    [PexClass(typeof(AppleAdditionalInfoBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AppleAdditionalInfoBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public AppleAdditionalInfoBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			AppleAdditionalInfoBox target = new AppleAdditionalInfoBox(header, file, handler);
			return target;
			// TODO: add assertions to method AppleAdditionalInfoBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public AppleAdditionalInfoBox ConstructorTest01(ByteVector header)
		{
			AppleAdditionalInfoBox target = new AppleAdditionalInfoBox(header);
			return target;
			// TODO: add assertions to method AppleAdditionalInfoBoxTest.ConstructorTest01(ByteVector)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]AppleAdditionalInfoBox target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method AppleAdditionalInfoBoxTest.DataGetTest(AppleAdditionalInfoBox)
		}

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public string TextGetTest([PexAssumeUnderTest]AppleAdditionalInfoBox target)
		{
			string result = target.Text;
			return result;
			// TODO: add assertions to method AppleAdditionalInfoBoxTest.TextGetTest(AppleAdditionalInfoBox)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]AppleAdditionalInfoBox target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method AppleAdditionalInfoBoxTest.DataSetTest(AppleAdditionalInfoBox, ByteVector)
		}

		/// <summary>Test stub for set_Text(String)</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]AppleAdditionalInfoBox target, string value)
		{
			target.Text = value;
			// TODO: add assertions to method AppleAdditionalInfoBoxTest.TextSetTest(AppleAdditionalInfoBox, String)
		}
	}
}
