using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Aac;

namespace TagLib.Aac.Tests
{
    /// <summary>This class contains parameterized unit tests for AudioHeader</summary>
    [TestClass]
    [PexClass(typeof(AudioHeader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AudioHeaderTest
    {

		/// <summary>Test stub for Find(AudioHeader&amp;, File, Int64, Int32)</summary>
		[PexMethod]
		public bool FindTest(
			out AudioHeader header,
			File file,
			long position,
			int length
		)
		{
			bool result = AudioHeader.Find(out header, file, position, length);
			return result;
			// TODO: add assertions to method AudioHeaderTest.FindTest(AudioHeader&, File, Int64, Int32)
		}

		/// <summary>Test stub for Find(AudioHeader&amp;, File, Int64)</summary>
		[PexMethod]
		public bool FindTest01(
			out AudioHeader header,
			File file,
			long position
		)
		{
			bool result = AudioHeader.Find(out header, file, position);
			return result;
			// TODO: add assertions to method AudioHeaderTest.FindTest01(AudioHeader&, File, Int64)
		}

		/// <summary>Test stub for SetStreamLength(Int64)</summary>
		[PexMethod]
		public void SetStreamLengthTest([PexAssumeUnderTest]AudioHeader target, long streamLength)
		{
			target.SetStreamLength(streamLength);
			// TODO: add assertions to method AudioHeaderTest.SetStreamLengthTest(AudioHeader, Int64)
		}

		/// <summary>Test stub for get_AudioBitrate()</summary>
		[PexMethod]
		public int AudioBitrateGetTest([PexAssumeUnderTest]AudioHeader target)
		{
			int result = target.AudioBitrate;
			return result;
			// TODO: add assertions to method AudioHeaderTest.AudioBitrateGetTest(AudioHeader)
		}

		/// <summary>Test stub for get_AudioChannels()</summary>
		[PexMethod]
		public int AudioChannelsGetTest([PexAssumeUnderTest]AudioHeader target)
		{
			int result = target.AudioChannels;
			return result;
			// TODO: add assertions to method AudioHeaderTest.AudioChannelsGetTest(AudioHeader)
		}

		/// <summary>Test stub for get_AudioSampleRate()</summary>
		[PexMethod]
		public int AudioSampleRateGetTest([PexAssumeUnderTest]AudioHeader target)
		{
			int result = target.AudioSampleRate;
			return result;
			// TODO: add assertions to method AudioHeaderTest.AudioSampleRateGetTest(AudioHeader)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]AudioHeader target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method AudioHeaderTest.DescriptionGetTest(AudioHeader)
		}

		/// <summary>Test stub for get_Duration()</summary>
		[PexMethod]
		public TimeSpan DurationGetTest([PexAssumeUnderTest]AudioHeader target)
		{
			TimeSpan result = target.Duration;
			return result;
			// TODO: add assertions to method AudioHeaderTest.DurationGetTest(AudioHeader)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]AudioHeader target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method AudioHeaderTest.MediaTypesGetTest(AudioHeader)
		}
	}
}
