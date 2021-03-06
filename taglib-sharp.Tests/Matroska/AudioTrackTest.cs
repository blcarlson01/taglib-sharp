using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for AudioTrack</summary>
    [TestClass]
    [PexClass(typeof(AudioTrack))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AudioTrackTest
    {

		/// <summary>Test stub for .ctor(File, EBMLreader)</summary>
		[PexMethod]
		public AudioTrack ConstructorTest(File _file, EBMLreader element)
		{
			AudioTrack target = new AudioTrack(_file, element);
			return target;
			// TODO: add assertions to method AudioTrackTest.ConstructorTest(File, EBMLreader)
		}

		/// <summary>Test stub for get_AudioBitrate()</summary>
		[PexMethod]
		public int AudioBitrateGetTest([PexAssumeUnderTest]AudioTrack target)
		{
			int result = target.AudioBitrate;
			return result;
			// TODO: add assertions to method AudioTrackTest.AudioBitrateGetTest(AudioTrack)
		}

		/// <summary>Test stub for get_AudioChannels()</summary>
		[PexMethod]
		public int AudioChannelsGetTest([PexAssumeUnderTest]AudioTrack target)
		{
			int result = target.AudioChannels;
			return result;
			// TODO: add assertions to method AudioTrackTest.AudioChannelsGetTest(AudioTrack)
		}

		/// <summary>Test stub for get_AudioSampleRate()</summary>
		[PexMethod]
		public int AudioSampleRateGetTest([PexAssumeUnderTest]AudioTrack target)
		{
			int result = target.AudioSampleRate;
			return result;
			// TODO: add assertions to method AudioTrackTest.AudioSampleRateGetTest(AudioTrack)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]AudioTrack target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method AudioTrackTest.MediaTypesGetTest(AudioTrack)
		}

		/// <summary>Test stub for get_UnknownElements()</summary>
		[PexMethod]
		public List<EBMLreader> UnknownElementsGetTest([PexAssumeUnderTest]AudioTrack target)
		{
			List<EBMLreader> result = target.UnknownElements;
			return result;
			// TODO: add assertions to method AudioTrackTest.UnknownElementsGetTest(AudioTrack)
		}
	}
}
