using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v1;

namespace TagLib.Id3v1.Tests
{
    /// <summary>This class contains parameterized unit tests for Tag</summary>
    [TestClass]
    [PexClass(typeof(Tag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TagTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public Tag ConstructorTest()
		{
			Tag target = new Tag();
			return target;
			// TODO: add assertions to method TagTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public Tag ConstructorTest01(File file, long position)
		{
			Tag target = new Tag(file, position);
			return target;
			// TODO: add assertions to method TagTest.ConstructorTest01(File, Int64)
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public Tag ConstructorTest02(ByteVector data)
		{
			Tag target = new Tag(data);
			return target;
			// TODO: add assertions to method TagTest.ConstructorTest02(ByteVector)
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]Tag target)
		{
			target.Clear();
			// TODO: add assertions to method TagTest.ClearTest(Tag)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]Tag target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method TagTest.RenderTest(Tag)
		}

		/// <summary>Test stub for get_Album()</summary>
		[PexMethod]
		public string AlbumGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Album;
			return result;
			// TODO: add assertions to method TagTest.AlbumGetTest(Tag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method TagTest.CommentGetTest(Tag)
		}

		/// <summary>Test stub for get_DefaultStringHandler()</summary>
		[PexMethod]
		public StringHandler DefaultStringHandlerGetTest()
		{
			StringHandler result = Tag.DefaultStringHandler;
			return result;
			// TODO: add assertions to method TagTest.DefaultStringHandlerGetTest()
		}

		/// <summary>Test stub for get_Genres()</summary>
		[PexMethod]
		public string[] GenresGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.Genres;
			return result;
			// TODO: add assertions to method TagTest.GenresGetTest(Tag)
		}

		/// <summary>Test stub for get_Performers()</summary>
		[PexMethod]
		public string[] PerformersGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.Performers;
			return result;
			// TODO: add assertions to method TagTest.PerformersGetTest(Tag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]Tag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method TagTest.TagTypesGetTest(Tag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method TagTest.TitleGetTest(Tag)
		}

		/// <summary>Test stub for get_Track()</summary>
		[PexMethod]
		public uint TrackGetTest([PexAssumeUnderTest]Tag target)
		{
			uint result = target.Track;
			return result;
			// TODO: add assertions to method TagTest.TrackGetTest(Tag)
		}

		/// <summary>Test stub for get_Year()</summary>
		[PexMethod]
		public uint YearGetTest([PexAssumeUnderTest]Tag target)
		{
			uint result = target.Year;
			return result;
			// TODO: add assertions to method TagTest.YearGetTest(Tag)
		}

		/// <summary>Test stub for set_Album(String)</summary>
		[PexMethod]
		public void AlbumSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Album = value;
			// TODO: add assertions to method TagTest.AlbumSetTest(Tag, String)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method TagTest.CommentSetTest(Tag, String)
		}

		/// <summary>Test stub for set_DefaultStringHandler(StringHandler)</summary>
		[PexMethod]
		public void DefaultStringHandlerSetTest(StringHandler value)
		{
			Tag.DefaultStringHandler = value;
			// TODO: add assertions to method TagTest.DefaultStringHandlerSetTest(StringHandler)
		}

		/// <summary>Test stub for set_Genres(String[])</summary>
		[PexMethod]
		public void GenresSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.Genres = value;
			// TODO: add assertions to method TagTest.GenresSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_Performers(String[])</summary>
		[PexMethod]
		public void PerformersSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.Performers = value;
			// TODO: add assertions to method TagTest.PerformersSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method TagTest.TitleSetTest(Tag, String)
		}

		/// <summary>Test stub for set_Track(UInt32)</summary>
		[PexMethod]
		public void TrackSetTest([PexAssumeUnderTest]Tag target, uint value)
		{
			target.Track = value;
			// TODO: add assertions to method TagTest.TrackSetTest(Tag, UInt32)
		}

		/// <summary>Test stub for set_Year(UInt32)</summary>
		[PexMethod]
		public void YearSetTest([PexAssumeUnderTest]Tag target, uint value)
		{
			target.Year = value;
			// TODO: add assertions to method TagTest.YearSetTest(Tag, UInt32)
		}
	}
}
