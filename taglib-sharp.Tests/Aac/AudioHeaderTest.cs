using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Aac;
using System.IO;
using TagLib.Tests;

namespace TagLib.Aac.Tests
{
    /// <summary>This class contains parameterized unit tests for AudioHeader</summary>
    [TestClass]
    [PexClass(typeof(AudioHeader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AudioHeaderTest
    {
		/*[PexMethod]
		public void FindTest_Buffer(AudioHeader header, long position, int lenght)
		{
			string sample_file = TestPath.Samples + "sample.aac";
			File file = new File(sample_file);
			PexAssume.IsNotNull(file);
			PexAssume.IsTrue(file.Length > 0);
			PexAssume.IsTrue(file.GetType() == typeof(TagLib.Aac.File));
			file.Seek(position);
			PexAssume.IsTrue(file.PossiblyCorrupt);
			PexAssume.IsTrue(file.ReadBlock(3).Count < 3);
			
			bool result = AudioHeader.Find(out header, file, position);
			PexAssert.AreEqual(result, false);
		}*/

		[PexMethod, PexAllowedException(typeof(ArgumentNullException))]
		public void FindTest_NoFile(out AudioHeader header,
			File file,
			long position,
			int length)
		{
			PexAssume.IsNull(file);
			bool result = AudioHeader.Find(out header, file, position);
		}

		[PexMethod]
		public void FindTest_NotFound(out AudioHeader header,
			File file,
			long position)
		{
			PexAssume.IsNotNull(file);
			bool result = AudioHeader.Find(out header, file, position);
			PexAssert.AreEqual(false,result);
		}

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
			PexAssert.IsTrue(result);
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
		public void SetStreamLengthTest(AudioHeader target, long streamLength)
		{
			PexAssume.IsNotNull(target);
			target.SetStreamLength(streamLength);
			PexAssert.AreEqual(streamLength, target.Duration);
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
		public string DescriptionGetTest(AudioHeader target)
		{
			PexAssume.IsNotNull(target);
			string result = target.Description;	
			PexAssert.AreEqual(result, "ADTS AAC"); //Hard coded value in code
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
