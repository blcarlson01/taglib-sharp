using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for FileParser</summary>
    [TestClass]
    [PexClass(typeof(FileParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FileParserTest
    {

		/// <summary>Test stub for .ctor(File)</summary>
		[PexMethod]
		public FileParser ConstructorTest(File file)
		{
			FileParser target = new FileParser(file);
			return target;
			// TODO: add assertions to method FileParserTest.ConstructorTest(File)
		}

		/// <summary>Test stub for ParseBoxHeaders()</summary>
		[PexMethod]
		public void ParseBoxHeadersTest([PexAssumeUnderTest]FileParser target)
		{
			target.ParseBoxHeaders();
			// TODO: add assertions to method FileParserTest.ParseBoxHeadersTest(FileParser)
		}

		/// <summary>Test stub for ParseChunkOffsets()</summary>
		[PexMethod]
		public void ParseChunkOffsetsTest([PexAssumeUnderTest]FileParser target)
		{
			target.ParseChunkOffsets();
			// TODO: add assertions to method FileParserTest.ParseChunkOffsetsTest(FileParser)
		}

		/// <summary>Test stub for ParseTag()</summary>
		[PexMethod]
		public void ParseTagTest([PexAssumeUnderTest]FileParser target)
		{
			target.ParseTag();
			// TODO: add assertions to method FileParserTest.ParseTagTest(FileParser)
		}

		/// <summary>Test stub for ParseTagAndProperties()</summary>
		[PexMethod]
		public void ParseTagAndPropertiesTest([PexAssumeUnderTest]FileParser target)
		{
			target.ParseTagAndProperties();
			// TODO: add assertions to method FileParserTest.ParseTagAndPropertiesTest(FileParser)
		}

		/// <summary>Test stub for get_AudioSampleEntry()</summary>
		[PexMethod]
		public IsoAudioSampleEntry AudioSampleEntryGetTest([PexAssumeUnderTest]FileParser target)
		{
			IsoAudioSampleEntry result = target.AudioSampleEntry;
			return result;
			// TODO: add assertions to method FileParserTest.AudioSampleEntryGetTest(FileParser)
		}

		/// <summary>Test stub for get_ChunkOffsetBoxes()</summary>
		[PexMethod]
		public Box[] ChunkOffsetBoxesGetTest([PexAssumeUnderTest]FileParser target)
		{
			Box[] result = target.ChunkOffsetBoxes;
			return result;
			// TODO: add assertions to method FileParserTest.ChunkOffsetBoxesGetTest(FileParser)
		}

		/// <summary>Test stub for get_MdatEndPosition()</summary>
		[PexMethod]
		public long MdatEndPositionGetTest([PexAssumeUnderTest]FileParser target)
		{
			long result = target.MdatEndPosition;
			return result;
			// TODO: add assertions to method FileParserTest.MdatEndPositionGetTest(FileParser)
		}

		/// <summary>Test stub for get_MdatStartPosition()</summary>
		[PexMethod]
		public long MdatStartPositionGetTest([PexAssumeUnderTest]FileParser target)
		{
			long result = target.MdatStartPosition;
			return result;
			// TODO: add assertions to method FileParserTest.MdatStartPositionGetTest(FileParser)
		}

		/// <summary>Test stub for get_MoovTree()</summary>
		[PexMethod]
		public BoxHeader[] MoovTreeGetTest([PexAssumeUnderTest]FileParser target)
		{
			BoxHeader[] result = target.MoovTree;
			return result;
			// TODO: add assertions to method FileParserTest.MoovTreeGetTest(FileParser)
		}

		/// <summary>Test stub for get_MovieHeaderBox()</summary>
		[PexMethod]
		public IsoMovieHeaderBox MovieHeaderBoxGetTest([PexAssumeUnderTest]FileParser target)
		{
			IsoMovieHeaderBox result = target.MovieHeaderBox;
			return result;
			// TODO: add assertions to method FileParserTest.MovieHeaderBoxGetTest(FileParser)
		}

		/// <summary>Test stub for get_UdtaTree()</summary>
		[PexMethod]
		public BoxHeader[] UdtaTreeGetTest([PexAssumeUnderTest]FileParser target)
		{
			BoxHeader[] result = target.UdtaTree;
			return result;
			// TODO: add assertions to method FileParserTest.UdtaTreeGetTest(FileParser)
		}

		/// <summary>Test stub for get_UserDataBox()</summary>
		[PexMethod]
		public IsoUserDataBox UserDataBoxGetTest([PexAssumeUnderTest]FileParser target)
		{
			IsoUserDataBox result = target.UserDataBox;
			return result;
			// TODO: add assertions to method FileParserTest.UserDataBoxGetTest(FileParser)
		}

		/// <summary>Test stub for get_UserDataBoxes()</summary>
		[PexMethod]
		public IsoUserDataBox[] UserDataBoxesGetTest([PexAssumeUnderTest]FileParser target)
		{
			IsoUserDataBox[] result = target.UserDataBoxes;
			return result;
			// TODO: add assertions to method FileParserTest.UserDataBoxesGetTest(FileParser)
		}

		/// <summary>Test stub for get_VisualSampleEntry()</summary>
		[PexMethod]
		public IsoVisualSampleEntry VisualSampleEntryGetTest([PexAssumeUnderTest]FileParser target)
		{
			IsoVisualSampleEntry result = target.VisualSampleEntry;
			return result;
			// TODO: add assertions to method FileParserTest.VisualSampleEntryGetTest(FileParser)
		}
	}
}
