using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for Properties</summary>
    [TestClass]
    [PexClass(typeof(Properties))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PropertiesTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public Properties ConstructorTest()
		{
			Properties target = new Properties();
			return target;
			// TODO: add assertions to method PropertiesTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(TimeSpan, ICodec[])</summary>
		[PexMethod]
		public Properties ConstructorTest01(TimeSpan duration, ICodec[] codecs)
		{
			Properties target = new Properties(duration, codecs);
			return target;
			// TODO: add assertions to method PropertiesTest.ConstructorTest01(TimeSpan, ICodec[])
		}

		/// <summary>Test stub for .ctor(TimeSpan, IEnumerable`1&lt;ICodec&gt;)</summary>
		[PexMethod]
		public Properties ConstructorTest02(TimeSpan duration, IEnumerable<ICodec> codecs)
		{
			Properties target = new Properties(duration, codecs);
			return target;
			// TODO: add assertions to method PropertiesTest.ConstructorTest02(TimeSpan, IEnumerable`1<ICodec>)
		}

		/// <summary>Test stub for get_AudioBitrate()</summary>
		[PexMethod]
		public int AudioBitrateGetTest([PexAssumeUnderTest]Properties target)
		{
			int result = target.AudioBitrate;
			return result;
			// TODO: add assertions to method PropertiesTest.AudioBitrateGetTest(Properties)
		}

		/// <summary>Test stub for get_AudioChannels()</summary>
		[PexMethod]
		public int AudioChannelsGetTest([PexAssumeUnderTest]Properties target)
		{
			int result = target.AudioChannels;
			return result;
			// TODO: add assertions to method PropertiesTest.AudioChannelsGetTest(Properties)
		}

		/// <summary>Test stub for get_AudioSampleRate()</summary>
		[PexMethod]
		public int AudioSampleRateGetTest([PexAssumeUnderTest]Properties target)
		{
			int result = target.AudioSampleRate;
			return result;
			// TODO: add assertions to method PropertiesTest.AudioSampleRateGetTest(Properties)
		}

		/// <summary>Test stub for get_BitsPerSample()</summary>
		[PexMethod]
		public int BitsPerSampleGetTest([PexAssumeUnderTest]Properties target)
		{
			int result = target.BitsPerSample;
			return result;
			// TODO: add assertions to method PropertiesTest.BitsPerSampleGetTest(Properties)
		}

		/// <summary>Test stub for get_Codecs()</summary>
		[PexMethod]
		public IEnumerable<ICodec> CodecsGetTest([PexAssumeUnderTest]Properties target)
		{
			IEnumerable<ICodec> result = target.Codecs;
			return result;
			// TODO: add assertions to method PropertiesTest.CodecsGetTest(Properties)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Properties target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method PropertiesTest.DescriptionGetTest(Properties)
		}

		/// <summary>Test stub for get_Duration()</summary>
		[PexMethod]
		public TimeSpan DurationGetTest([PexAssumeUnderTest]Properties target)
		{
			TimeSpan result = target.Duration;
			return result;
			// TODO: add assertions to method PropertiesTest.DurationGetTest(Properties)
		}

		/// <summary>Test stub for get_MediaTypes()</summary>
		[PexMethod]
		public MediaTypes MediaTypesGetTest([PexAssumeUnderTest]Properties target)
		{
			MediaTypes result = target.MediaTypes;
			return result;
			// TODO: add assertions to method PropertiesTest.MediaTypesGetTest(Properties)
		}

		/// <summary>Test stub for get_PhotoHeight()</summary>
		[PexMethod]
		public int PhotoHeightGetTest([PexAssumeUnderTest]Properties target)
		{
			int result = target.PhotoHeight;
			return result;
			// TODO: add assertions to method PropertiesTest.PhotoHeightGetTest(Properties)
		}

		/// <summary>Test stub for get_PhotoQuality()</summary>
		[PexMethod]
		public int PhotoQualityGetTest([PexAssumeUnderTest]Properties target)
		{
			int result = target.PhotoQuality;
			return result;
			// TODO: add assertions to method PropertiesTest.PhotoQualityGetTest(Properties)
		}

		/// <summary>Test stub for get_PhotoWidth()</summary>
		[PexMethod]
		public int PhotoWidthGetTest([PexAssumeUnderTest]Properties target)
		{
			int result = target.PhotoWidth;
			return result;
			// TODO: add assertions to method PropertiesTest.PhotoWidthGetTest(Properties)
		}

		/// <summary>Test stub for get_VideoHeight()</summary>
		[PexMethod]
		public int VideoHeightGetTest([PexAssumeUnderTest]Properties target)
		{
			int result = target.VideoHeight;
			return result;
			// TODO: add assertions to method PropertiesTest.VideoHeightGetTest(Properties)
		}

		/// <summary>Test stub for get_VideoWidth()</summary>
		[PexMethod]
		public int VideoWidthGetTest([PexAssumeUnderTest]Properties target)
		{
			int result = target.VideoWidth;
			return result;
			// TODO: add assertions to method PropertiesTest.VideoWidthGetTest(Properties)
		}
	}
}
