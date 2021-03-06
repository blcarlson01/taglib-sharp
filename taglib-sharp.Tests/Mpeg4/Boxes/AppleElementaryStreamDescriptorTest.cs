using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for AppleElementaryStreamDescriptor</summary>
    [TestClass]
    [PexClass(typeof(AppleElementaryStreamDescriptor))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AppleElementaryStreamDescriptorTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public AppleElementaryStreamDescriptor ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			AppleElementaryStreamDescriptor target = new AppleElementaryStreamDescriptor(header, file, handler);
			return target;
			// TODO: add assertions to method AppleElementaryStreamDescriptorTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_AverageBitrate()</summary>
		[PexMethod]
		public uint AverageBitrateGetTest([PexAssumeUnderTest]AppleElementaryStreamDescriptor target)
		{
			uint result = target.AverageBitrate;
			return result;
			// TODO: add assertions to method AppleElementaryStreamDescriptorTest.AverageBitrateGetTest(AppleElementaryStreamDescriptor)
		}

		/// <summary>Test stub for get_BufferSizeDB()</summary>
		[PexMethod]
		public uint BufferSizeDBGetTest([PexAssumeUnderTest]AppleElementaryStreamDescriptor target)
		{
			uint result = target.BufferSizeDB;
			return result;
			// TODO: add assertions to method AppleElementaryStreamDescriptorTest.BufferSizeDBGetTest(AppleElementaryStreamDescriptor)
		}

		/// <summary>Test stub for get_DecoderConfig()</summary>
		[PexMethod]
		public ByteVector DecoderConfigGetTest([PexAssumeUnderTest]AppleElementaryStreamDescriptor target)
		{
			ByteVector result = target.DecoderConfig;
			return result;
			// TODO: add assertions to method AppleElementaryStreamDescriptorTest.DecoderConfigGetTest(AppleElementaryStreamDescriptor)
		}

		/// <summary>Test stub for get_MaximumBitrate()</summary>
		[PexMethod]
		public uint MaximumBitrateGetTest([PexAssumeUnderTest]AppleElementaryStreamDescriptor target)
		{
			uint result = target.MaximumBitrate;
			return result;
			// TODO: add assertions to method AppleElementaryStreamDescriptorTest.MaximumBitrateGetTest(AppleElementaryStreamDescriptor)
		}

		/// <summary>Test stub for get_ObjectTypeId()</summary>
		[PexMethod]
		public byte ObjectTypeIdGetTest([PexAssumeUnderTest]AppleElementaryStreamDescriptor target)
		{
			byte result = target.ObjectTypeId;
			return result;
			// TODO: add assertions to method AppleElementaryStreamDescriptorTest.ObjectTypeIdGetTest(AppleElementaryStreamDescriptor)
		}

		/// <summary>Test stub for get_StreamId()</summary>
		[PexMethod]
		public ushort StreamIdGetTest([PexAssumeUnderTest]AppleElementaryStreamDescriptor target)
		{
			ushort result = target.StreamId;
			return result;
			// TODO: add assertions to method AppleElementaryStreamDescriptorTest.StreamIdGetTest(AppleElementaryStreamDescriptor)
		}

		/// <summary>Test stub for get_StreamPriority()</summary>
		[PexMethod]
		public byte StreamPriorityGetTest([PexAssumeUnderTest]AppleElementaryStreamDescriptor target)
		{
			byte result = target.StreamPriority;
			return result;
			// TODO: add assertions to method AppleElementaryStreamDescriptorTest.StreamPriorityGetTest(AppleElementaryStreamDescriptor)
		}

		/// <summary>Test stub for get_StreamType()</summary>
		[PexMethod]
		public byte StreamTypeGetTest([PexAssumeUnderTest]AppleElementaryStreamDescriptor target)
		{
			byte result = target.StreamType;
			return result;
			// TODO: add assertions to method AppleElementaryStreamDescriptorTest.StreamTypeGetTest(AppleElementaryStreamDescriptor)
		}
	}
}
