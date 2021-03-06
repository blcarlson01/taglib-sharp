using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoAudioSampleEntry</summary>
    [TestClass]
    [PexClass(typeof(IsoAudioSampleEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoAudioSampleEntryTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoAudioSampleEntry ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoAudioSampleEntry target = new IsoAudioSampleEntry(header, file, handler);
			return target;
			// TODO: add assertions to method IsoAudioSampleEntryTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_AudioBitrate()</summary>
		[PexMethod]
		public int AudioBitrateGetTest([PexAssumeUnderTest]IsoAudioSampleEntry target)
		{
			int result = target.AudioBitrate;
			return result;
			// TODO: add assertions to method IsoAudioSampleEntryTest.AudioBitrateGetTest(IsoAudioSampleEntry)
		}

		/// <summary>Test stub for get_AudioChannels()</summary>
		[PexMethod]
		public int AudioChannelsGetTest([PexAssumeUnderTest]IsoAudioSampleEntry target)
		{
			int result = target.AudioChannels;
			return result;
			// TODO: add assertions to method IsoAudioSampleEntryTest.AudioChannelsGetTest(IsoAudioSampleEntry)
		}

		/// <summary>Test stub for get_AudioSampleRate()</summary>
		[PexMethod]
		public int AudioSampleRateGetTest([PexAssumeUnderTest]IsoAudioSampleEntry target)
		{
			int result = target.AudioSampleRate;
			return result;
			// TODO: add assertions to method IsoAudioSampleEntryTest.AudioSampleRateGetTest(IsoAudioSampleEntry)
		}

		/// <summary>Test stub for get_AudioSampleSize()</summary>
		[PexMethod]
		public int AudioSampleSizeGetTest([PexAssumeUnderTest]IsoAudioSampleEntry target)
		{
			int result = target.AudioSampleSize;
			return result;
			// TODO: add assertions to method IsoAudioSampleEntryTest.AudioSampleSizeGetTest(IsoAudioSampleEntry)
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public IEnumerable<Box> ChildrenGetTest([PexAssumeUnderTest]IsoAudioSampleEntry target)
		{
			IEnumerable<Box> result = target.Children;
			return result;
			// TODO: add assertions to method IsoAudioSampleEntryTest.ChildrenGetTest(IsoAudioSampleEntry)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]IsoAudioSampleEntry target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method IsoAudioSampleEntryTest.DescriptionGetTest(IsoAudioSampleEntry)
		}

		/// <summary>Test stub for get_Duration()</summary>
		[PexMethod]
		public TimeSpan DurationGetTest([PexAssumeUnderTest]IsoAudioSampleEntry target)
		{
			TimeSpan result = target.Duration;
			return result;
			// TODO: add assertions to method IsoAudioSampleEntryTest.DurationGetTest(IsoAudioSampleEntry)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]IsoAudioSampleEntry target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method IsoAudioSampleEntryTest.MediaTypesGetTest(IsoAudioSampleEntry)
		}
	}
}
