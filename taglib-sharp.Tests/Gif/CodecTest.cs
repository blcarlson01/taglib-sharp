using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Gif;

namespace TagLib.Gif.Tests
{
    /// <summary>This class contains parameterized unit tests for Codec</summary>
    [TestClass]
    [PexClass(typeof(Codec))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CodecTest
    {

		/// <summary>Test stub for .ctor(Int32, Int32)</summary>
		[PexMethod]
		public Codec ConstructorTest(int width, int height)
		{
			Codec target = new Codec(width, height);
			return target;
			// TODO: add assertions to method CodecTest.ConstructorTest(Int32, Int32)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Codec target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method CodecTest.DescriptionGetTest(Codec)
		}
	}
}
