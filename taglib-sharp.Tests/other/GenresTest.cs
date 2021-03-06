using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for Genres</summary>
    [TestClass]
    [PexClass(typeof(Genres))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GenresTest
    {

		/// <summary>Test stub for AudioToIndex(String)</summary>
		[PexMethod]
		public byte AudioToIndexTest(string name)
		{
			byte result = Genres.AudioToIndex(name);
			return result;
			// TODO: add assertions to method GenresTest.AudioToIndexTest(String)
		}

		/// <summary>Test stub for IndexToAudio(Byte)</summary>
		[PexMethod]
		public string IndexToAudioTest(byte index)
		{
			string result = Genres.IndexToAudio(index);
			return result;
			// TODO: add assertions to method GenresTest.IndexToAudioTest(Byte)
		}

		/// <summary>Test stub for IndexToAudio(String)</summary>
		[PexMethod]
		public string IndexToAudioTest01(string text)
		{
			string result = Genres.IndexToAudio(text);
			return result;
			// TODO: add assertions to method GenresTest.IndexToAudioTest01(String)
		}

		/// <summary>Test stub for IndexToVideo(Byte)</summary>
		[PexMethod]
		public string IndexToVideoTest(byte index)
		{
			string result = Genres.IndexToVideo(index);
			return result;
			// TODO: add assertions to method GenresTest.IndexToVideoTest(Byte)
		}

		/// <summary>Test stub for IndexToVideo(String)</summary>
		[PexMethod]
		public string IndexToVideoTest01(string text)
		{
			string result = Genres.IndexToVideo(text);
			return result;
			// TODO: add assertions to method GenresTest.IndexToVideoTest01(String)
		}

		/// <summary>Test stub for VideoToIndex(String)</summary>
		[PexMethod]
		public byte VideoToIndexTest(string name)
		{
			byte result = Genres.VideoToIndex(name);
			return result;
			// TODO: add assertions to method GenresTest.VideoToIndexTest(String)
		}

		/// <summary>Test stub for get_Audio()</summary>
		[PexMethod]
		public string[] AudioGetTest()
		{
			string[] result = Genres.Audio;
			return result;
			// TODO: add assertions to method GenresTest.AudioGetTest()
		}

		/// <summary>Test stub for get_Video()</summary>
		[PexMethod]
		public string[] VideoGetTest()
		{
			string[] result = Genres.Video;
			return result;
			// TODO: add assertions to method GenresTest.VideoGetTest()
		}
	}
}
