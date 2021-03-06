using TagLib.Mpeg4;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for TextBox</summary>
    [TestClass]
    [PexClass(typeof(TextBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TextBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public TextBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			TextBox target = new TextBox(header, file, handler);
			return target;
			// TODO: add assertions to method TextBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]TextBox target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method TextBoxTest.DataGetTest(TextBox)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]TextBox target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method TextBoxTest.DataSetTest(TextBox, ByteVector)
		}
	}
}
