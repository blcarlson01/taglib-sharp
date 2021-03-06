using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v1;

namespace TagLib.Id3v1.Tests
{
    /// <summary>This class contains parameterized unit tests for StringHandler</summary>
    [TestClass]
    [PexClass(typeof(StringHandler))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StringHandlerTest
    {

		/// <summary>Test stub for Parse(ByteVector)</summary>
		[PexMethod]
		public string ParseTest([PexAssumeUnderTest]StringHandler target, ByteVector data)
		{
			string result = target.Parse(data);
			return result;
			// TODO: add assertions to method StringHandlerTest.ParseTest(StringHandler, ByteVector)
		}

		/// <summary>Test stub for Render(String)</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]StringHandler target, string text)
		{
			ByteVector result = target.Render(text);
			return result;
			// TODO: add assertions to method StringHandlerTest.RenderTest(StringHandler, String)
		}
	}
}
