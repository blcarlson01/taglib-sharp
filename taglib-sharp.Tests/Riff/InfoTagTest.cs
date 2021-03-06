using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;

namespace TagLib.Riff.Tests
{
    /// <summary>This class contains parameterized unit tests for InfoTag</summary>
    [TestClass]
    [PexClass(typeof(InfoTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class InfoTagTest
    {
		//TODO: not working
		[PexMethod(MaxBranches = 40000)]
		[Ignore]
		public void FullTagTest([PexAssumeUnderTest]InfoTag tag, string title,
			string description, string album, string conductor, string[] performers,
			string[] albumArtists, string[] composers, string comment, 
			string[] genres, uint year, uint track, uint trackCount, string copyright)
		{
			PexAssume.IsNotNullOrEmpty(title);
			PexAssume.IsNotNullOrEmpty(description);
			PexAssume.IsNotNullOrEmpty(album);
			PexAssume.IsNotNullOrEmpty(conductor);
			PexAssume.IsNotNull(performers);
			PexAssume.IsNotNull(albumArtists);
			PexAssume.IsNotNull(composers);
			PexAssume.IsNotNullOrEmpty(comment);
			PexAssume.IsNotNull(genres);
			PexAssume.IsNotNullOrEmpty(copyright);

			tag.Title = title;
			tag.Description = description;
			tag.Album = album;
			tag.Conductor = conductor;
			tag.Performers = performers;
			tag.AlbumArtists = albumArtists;
			tag.Composers = composers;
			tag.Comment = comment;
			tag.Genres = genres;
			tag.Year = year;
			tag.Track = track;
			tag.TrackCount = trackCount;
			tag.Copyright = copyright;

			PexAssert.AreEqual(title, tag.Title);
			PexAssert.AreEqual(description, tag.Description);
			PexAssert.AreEqual(album, tag.Album);
			PexAssert.AreEqual(conductor, tag.Conductor);
			PexAssert.AreEqual(performers.Length, tag.Performers.Length);
			PexAssert.AreEqual(albumArtists.Length, tag.AlbumArtists.Length);
			PexAssert.AreEqual(composers.Length, tag.Composers.Length);
			PexAssert.AreEqual(comment, tag.Comment);
			PexAssert.AreEqual(genres.Length, tag.Genres.Length);
			PexAssert.AreEqual(year, tag.Year);
			PexAssert.AreEqual(track, tag.Track);
			PexAssert.AreEqual(trackCount, tag.TrackCount);
			PexAssert.AreEqual(copyright, tag.Copyright);
			//PexAssert.IsNotNull(tag.Render());

			PexAssert.AreEqual(false, tag.IsEmpty);
			tag.Clear();
			PexAssert.IsTrue(tag.IsEmpty);

			PexAssert.IsNull(tag.Title, "Title");
			PexAssert.AreEqual(0, tag.Performers.Length, "Performers");
			PexAssert.AreEqual(0, tag.AlbumArtists.Length, "AlbumArtists");
			PexAssert.AreEqual(0, tag.Composers.Length, "Composers");
			PexAssert.IsNull(tag.Album, "Album");
			PexAssert.IsNull(tag.Comment, "Comment");
			PexAssert.AreEqual(0, tag.Genres.Length, "Genres");
			PexAssert.AreEqual(0, tag.Year, "Year");
			PexAssert.AreEqual(0, tag.Track, "Track");
			PexAssert.AreEqual(0, tag.TrackCount, "TrackCount");
			PexAssert.AreEqual(0, tag.Disc, "Disc");
			PexAssert.AreEqual(0, tag.DiscCount, "DiscCount");
			PexAssert.IsNull(tag.Lyrics, "Lyrics");
			PexAssert.IsNull(tag.Comment, "Comment");
			PexAssert.AreEqual(0, tag.BeatsPerMinute, "BeatsPerMinute");
			PexAssert.IsNull(tag.Conductor, "Conductor");
			PexAssert.IsNull(tag.Copyright, "Copyright");
			PexAssert.AreEqual(0, tag.Pictures.Length, "Pictures");
			PexAssert.IsTrue(tag.IsEmpty, "Should be empty.");
		}
		


		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public InfoTag ConstructorTest(ByteVector data)
		{
			InfoTag target = new InfoTag(data);
			return target;
			// TODO: add assertions to method InfoTagTest.ConstructorTest(ByteVector)
		}

		/// <summary>Test stub for .ctor(File, Int64, Int32)</summary>
		[PexMethod(MaxBranches = 20000)]
		public InfoTag ConstructorTest01(
			File file,
			long position,
			int length
		)
		{
			InfoTag target = new InfoTag(file, position, length);
			return target;
			// TODO: add assertions to method InfoTagTest.ConstructorTest01(File, Int64, Int32)
		}

		/// <summary>Test stub for RenderEnclosed()</summary>
		[PexMethod]
		public ByteVector RenderEnclosedTest([PexAssumeUnderTest]InfoTag target)
		{
			ByteVector result = target.RenderEnclosed();
			return result;
			// TODO: add assertions to method InfoTagTest.RenderEnclosedTest(InfoTag)
		}

		/// <summary>Test stub for get_Album()</summary>
		[PexMethod]
		public string AlbumGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string result = target.Album;
			return result;
			// TODO: add assertions to method InfoTagTest.AlbumGetTest(InfoTag)
		}

		/// <summary>Test stub for get_AlbumArtists()</summary>
		[PexMethod]
		public string[] AlbumArtistsGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string[] result = target.AlbumArtists;
			return result;
			// TODO: add assertions to method InfoTagTest.AlbumArtistsGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method InfoTagTest.CommentGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Composers()</summary>
		[PexMethod]
		public string[] ComposersGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string[] result = target.Composers;
			return result;
			// TODO: add assertions to method InfoTagTest.ComposersGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Conductor()</summary>
		[PexMethod]
		public string ConductorGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string result = target.Conductor;
			return result;
			// TODO: add assertions to method InfoTagTest.ConductorGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method InfoTagTest.CopyrightGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method InfoTagTest.DescriptionGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Genres()</summary>
		[PexMethod]
		public string[] GenresGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string[] result = target.Genres;
			return result;
			// TODO: add assertions to method InfoTagTest.GenresGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Performers()</summary>
		[PexMethod]
		public string[] PerformersGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string[] result = target.Performers;
			return result;
			// TODO: add assertions to method InfoTagTest.PerformersGetTest(InfoTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]InfoTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method InfoTagTest.TagTypesGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]InfoTag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method InfoTagTest.TitleGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Track()</summary>
		[PexMethod]
		public uint TrackGetTest([PexAssumeUnderTest]InfoTag target)
		{
			uint result = target.Track;
			return result;
			// TODO: add assertions to method InfoTagTest.TrackGetTest(InfoTag)
		}

		/// <summary>Test stub for get_TrackCount()</summary>
		[PexMethod]
		public uint TrackCountGetTest([PexAssumeUnderTest]InfoTag target)
		{
			uint result = target.TrackCount;
			return result;
			// TODO: add assertions to method InfoTagTest.TrackCountGetTest(InfoTag)
		}

		/// <summary>Test stub for get_Year()</summary>
		[PexMethod]
		public uint YearGetTest([PexAssumeUnderTest]InfoTag target)
		{
			uint result = target.Year;
			return result;
			// TODO: add assertions to method InfoTagTest.YearGetTest(InfoTag)
		}

		/// <summary>Test stub for set_Album(String)</summary>
		[PexMethod]
		public void AlbumSetTest([PexAssumeUnderTest]InfoTag target, string value)
		{
			target.Album = value;
			// TODO: add assertions to method InfoTagTest.AlbumSetTest(InfoTag, String)
		}

		/// <summary>Test stub for set_AlbumArtists(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSetTest([PexAssumeUnderTest]InfoTag target, string[] value)
		{
			target.AlbumArtists = value;
			// TODO: add assertions to method InfoTagTest.AlbumArtistsSetTest(InfoTag, String[])
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]InfoTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method InfoTagTest.CommentSetTest(InfoTag, String)
		}

		/// <summary>Test stub for set_Composers(String[])</summary>
		[PexMethod]
		public void ComposersSetTest([PexAssumeUnderTest]InfoTag target, string[] value)
		{
			target.Composers = value;
			// TODO: add assertions to method InfoTagTest.ComposersSetTest(InfoTag, String[])
		}

		/// <summary>Test stub for set_Conductor(String)</summary>
		[PexMethod]
		public void ConductorSetTest([PexAssumeUnderTest]InfoTag target, string value)
		{
			target.Conductor = value;
			// TODO: add assertions to method InfoTagTest.ConductorSetTest(InfoTag, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]InfoTag target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method InfoTagTest.CopyrightSetTest(InfoTag, String)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]InfoTag target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method InfoTagTest.DescriptionSetTest(InfoTag, String)
		}

		/// <summary>Test stub for set_Genres(String[])</summary>
		[PexMethod]
		public void GenresSetTest([PexAssumeUnderTest]InfoTag target, string[] value)
		{
			target.Genres = value;
			// TODO: add assertions to method InfoTagTest.GenresSetTest(InfoTag, String[])
		}

		/// <summary>Test stub for set_Performers(String[])</summary>
		[PexMethod]
		public void PerformersSetTest([PexAssumeUnderTest]InfoTag target, string[] value)
		{
			target.Performers = value;
			// TODO: add assertions to method InfoTagTest.PerformersSetTest(InfoTag, String[])
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]InfoTag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method InfoTagTest.TitleSetTest(InfoTag, String)
		}

		/// <summary>Test stub for set_Track(UInt32)</summary>
		[PexMethod]
		public void TrackSetTest([PexAssumeUnderTest]InfoTag target, uint value)
		{
			target.Track = value;
			// TODO: add assertions to method InfoTagTest.TrackSetTest(InfoTag, UInt32)
		}

		/// <summary>Test stub for set_TrackCount(UInt32)</summary>
		[PexMethod]
		public void TrackCountSetTest([PexAssumeUnderTest]InfoTag target, uint value)
		{
			target.TrackCount = value;
			// TODO: add assertions to method InfoTagTest.TrackCountSetTest(InfoTag, UInt32)
		}

		/// <summary>Test stub for set_Year(UInt32)</summary>
		[PexMethod]
		public void YearSetTest([PexAssumeUnderTest]InfoTag target, uint value)
		{
			target.Year = value;
			// TODO: add assertions to method InfoTagTest.YearSetTest(InfoTag, UInt32)
		}
	}
}
