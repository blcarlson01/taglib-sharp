using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg;

namespace TagLib.Ogg.Tests
{
    /// <summary>This class contains parameterized unit tests for XiphComment</summary>
    [TestClass]
    [PexClass(typeof(XiphComment))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class XiphCommentTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public XiphComment ConstructorTest()
		{
			XiphComment target = new XiphComment();
			return target;
			// TODO: add assertions to method XiphCommentTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public XiphComment ConstructorTest01(ByteVector data)
		{
			XiphComment target = new XiphComment(data);
			return target;
			// TODO: add assertions to method XiphCommentTest.ConstructorTest01(ByteVector)
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]XiphComment target)
		{
			target.Clear();
			// TODO: add assertions to method XiphCommentTest.ClearTest(XiphComment)
		}

		/// <summary>Test stub for GetEnumerator()</summary>
		[PexMethod]
		public IEnumerator<string> GetEnumeratorTest([PexAssumeUnderTest]XiphComment target)
		{
			IEnumerator<string> result = target.GetEnumerator();
			return result;
			// TODO: add assertions to method XiphCommentTest.GetEnumeratorTest(XiphComment)
		}

		/// <summary>Test stub for GetField(String)</summary>
		[PexMethod]
		public string[] GetFieldTest([PexAssumeUnderTest]XiphComment target, string key)
		{
			string[] result = target.GetField(key);
			return result;
			// TODO: add assertions to method XiphCommentTest.GetFieldTest(XiphComment, String)
		}

		/// <summary>Test stub for GetFirstField(String)</summary>
		[PexMethod]
		public string GetFirstFieldTest([PexAssumeUnderTest]XiphComment target, string key)
		{
			string result = target.GetFirstField(key);
			return result;
			// TODO: add assertions to method XiphCommentTest.GetFirstFieldTest(XiphComment, String)
		}

		/// <summary>Test stub for RemoveField(String)</summary>
		[PexMethod]
		public void RemoveFieldTest([PexAssumeUnderTest]XiphComment target, string key)
		{
			target.RemoveField(key);
			// TODO: add assertions to method XiphCommentTest.RemoveFieldTest(XiphComment, String)
		}

		/// <summary>Test stub for Render(Boolean)</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]XiphComment target, bool addFramingBit)
		{
			ByteVector result = target.Render(addFramingBit);
			return result;
			// TODO: add assertions to method XiphCommentTest.RenderTest(XiphComment, Boolean)
		}

		/// <summary>Test stub for SetField(String, UInt32, String)</summary>
		[PexMethod]
		public void SetFieldTest(
			[PexAssumeUnderTest]XiphComment target,
			string key,
			uint number,
			string format
		)
		{
			target.SetField(key, number, format);
			// TODO: add assertions to method XiphCommentTest.SetFieldTest(XiphComment, String, UInt32, String)
		}

		/// <summary>Test stub for SetField(String, String[])</summary>
		[PexMethod]
		public void SetFieldTest01(
			[PexAssumeUnderTest]XiphComment target,
			string key,
			string[] values
		)
		{
			target.SetField(key, values);
			// TODO: add assertions to method XiphCommentTest.SetFieldTest01(XiphComment, String, String[])
		}

		/// <summary>Test stub for get_Album()</summary>
		[PexMethod]
		public string AlbumGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.Album;
			return result;
			// TODO: add assertions to method XiphCommentTest.AlbumGetTest(XiphComment)
		}

		/// <summary>Test stub for get_AlbumArtists()</summary>
		[PexMethod]
		public string[] AlbumArtistsGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string[] result = target.AlbumArtists;
			return result;
			// TODO: add assertions to method XiphCommentTest.AlbumArtistsGetTest(XiphComment)
		}

		/// <summary>Test stub for get_AlbumArtistsSort()</summary>
		[PexMethod]
		public string[] AlbumArtistsSortGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string[] result = target.AlbumArtistsSort;
			return result;
			// TODO: add assertions to method XiphCommentTest.AlbumArtistsSortGetTest(XiphComment)
		}

		/// <summary>Test stub for get_AlbumSort()</summary>
		[PexMethod]
		public string AlbumSortGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.AlbumSort;
			return result;
			// TODO: add assertions to method XiphCommentTest.AlbumSortGetTest(XiphComment)
		}

		/// <summary>Test stub for get_AmazonId()</summary>
		[PexMethod]
		public string AmazonIdGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.AmazonId;
			return result;
			// TODO: add assertions to method XiphCommentTest.AmazonIdGetTest(XiphComment)
		}

		/// <summary>Test stub for get_BeatsPerMinute()</summary>
		[PexMethod]
		public uint BeatsPerMinuteGetTest([PexAssumeUnderTest]XiphComment target)
		{
			uint result = target.BeatsPerMinute;
			return result;
			// TODO: add assertions to method XiphCommentTest.BeatsPerMinuteGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method XiphCommentTest.CommentGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Composers()</summary>
		[PexMethod]
		public string[] ComposersGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string[] result = target.Composers;
			return result;
			// TODO: add assertions to method XiphCommentTest.ComposersGetTest(XiphComment)
		}

		/// <summary>Test stub for get_ComposersSort()</summary>
		[PexMethod]
		public string[] ComposersSortGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string[] result = target.ComposersSort;
			return result;
			// TODO: add assertions to method XiphCommentTest.ComposersSortGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Conductor()</summary>
		[PexMethod]
		public string ConductorGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.Conductor;
			return result;
			// TODO: add assertions to method XiphCommentTest.ConductorGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method XiphCommentTest.CopyrightGetTest(XiphComment)
		}

		/// <summary>Test stub for get_DateTagged()</summary>
		[PexMethod]
		public DateTime? DateTaggedGetTest([PexAssumeUnderTest]XiphComment target)
		{
			DateTime? result = target.DateTagged;
			return result;
			// TODO: add assertions to method XiphCommentTest.DateTaggedGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method XiphCommentTest.DescriptionGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Disc()</summary>
		[PexMethod]
		public uint DiscGetTest([PexAssumeUnderTest]XiphComment target)
		{
			uint result = target.Disc;
			return result;
			// TODO: add assertions to method XiphCommentTest.DiscGetTest(XiphComment)
		}

		/// <summary>Test stub for get_DiscCount()</summary>
		[PexMethod]
		public uint DiscCountGetTest([PexAssumeUnderTest]XiphComment target)
		{
			uint result = target.DiscCount;
			return result;
			// TODO: add assertions to method XiphCommentTest.DiscCountGetTest(XiphComment)
		}

		/// <summary>Test stub for get_FieldCount()</summary>
		[PexMethod]
		public uint FieldCountGetTest([PexAssumeUnderTest]XiphComment target)
		{
			uint result = target.FieldCount;
			return result;
			// TODO: add assertions to method XiphCommentTest.FieldCountGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Genres()</summary>
		[PexMethod]
		public string[] GenresGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string[] result = target.Genres;
			return result;
			// TODO: add assertions to method XiphCommentTest.GenresGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Grouping()</summary>
		[PexMethod]
		public string GroupingGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.Grouping;
			return result;
			// TODO: add assertions to method XiphCommentTest.GroupingGetTest(XiphComment)
		}

		/// <summary>Test stub for get_IsCompilation()</summary>
		[PexMethod]
		public bool IsCompilationGetTest([PexAssumeUnderTest]XiphComment target)
		{
			bool result = target.IsCompilation;
			return result;
			// TODO: add assertions to method XiphCommentTest.IsCompilationGetTest(XiphComment)
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest([PexAssumeUnderTest]XiphComment target)
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method XiphCommentTest.IsEmptyGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Lyrics()</summary>
		[PexMethod]
		public string LyricsGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.Lyrics;
			return result;
			// TODO: add assertions to method XiphCommentTest.LyricsGetTest(XiphComment)
		}

		/// <summary>Test stub for get_MusicBrainzArtistId()</summary>
		[PexMethod]
		public string MusicBrainzArtistIdGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.MusicBrainzArtistId;
			return result;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzArtistIdGetTest(XiphComment)
		}

		/// <summary>Test stub for get_MusicBrainzDiscId()</summary>
		[PexMethod]
		public string MusicBrainzDiscIdGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.MusicBrainzDiscId;
			return result;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzDiscIdGetTest(XiphComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseArtistId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseArtistIdGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.MusicBrainzReleaseArtistId;
			return result;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseArtistIdGetTest(XiphComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseCountry()</summary>
		[PexMethod]
		public string MusicBrainzReleaseCountryGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.MusicBrainzReleaseCountry;
			return result;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseCountryGetTest(XiphComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseIdGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.MusicBrainzReleaseId;
			return result;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseIdGetTest(XiphComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseStatus()</summary>
		[PexMethod]
		public string MusicBrainzReleaseStatusGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.MusicBrainzReleaseStatus;
			return result;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseStatusGetTest(XiphComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseType()</summary>
		[PexMethod]
		public string MusicBrainzReleaseTypeGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.MusicBrainzReleaseType;
			return result;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseTypeGetTest(XiphComment)
		}

		/// <summary>Test stub for get_MusicBrainzTrackId()</summary>
		[PexMethod]
		public string MusicBrainzTrackIdGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.MusicBrainzTrackId;
			return result;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzTrackIdGetTest(XiphComment)
		}

		/// <summary>Test stub for get_MusicIpId()</summary>
		[PexMethod]
		public string MusicIpIdGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.MusicIpId;
			return result;
			// TODO: add assertions to method XiphCommentTest.MusicIpIdGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Performers()</summary>
		[PexMethod]
		public string[] PerformersGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string[] result = target.Performers;
			return result;
			// TODO: add assertions to method XiphCommentTest.PerformersGetTest(XiphComment)
		}

		/// <summary>Test stub for get_PerformersRole()</summary>
		[PexMethod]
		public string[] PerformersRoleGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string[] result = target.PerformersRole;
			return result;
			// TODO: add assertions to method XiphCommentTest.PerformersRoleGetTest(XiphComment)
		}

		/// <summary>Test stub for get_PerformersSort()</summary>
		[PexMethod]
		public string[] PerformersSortGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string[] result = target.PerformersSort;
			return result;
			// TODO: add assertions to method XiphCommentTest.PerformersSortGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Pictures()</summary>
		[PexMethod]
		public IPicture[] PicturesGetTest([PexAssumeUnderTest]XiphComment target)
		{
			IPicture[] result = target.Pictures;
			return result;
			// TODO: add assertions to method XiphCommentTest.PicturesGetTest(XiphComment)
		}

		/// <summary>Test stub for get_ReplayGainAlbumGain()</summary>
		[PexMethod]
		public double ReplayGainAlbumGainGetTest([PexAssumeUnderTest]XiphComment target)
		{
			double result = target.ReplayGainAlbumGain;
			return result;
			// TODO: add assertions to method XiphCommentTest.ReplayGainAlbumGainGetTest(XiphComment)
		}

		/// <summary>Test stub for get_ReplayGainAlbumPeak()</summary>
		[PexMethod]
		public double ReplayGainAlbumPeakGetTest([PexAssumeUnderTest]XiphComment target)
		{
			double result = target.ReplayGainAlbumPeak;
			return result;
			// TODO: add assertions to method XiphCommentTest.ReplayGainAlbumPeakGetTest(XiphComment)
		}

		/// <summary>Test stub for get_ReplayGainTrackGain()</summary>
		[PexMethod]
		public double ReplayGainTrackGainGetTest([PexAssumeUnderTest]XiphComment target)
		{
			double result = target.ReplayGainTrackGain;
			return result;
			// TODO: add assertions to method XiphCommentTest.ReplayGainTrackGainGetTest(XiphComment)
		}

		/// <summary>Test stub for get_ReplayGainTrackPeak()</summary>
		[PexMethod]
		public double ReplayGainTrackPeakGetTest([PexAssumeUnderTest]XiphComment target)
		{
			double result = target.ReplayGainTrackPeak;
			return result;
			// TODO: add assertions to method XiphCommentTest.ReplayGainTrackPeakGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Subtitle()</summary>
		[PexMethod]
		public string SubtitleGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.Subtitle;
			return result;
			// TODO: add assertions to method XiphCommentTest.SubtitleGetTest(XiphComment)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]XiphComment target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method XiphCommentTest.TagTypesGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method XiphCommentTest.TitleGetTest(XiphComment)
		}

		/// <summary>Test stub for get_TitleSort()</summary>
		[PexMethod]
		public string TitleSortGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.TitleSort;
			return result;
			// TODO: add assertions to method XiphCommentTest.TitleSortGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Track()</summary>
		[PexMethod]
		public uint TrackGetTest([PexAssumeUnderTest]XiphComment target)
		{
			uint result = target.Track;
			return result;
			// TODO: add assertions to method XiphCommentTest.TrackGetTest(XiphComment)
		}

		/// <summary>Test stub for get_TrackCount()</summary>
		[PexMethod]
		public uint TrackCountGetTest([PexAssumeUnderTest]XiphComment target)
		{
			uint result = target.TrackCount;
			return result;
			// TODO: add assertions to method XiphCommentTest.TrackCountGetTest(XiphComment)
		}

		/// <summary>Test stub for get_VendorId()</summary>
		[PexMethod]
		public string VendorIdGetTest([PexAssumeUnderTest]XiphComment target)
		{
			string result = target.VendorId;
			return result;
			// TODO: add assertions to method XiphCommentTest.VendorIdGetTest(XiphComment)
		}

		/// <summary>Test stub for get_Year()</summary>
		[PexMethod]
		public uint YearGetTest([PexAssumeUnderTest]XiphComment target)
		{
			uint result = target.Year;
			return result;
			// TODO: add assertions to method XiphCommentTest.YearGetTest(XiphComment)
		}

		/// <summary>Test stub for set_Album(String)</summary>
		[PexMethod]
		public void AlbumSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.Album = value;
			// TODO: add assertions to method XiphCommentTest.AlbumSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_AlbumArtists(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSetTest([PexAssumeUnderTest]XiphComment target, string[] value)
		{
			target.AlbumArtists = value;
			// TODO: add assertions to method XiphCommentTest.AlbumArtistsSetTest(XiphComment, String[])
		}

		/// <summary>Test stub for set_AlbumArtistsSort(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSortSetTest([PexAssumeUnderTest]XiphComment target, string[] value)
		{
			target.AlbumArtistsSort = value;
			// TODO: add assertions to method XiphCommentTest.AlbumArtistsSortSetTest(XiphComment, String[])
		}

		/// <summary>Test stub for set_AlbumSort(String)</summary>
		[PexMethod]
		public void AlbumSortSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.AlbumSort = value;
			// TODO: add assertions to method XiphCommentTest.AlbumSortSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_AmazonId(String)</summary>
		[PexMethod]
		public void AmazonIdSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.AmazonId = value;
			// TODO: add assertions to method XiphCommentTest.AmazonIdSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_BeatsPerMinute(UInt32)</summary>
		[PexMethod]
		public void BeatsPerMinuteSetTest([PexAssumeUnderTest]XiphComment target, uint value)
		{
			target.BeatsPerMinute = value;
			// TODO: add assertions to method XiphCommentTest.BeatsPerMinuteSetTest(XiphComment, UInt32)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method XiphCommentTest.CommentSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_Composers(String[])</summary>
		[PexMethod]
		public void ComposersSetTest([PexAssumeUnderTest]XiphComment target, string[] value)
		{
			target.Composers = value;
			// TODO: add assertions to method XiphCommentTest.ComposersSetTest(XiphComment, String[])
		}

		/// <summary>Test stub for set_ComposersSort(String[])</summary>
		[PexMethod]
		public void ComposersSortSetTest([PexAssumeUnderTest]XiphComment target, string[] value)
		{
			target.ComposersSort = value;
			// TODO: add assertions to method XiphCommentTest.ComposersSortSetTest(XiphComment, String[])
		}

		/// <summary>Test stub for set_Conductor(String)</summary>
		[PexMethod]
		public void ConductorSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.Conductor = value;
			// TODO: add assertions to method XiphCommentTest.ConductorSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method XiphCommentTest.CopyrightSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_DateTagged(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTaggedSetTest([PexAssumeUnderTest]XiphComment target, DateTime? value)
		{
			target.DateTagged = value;
			// TODO: add assertions to method XiphCommentTest.DateTaggedSetTest(XiphComment, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method XiphCommentTest.DescriptionSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_Disc(UInt32)</summary>
		[PexMethod]
		public void DiscSetTest([PexAssumeUnderTest]XiphComment target, uint value)
		{
			target.Disc = value;
			// TODO: add assertions to method XiphCommentTest.DiscSetTest(XiphComment, UInt32)
		}

		/// <summary>Test stub for set_DiscCount(UInt32)</summary>
		[PexMethod]
		public void DiscCountSetTest([PexAssumeUnderTest]XiphComment target, uint value)
		{
			target.DiscCount = value;
			// TODO: add assertions to method XiphCommentTest.DiscCountSetTest(XiphComment, UInt32)
		}

		/// <summary>Test stub for set_Genres(String[])</summary>
		[PexMethod]
		public void GenresSetTest([PexAssumeUnderTest]XiphComment target, string[] value)
		{
			target.Genres = value;
			// TODO: add assertions to method XiphCommentTest.GenresSetTest(XiphComment, String[])
		}

		/// <summary>Test stub for set_Grouping(String)</summary>
		[PexMethod]
		public void GroupingSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.Grouping = value;
			// TODO: add assertions to method XiphCommentTest.GroupingSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_IsCompilation(Boolean)</summary>
		[PexMethod]
		public void IsCompilationSetTest([PexAssumeUnderTest]XiphComment target, bool value)
		{
			target.IsCompilation = value;
			// TODO: add assertions to method XiphCommentTest.IsCompilationSetTest(XiphComment, Boolean)
		}

		/// <summary>Test stub for set_Lyrics(String)</summary>
		[PexMethod]
		public void LyricsSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.Lyrics = value;
			// TODO: add assertions to method XiphCommentTest.LyricsSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzArtistIdSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.MusicBrainzArtistId = value;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzArtistIdSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzDiscId(String)</summary>
		[PexMethod]
		public void MusicBrainzDiscIdSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.MusicBrainzDiscId = value;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzDiscIdSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseArtistIdSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.MusicBrainzReleaseArtistId = value;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseArtistIdSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseCountry(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseCountrySetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.MusicBrainzReleaseCountry = value;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseCountrySetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseIdSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.MusicBrainzReleaseId = value;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseIdSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseStatus(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseStatusSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.MusicBrainzReleaseStatus = value;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseStatusSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseType(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseTypeSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.MusicBrainzReleaseType = value;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzReleaseTypeSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzTrackId(String)</summary>
		[PexMethod]
		public void MusicBrainzTrackIdSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.MusicBrainzTrackId = value;
			// TODO: add assertions to method XiphCommentTest.MusicBrainzTrackIdSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_MusicIpId(String)</summary>
		[PexMethod]
		public void MusicIpIdSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.MusicIpId = value;
			// TODO: add assertions to method XiphCommentTest.MusicIpIdSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_Performers(String[])</summary>
		[PexMethod]
		public void PerformersSetTest([PexAssumeUnderTest]XiphComment target, string[] value)
		{
			target.Performers = value;
			// TODO: add assertions to method XiphCommentTest.PerformersSetTest(XiphComment, String[])
		}

		/// <summary>Test stub for set_PerformersRole(String[])</summary>
		[PexMethod]
		public void PerformersRoleSetTest([PexAssumeUnderTest]XiphComment target, string[] value)
		{
			target.PerformersRole = value;
			// TODO: add assertions to method XiphCommentTest.PerformersRoleSetTest(XiphComment, String[])
		}

		/// <summary>Test stub for set_PerformersSort(String[])</summary>
		[PexMethod]
		public void PerformersSortSetTest([PexAssumeUnderTest]XiphComment target, string[] value)
		{
			target.PerformersSort = value;
			// TODO: add assertions to method XiphCommentTest.PerformersSortSetTest(XiphComment, String[])
		}

		/// <summary>Test stub for set_Pictures(IPicture[])</summary>
		[PexMethod]
		public void PicturesSetTest([PexAssumeUnderTest]XiphComment target, IPicture[] value)
		{
			target.Pictures = value;
			// TODO: add assertions to method XiphCommentTest.PicturesSetTest(XiphComment, IPicture[])
		}

		/// <summary>Test stub for set_ReplayGainAlbumGain(Double)</summary>
		[PexMethod]
		public void ReplayGainAlbumGainSetTest([PexAssumeUnderTest]XiphComment target, double value)
		{
			target.ReplayGainAlbumGain = value;
			// TODO: add assertions to method XiphCommentTest.ReplayGainAlbumGainSetTest(XiphComment, Double)
		}

		/// <summary>Test stub for set_ReplayGainAlbumPeak(Double)</summary>
		[PexMethod]
		public void ReplayGainAlbumPeakSetTest([PexAssumeUnderTest]XiphComment target, double value)
		{
			target.ReplayGainAlbumPeak = value;
			// TODO: add assertions to method XiphCommentTest.ReplayGainAlbumPeakSetTest(XiphComment, Double)
		}

		/// <summary>Test stub for set_ReplayGainTrackGain(Double)</summary>
		[PexMethod]
		public void ReplayGainTrackGainSetTest([PexAssumeUnderTest]XiphComment target, double value)
		{
			target.ReplayGainTrackGain = value;
			// TODO: add assertions to method XiphCommentTest.ReplayGainTrackGainSetTest(XiphComment, Double)
		}

		/// <summary>Test stub for set_ReplayGainTrackPeak(Double)</summary>
		[PexMethod]
		public void ReplayGainTrackPeakSetTest([PexAssumeUnderTest]XiphComment target, double value)
		{
			target.ReplayGainTrackPeak = value;
			// TODO: add assertions to method XiphCommentTest.ReplayGainTrackPeakSetTest(XiphComment, Double)
		}

		/// <summary>Test stub for set_Subtitle(String)</summary>
		[PexMethod]
		public void SubtitleSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.Subtitle = value;
			// TODO: add assertions to method XiphCommentTest.SubtitleSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method XiphCommentTest.TitleSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_TitleSort(String)</summary>
		[PexMethod]
		public void TitleSortSetTest([PexAssumeUnderTest]XiphComment target, string value)
		{
			target.TitleSort = value;
			// TODO: add assertions to method XiphCommentTest.TitleSortSetTest(XiphComment, String)
		}

		/// <summary>Test stub for set_Track(UInt32)</summary>
		[PexMethod]
		public void TrackSetTest([PexAssumeUnderTest]XiphComment target, uint value)
		{
			target.Track = value;
			// TODO: add assertions to method XiphCommentTest.TrackSetTest(XiphComment, UInt32)
		}

		/// <summary>Test stub for set_TrackCount(UInt32)</summary>
		[PexMethod]
		public void TrackCountSetTest([PexAssumeUnderTest]XiphComment target, uint value)
		{
			target.TrackCount = value;
			// TODO: add assertions to method XiphCommentTest.TrackCountSetTest(XiphComment, UInt32)
		}

		/// <summary>Test stub for set_Year(UInt32)</summary>
		[PexMethod]
		public void YearSetTest([PexAssumeUnderTest]XiphComment target, uint value)
		{
			target.Year = value;
			// TODO: add assertions to method XiphCommentTest.YearSetTest(XiphComment, UInt32)
		}
	}
}
