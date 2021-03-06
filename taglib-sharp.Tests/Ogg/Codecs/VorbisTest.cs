using TagLib;
using TagLib.Ogg;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg.Codecs;

namespace TagLib.Ogg.Codecs.Tests
{
    /// <summary>This class contains parameterized unit tests for Vorbis</summary>
    [TestClass]
    [PexClass(typeof(Vorbis))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class VorbisTest
    {

		/// <summary>Test stub for FromPacket(ByteVector)</summary>
		[PexMethod]
		public Codec FromPacketTest(ByteVector packet)
		{
			Codec result = Vorbis.FromPacket(packet);
			return result;
			// TODO: add assertions to method VorbisTest.FromPacketTest(ByteVector)
		}

		/// <summary>Test stub for GetDuration(Int64, Int64)</summary>
		[PexMethod]
		public TimeSpan GetDurationTest(
			[PexAssumeUnderTest]Vorbis target,
			long firstGranularPosition,
			long lastGranularPosition
		)
		{
			TimeSpan result = target.GetDuration(firstGranularPosition, lastGranularPosition);
			return result;
			// TODO: add assertions to method VorbisTest.GetDurationTest(Vorbis, Int64, Int64)
		}

		/// <summary>Test stub for ReadPacket(ByteVector, Int32)</summary>
		[PexMethod]
		public bool ReadPacketTest(
			[PexAssumeUnderTest]Vorbis target,
			ByteVector packet,
			int index
		)
		{
			bool result = target.ReadPacket(packet, index);
			return result;
			// TODO: add assertions to method VorbisTest.ReadPacketTest(Vorbis, ByteVector, Int32)
		}

		/// <summary>Test stub for SetCommentPacket(ByteVectorCollection, XiphComment)</summary>
		[PexMethod]
		public void SetCommentPacketTest(
			[PexAssumeUnderTest]Vorbis target,
			ByteVectorCollection packets,
			XiphComment comment
		)
		{
			target.SetCommentPacket(packets, comment);
			// TODO: add assertions to method VorbisTest.SetCommentPacketTest(Vorbis, ByteVectorCollection, XiphComment)
		}

		/// <summary>Test stub for get_AudioBitrate()</summary>
		[PexMethod]
		public int AudioBitrateGetTest([PexAssumeUnderTest]Vorbis target)
		{
			int result = target.AudioBitrate;
			return result;
			// TODO: add assertions to method VorbisTest.AudioBitrateGetTest(Vorbis)
		}

		/// <summary>Test stub for get_AudioChannels()</summary>
		[PexMethod]
		public int AudioChannelsGetTest([PexAssumeUnderTest]Vorbis target)
		{
			int result = target.AudioChannels;
			return result;
			// TODO: add assertions to method VorbisTest.AudioChannelsGetTest(Vorbis)
		}

		/// <summary>Test stub for get_AudioSampleRate()</summary>
		[PexMethod]
		public int AudioSampleRateGetTest([PexAssumeUnderTest]Vorbis target)
		{
			int result = target.AudioSampleRate;
			return result;
			// TODO: add assertions to method VorbisTest.AudioSampleRateGetTest(Vorbis)
		}

		/// <summary>Test stub for get_CommentData()</summary>
		[PexMethod]
		public ByteVector CommentDataGetTest([PexAssumeUnderTest]Vorbis target)
		{
			ByteVector result = target.CommentData;
			return result;
			// TODO: add assertions to method VorbisTest.CommentDataGetTest(Vorbis)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Vorbis target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method VorbisTest.DescriptionGetTest(Vorbis)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]Vorbis target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method VorbisTest.MediaTypesGetTest(Vorbis)
		}
	}
}
