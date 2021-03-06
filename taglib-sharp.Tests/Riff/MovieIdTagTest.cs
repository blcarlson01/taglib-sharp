using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;

namespace TagLib.Riff.Tests
{
    /// <summary>This class contains parameterized unit tests for MovieIdTag</summary>
    [TestClass]
    [PexClass(typeof(MovieIdTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MovieIdTagTest
    {

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public MovieIdTag ConstructorTest(ByteVector data)
		{
			MovieIdTag target = new MovieIdTag(data);
			return target;
			// TODO: add assertions to method MovieIdTagTest.ConstructorTest(ByteVector)
		}

		/// <summary>Test stub for .ctor(File, Int64, Int32)</summary>
		[PexMethod]
		public MovieIdTag ConstructorTest01(
			File file,
			long position,
			int length
		)
		{
			MovieIdTag target = new MovieIdTag(file, position, length);
			return target;
			// TODO: add assertions to method MovieIdTagTest.ConstructorTest01(File, Int64, Int32)
		}

		/// <summary>Test stub for RenderEnclosed()</summary>
		[PexMethod]
		public ByteVector RenderEnclosedTest([PexAssumeUnderTest]MovieIdTag target)
		{
			ByteVector result = target.RenderEnclosed();
			return result;
			// TODO: add assertions to method MovieIdTagTest.RenderEnclosedTest(MovieIdTag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]MovieIdTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method MovieIdTagTest.CommentGetTest(MovieIdTag)
		}

		/// <summary>Test stub for get_Genres()</summary>
		[PexMethod]
		public string[] GenresGetTest([PexAssumeUnderTest]MovieIdTag target)
		{
			string[] result = target.Genres;
			return result;
			// TODO: add assertions to method MovieIdTagTest.GenresGetTest(MovieIdTag)
		}

		/// <summary>Test stub for get_Performers()</summary>
		[PexMethod]
		public string[] PerformersGetTest([PexAssumeUnderTest]MovieIdTag target)
		{
			string[] result = target.Performers;
			return result;
			// TODO: add assertions to method MovieIdTagTest.PerformersGetTest(MovieIdTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]MovieIdTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method MovieIdTagTest.TagTypesGetTest(MovieIdTag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]MovieIdTag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method MovieIdTagTest.TitleGetTest(MovieIdTag)
		}

		/// <summary>Test stub for get_Track()</summary>
		[PexMethod]
		public uint TrackGetTest([PexAssumeUnderTest]MovieIdTag target)
		{
			uint result = target.Track;
			return result;
			// TODO: add assertions to method MovieIdTagTest.TrackGetTest(MovieIdTag)
		}

		/// <summary>Test stub for get_TrackCount()</summary>
		[PexMethod]
		public uint TrackCountGetTest([PexAssumeUnderTest]MovieIdTag target)
		{
			uint result = target.TrackCount;
			return result;
			// TODO: add assertions to method MovieIdTagTest.TrackCountGetTest(MovieIdTag)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]MovieIdTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method MovieIdTagTest.CommentSetTest(MovieIdTag, String)
		}

		/// <summary>Test stub for set_Genres(String[])</summary>
		[PexMethod]
		public void GenresSetTest([PexAssumeUnderTest]MovieIdTag target, string[] value)
		{
			target.Genres = value;
			// TODO: add assertions to method MovieIdTagTest.GenresSetTest(MovieIdTag, String[])
		}

		/// <summary>Test stub for set_Performers(String[])</summary>
		[PexMethod]
		public void PerformersSetTest([PexAssumeUnderTest]MovieIdTag target, string[] value)
		{
			target.Performers = value;
			// TODO: add assertions to method MovieIdTagTest.PerformersSetTest(MovieIdTag, String[])
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]MovieIdTag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method MovieIdTagTest.TitleSetTest(MovieIdTag, String)
		}

		/// <summary>Test stub for set_Track(UInt32)</summary>
		[PexMethod]
		public void TrackSetTest([PexAssumeUnderTest]MovieIdTag target, uint value)
		{
			target.Track = value;
			// TODO: add assertions to method MovieIdTagTest.TrackSetTest(MovieIdTag, UInt32)
		}

		/// <summary>Test stub for set_TrackCount(UInt32)</summary>
		[PexMethod]
		public void TrackCountSetTest([PexAssumeUnderTest]MovieIdTag target, uint value)
		{
			target.TrackCount = value;
			// TODO: add assertions to method MovieIdTagTest.TrackCountSetTest(MovieIdTag, UInt32)
		}
	}
}
