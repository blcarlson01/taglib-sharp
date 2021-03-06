using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg;

namespace TagLib.Ogg.Tests
{
    /// <summary>This class contains parameterized unit tests for Bitstream</summary>
    [TestClass]
    [PexClass(typeof(Bitstream))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BitstreamTest
    {

		/// <summary>Test stub for .ctor(Page)</summary>
		[PexMethod]
		public Bitstream ConstructorTest(Page page)
		{
			Bitstream target = new Bitstream(page);
			return target;
			// TODO: add assertions to method BitstreamTest.ConstructorTest(Page)
		}

		/// <summary>Test stub for GetDuration(Int64)</summary>
		[PexMethod]
		public TimeSpan GetDurationTest([PexAssumeUnderTest]Bitstream target, long lastAbsoluteGranularPosition)
		{
			TimeSpan result = target.GetDuration(lastAbsoluteGranularPosition);
			return result;
			// TODO: add assertions to method BitstreamTest.GetDurationTest(Bitstream, Int64)
		}

		/// <summary>Test stub for ReadPage(Page)</summary>
		[PexMethod]
		public bool ReadPageTest([PexAssumeUnderTest]Bitstream target, Page page)
		{
			bool result = target.ReadPage(page);
			return result;
			// TODO: add assertions to method BitstreamTest.ReadPageTest(Bitstream, Page)
		}

		/// <summary>Test stub for get_Codec()</summary>
		[PexMethod]
		public Codec CodecGetTest([PexAssumeUnderTest]Bitstream target)
		{
			Codec result = target.Codec;
			return result;
			// TODO: add assertions to method BitstreamTest.CodecGetTest(Bitstream)
		}
	}
}
