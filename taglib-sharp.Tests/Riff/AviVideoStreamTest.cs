using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;

namespace TagLib.Riff.Tests
{
    /// <summary>This class contains parameterized unit tests for AviVideoStream</summary>
    [TestClass]
    [PexClass(typeof(AviVideoStream))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AviVideoStreamTest
    {

		/// <summary>Test stub for .ctor(AviStreamHeader)</summary>
		[PexMethod]
		public AviVideoStream ConstructorTest(AviStreamHeader header)
		{
			AviVideoStream target = new AviVideoStream(header);
			return target;
			// TODO: add assertions to method AviVideoStreamTest.ConstructorTest(AviStreamHeader)
		}

		/// <summary>Test stub for ParseItem(ByteVector, ByteVector, Int32, Int32)</summary>
		[PexMethod]
		public void ParseItemTest(
			[PexAssumeUnderTest]AviVideoStream target,
			ByteVector id,
			ByteVector data,
			int start,
			int length
		)
		{
			target.ParseItem(id, data, start, length);
			// TODO: add assertions to method AviVideoStreamTest.ParseItemTest(AviVideoStream, ByteVector, ByteVector, Int32, Int32)
		}

	
	}
}
