using TagLib;
using TagLib.Ogg;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg.Codecs;

namespace TagLib.Ogg.Codecs.Tests
{
    /// <summary>This class contains parameterized unit tests for Opus</summary>
    [TestClass]
    [PexClass(typeof(Opus))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class OpusTest
    {

		/// <summary>Test stub for FromPacket(ByteVector)</summary>
		[PexMethod]
		public Codec FromPacketTest(ByteVector packet)
		{
			Codec result = Opus.FromPacket(packet);
			return result;
			// TODO: add assertions to method OpusTest.FromPacketTest(ByteVector)
		}

		/// <summary>Test stub for GetDuration(Int64, Int64)</summary>
		[PexMethod]
		public TimeSpan GetDurationTest(
			[PexAssumeUnderTest]Opus target,
			long firstGranularPosition,
			long lastGranularPosition
		)
		{
			TimeSpan result = target.GetDuration(firstGranularPosition, lastGranularPosition);
			return result;
			// TODO: add assertions to method OpusTest.GetDurationTest(Opus, Int64, Int64)
		}

		/// <summary>Test stub for ReadPacket(ByteVector, Int32)</summary>
		[PexMethod]
		public bool ReadPacketTest(
			[PexAssumeUnderTest]Opus target,
			ByteVector packet,
			int index
		)
		{
			bool result = target.ReadPacket(packet, index);
			return result;
			// TODO: add assertions to method OpusTest.ReadPacketTest(Opus, ByteVector, Int32)
		}

		/// <summary>Test stub for SetCommentPacket(ByteVectorCollection, XiphComment)</summary>
		[PexMethod]
		public void SetCommentPacketTest(
			[PexAssumeUnderTest]Opus target,
			ByteVectorCollection packets,
			XiphComment comment
		)
		{
			target.SetCommentPacket(packets, comment);
			// TODO: add assertions to method OpusTest.SetCommentPacketTest(Opus, ByteVectorCollection, XiphComment)
		}

		/// <summary>Test stub for get_AudioBitrate()</summary>
		[PexMethod]
		public int AudioBitrateGetTest([PexAssumeUnderTest]Opus target)
		{
			int result = target.AudioBitrate;
			return result;
			// TODO: add assertions to method OpusTest.AudioBitrateGetTest(Opus)
		}

		/// <summary>Test stub for get_AudioChannels()</summary>
		[PexMethod]
		public int AudioChannelsGetTest([PexAssumeUnderTest]Opus target)
		{
			int result = target.AudioChannels;
			return result;
			// TODO: add assertions to method OpusTest.AudioChannelsGetTest(Opus)
		}

		/// <summary>Test stub for get_AudioSampleRate()</summary>
		[PexMethod]
		public int AudioSampleRateGetTest([PexAssumeUnderTest]Opus target)
		{
			int result = target.AudioSampleRate;
			return result;
			// TODO: add assertions to method OpusTest.AudioSampleRateGetTest(Opus)
		}

		/// <summary>Test stub for get_CommentData()</summary>
		[PexMethod]
		public ByteVector CommentDataGetTest([PexAssumeUnderTest]Opus target)
		{
			ByteVector result = target.CommentData;
			return result;
			// TODO: add assertions to method OpusTest.CommentDataGetTest(Opus)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Opus target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method OpusTest.DescriptionGetTest(Opus)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]Opus target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method OpusTest.MediaTypesGetTest(Opus)
		}
	}
}
