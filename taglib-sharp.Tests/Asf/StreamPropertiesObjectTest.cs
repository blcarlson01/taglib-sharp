using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for StreamPropertiesObject</summary>
    [TestClass]
    [PexClass(typeof(StreamPropertiesObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StreamPropertiesObjectTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public StreamPropertiesObject ConstructorTest(File file, long position)
		{
			StreamPropertiesObject target = new StreamPropertiesObject(file, position);
			return target;
			// TODO: add assertions to method StreamPropertiesObjectTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]StreamPropertiesObject target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method StreamPropertiesObjectTest.RenderTest(StreamPropertiesObject)
		}

		/// <summary>Test stub for get_Codec()</summary>
		[PexMethod]
		public ICodec CodecGetTest([PexAssumeUnderTest]StreamPropertiesObject target)
		{
			ICodec result = target.Codec;
			return result;
			// TODO: add assertions to method StreamPropertiesObjectTest.CodecGetTest(StreamPropertiesObject)
		}

		/// <summary>Test stub for get_ErrorCorrectionData()</summary>
		[PexMethod]
		public ByteVector ErrorCorrectionDataGetTest([PexAssumeUnderTest]StreamPropertiesObject target)
		{
			ByteVector result = target.ErrorCorrectionData;
			return result;
			// TODO: add assertions to method StreamPropertiesObjectTest.ErrorCorrectionDataGetTest(StreamPropertiesObject)
		}

	

		/// <summary>Test stub for get_Flags()</summary>
		[PexMethod]
		public ushort FlagsGetTest([PexAssumeUnderTest]StreamPropertiesObject target)
		{
			ushort result = target.Flags;
			return result;
			// TODO: add assertions to method StreamPropertiesObjectTest.FlagsGetTest(StreamPropertiesObject)
		}

		

		/// <summary>Test stub for get_TimeOffset()</summary>
		[PexMethod]
		public TimeSpan TimeOffsetGetTest([PexAssumeUnderTest]StreamPropertiesObject target)
		{
			TimeSpan result = target.TimeOffset;
			return result;
			// TODO: add assertions to method StreamPropertiesObjectTest.TimeOffsetGetTest(StreamPropertiesObject)
		}

		/// <summary>Test stub for get_TypeSpecificData()</summary>
		[PexMethod]
		public ByteVector TypeSpecificDataGetTest([PexAssumeUnderTest]StreamPropertiesObject target)
		{
			ByteVector result = target.TypeSpecificData;
			return result;
			// TODO: add assertions to method StreamPropertiesObjectTest.TypeSpecificDataGetTest(StreamPropertiesObject)
		}
	}
}
