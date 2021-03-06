using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;

namespace TagLib.Riff.Tests
{
    /// <summary>This class contains parameterized unit tests for AviAudioStream</summary>
    [TestClass]
    [PexClass(typeof(AviAudioStream))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AviAudioStreamTest
    {

		/// <summary>Test stub for .ctor(AviStreamHeader)</summary>
		[PexMethod]
		public AviAudioStream ConstructorTest(AviStreamHeader header)
		{
			AviAudioStream target = new AviAudioStream(header);
			return target;
			// TODO: add assertions to method AviAudioStreamTest.ConstructorTest(AviStreamHeader)
		}

		/// <summary>Test stub for ParseItem(ByteVector, ByteVector, Int32, Int32)</summary>
		[PexMethod]
		public void ParseItemTest(
			[PexAssumeUnderTest]AviAudioStream target,
			ByteVector id,
			ByteVector data,
			int start,
			int length
		)
		{
			target.ParseItem(id, data, start, length);
			// TODO: add assertions to method AviAudioStreamTest.ParseItemTest(AviAudioStream, ByteVector, ByteVector, Int32, Int32)
		}
	}
}
