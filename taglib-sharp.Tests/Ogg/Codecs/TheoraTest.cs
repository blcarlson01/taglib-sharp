using TagLib;
using TagLib.Ogg;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg.Codecs;

namespace TagLib.Ogg.Codecs.Tests
{
    /// <summary>This class contains parameterized unit tests for Theora</summary>
    [TestClass]
    [PexClass(typeof(Theora))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TheoraTest
    {

		/// <summary>Test stub for FromPacket(ByteVector)</summary>
		[PexMethod]
		public Codec FromPacketTest(ByteVector packet)
		{
			Codec result = Theora.FromPacket(packet);
			return result;
			// TODO: add assertions to method TheoraTest.FromPacketTest(ByteVector)
		}

		/// <summary>Test stub for GetDuration(Int64, Int64)</summary>
		[PexMethod]
		public TimeSpan GetDurationTest(
			[PexAssumeUnderTest]Theora target,
			long firstGranularPosition,
			long lastGranularPosition
		)
		{
			TimeSpan result = target.GetDuration(firstGranularPosition, lastGranularPosition);
			return result;
			// TODO: add assertions to method TheoraTest.GetDurationTest(Theora, Int64, Int64)
		}

		/// <summary>Test stub for ReadPacket(ByteVector, Int32)</summary>
		[PexMethod]
		public bool ReadPacketTest(
			[PexAssumeUnderTest]Theora target,
			ByteVector packet,
			int index
		)
		{
			bool result = target.ReadPacket(packet, index);
			return result;
			// TODO: add assertions to method TheoraTest.ReadPacketTest(Theora, ByteVector, Int32)
		}

		/// <summary>Test stub for SetCommentPacket(ByteVectorCollection, XiphComment)</summary>
		[PexMethod]
		public void SetCommentPacketTest(
			[PexAssumeUnderTest]Theora target,
			ByteVectorCollection packets,
			XiphComment comment
		)
		{
			target.SetCommentPacket(packets, comment);
			// TODO: add assertions to method TheoraTest.SetCommentPacketTest(Theora, ByteVectorCollection, XiphComment)
		}

		/// <summary>Test stub for get_CommentData()</summary>
		[PexMethod]
		public ByteVector CommentDataGetTest([PexAssumeUnderTest]Theora target)
		{
			ByteVector result = target.CommentData;
			return result;
			// TODO: add assertions to method TheoraTest.CommentDataGetTest(Theora)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Theora target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method TheoraTest.DescriptionGetTest(Theora)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]Theora target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method TheoraTest.MediaTypesGetTest(Theora)
		}

		/// <summary>Test stub for get_VideoHeight()</summary>
		[PexMethod]
		public int VideoHeightGetTest([PexAssumeUnderTest]Theora target)
		{
			int result = target.VideoHeight;
			return result;
			// TODO: add assertions to method TheoraTest.VideoHeightGetTest(Theora)
		}

		/// <summary>Test stub for get_VideoWidth()</summary>
		[PexMethod]
		public int VideoWidthGetTest([PexAssumeUnderTest]Theora target)
		{
			int result = target.VideoWidth;
			return result;
			// TODO: add assertions to method TheoraTest.VideoWidthGetTest(Theora)
		}
	}
}
