using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for CombinedTag</summary>
    [TestClass]
    [PexClass(typeof(CombinedTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CombinedTagTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public CombinedTag ConstructorTest()
		{
			CombinedTag target = new CombinedTag();
			return target;
			// TODO: add assertions to method CombinedTagTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(Tag[])</summary>
		[PexMethod]
		public CombinedTag ConstructorTest01(Tag[] tags)
		{
			CombinedTag target = new CombinedTag(tags);
			return target;
			// TODO: add assertions to method CombinedTagTest.ConstructorTest01(Tag[])
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]CombinedTag target)
		{
			target.Clear();
			// TODO: add assertions to method CombinedTagTest.ClearTest(CombinedTag)
		}

		/// <summary>Test stub for SetTags(Tag[])</summary>
		[PexMethod]
		public void SetTagsTest([PexAssumeUnderTest]CombinedTag target, Tag[] tags)
		{
			target.SetTags(tags);
			// TODO: add assertions to method CombinedTagTest.SetTagsTest(CombinedTag, Tag[])
		}

		/// <summary>Test stub for get_Album()</summary>
		[PexMethod]
		public string AlbumGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.Album;
			return result;
			// TODO: add assertions to method CombinedTagTest.AlbumGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_AlbumArtists()</summary>
		[PexMethod]
		public string[] AlbumArtistsGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string[] result = target.AlbumArtists;
			return result;
			// TODO: add assertions to method CombinedTagTest.AlbumArtistsGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_AlbumArtistsSort()</summary>
		[PexMethod]
		public string[] AlbumArtistsSortGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string[] result = target.AlbumArtistsSort;
			return result;
			// TODO: add assertions to method CombinedTagTest.AlbumArtistsSortGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_AlbumSort()</summary>
		[PexMethod]
		public string AlbumSortGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.AlbumSort;
			return result;
			// TODO: add assertions to method CombinedTagTest.AlbumSortGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_AmazonId()</summary>
		[PexMethod]
		public string AmazonIdGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.AmazonId;
			return result;
			// TODO: add assertions to method CombinedTagTest.AmazonIdGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_BeatsPerMinute()</summary>
		[PexMethod]
		public uint BeatsPerMinuteGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			uint result = target.BeatsPerMinute;
			return result;
			// TODO: add assertions to method CombinedTagTest.BeatsPerMinuteGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method CombinedTagTest.CommentGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Composers()</summary>
		[PexMethod]
		public string[] ComposersGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string[] result = target.Composers;
			return result;
			// TODO: add assertions to method CombinedTagTest.ComposersGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_ComposersSort()</summary>
		[PexMethod]
		public string[] ComposersSortGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string[] result = target.ComposersSort;
			return result;
			// TODO: add assertions to method CombinedTagTest.ComposersSortGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Conductor()</summary>
		[PexMethod]
		public string ConductorGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.Conductor;
			return result;
			// TODO: add assertions to method CombinedTagTest.ConductorGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method CombinedTagTest.CopyrightGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_DateTagged()</summary>
		[PexMethod]
		public DateTime? DateTaggedGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			DateTime? result = target.DateTagged;
			return result;
			// TODO: add assertions to method CombinedTagTest.DateTaggedGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method CombinedTagTest.DescriptionGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Disc()</summary>
		[PexMethod]
		public uint DiscGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			uint result = target.Disc;
			return result;
			// TODO: add assertions to method CombinedTagTest.DiscGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_DiscCount()</summary>
		[PexMethod]
		public uint DiscCountGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			uint result = target.DiscCount;
			return result;
			// TODO: add assertions to method CombinedTagTest.DiscCountGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Genres()</summary>
		[PexMethod]
		public string[] GenresGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string[] result = target.Genres;
			return result;
			// TODO: add assertions to method CombinedTagTest.GenresGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Grouping()</summary>
		[PexMethod]
		public string GroupingGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.Grouping;
			return result;
			// TODO: add assertions to method CombinedTagTest.GroupingGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method CombinedTagTest.IsEmptyGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Lyrics()</summary>
		[PexMethod]
		public string LyricsGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.Lyrics;
			return result;
			// TODO: add assertions to method CombinedTagTest.LyricsGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_MusicBrainzArtistId()</summary>
		[PexMethod]
		public string MusicBrainzArtistIdGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.MusicBrainzArtistId;
			return result;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzArtistIdGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_MusicBrainzDiscId()</summary>
		[PexMethod]
		public string MusicBrainzDiscIdGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.MusicBrainzDiscId;
			return result;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzDiscIdGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseArtistId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseArtistIdGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.MusicBrainzReleaseArtistId;
			return result;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseArtistIdGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseCountry()</summary>
		[PexMethod]
		public string MusicBrainzReleaseCountryGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.MusicBrainzReleaseCountry;
			return result;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseCountryGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseIdGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.MusicBrainzReleaseId;
			return result;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseIdGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseStatus()</summary>
		[PexMethod]
		public string MusicBrainzReleaseStatusGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.MusicBrainzReleaseStatus;
			return result;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseStatusGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseType()</summary>
		[PexMethod]
		public string MusicBrainzReleaseTypeGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.MusicBrainzReleaseType;
			return result;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseTypeGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_MusicBrainzTrackId()</summary>
		[PexMethod]
		public string MusicBrainzTrackIdGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.MusicBrainzTrackId;
			return result;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzTrackIdGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_MusicIpId()</summary>
		[PexMethod]
		public string MusicIpIdGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.MusicIpId;
			return result;
			// TODO: add assertions to method CombinedTagTest.MusicIpIdGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Performers()</summary>
		[PexMethod]
		public string[] PerformersGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string[] result = target.Performers;
			return result;
			// TODO: add assertions to method CombinedTagTest.PerformersGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_PerformersRole()</summary>
		[PexMethod]
		public string[] PerformersRoleGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string[] result = target.PerformersRole;
			return result;
			// TODO: add assertions to method CombinedTagTest.PerformersRoleGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_PerformersSort()</summary>
		[PexMethod]
		public string[] PerformersSortGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string[] result = target.PerformersSort;
			return result;
			// TODO: add assertions to method CombinedTagTest.PerformersSortGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Pictures()</summary>
		[PexMethod]
		public IPicture[] PicturesGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			IPicture[] result = target.Pictures;
			return result;
			// TODO: add assertions to method CombinedTagTest.PicturesGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_ReplayGainAlbumGain()</summary>
		[PexMethod]
		public double ReplayGainAlbumGainGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			double result = target.ReplayGainAlbumGain;
			return result;
			// TODO: add assertions to method CombinedTagTest.ReplayGainAlbumGainGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_ReplayGainAlbumPeak()</summary>
		[PexMethod]
		public double ReplayGainAlbumPeakGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			double result = target.ReplayGainAlbumPeak;
			return result;
			// TODO: add assertions to method CombinedTagTest.ReplayGainAlbumPeakGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_ReplayGainTrackGain()</summary>
		[PexMethod]
		public double ReplayGainTrackGainGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			double result = target.ReplayGainTrackGain;
			return result;
			// TODO: add assertions to method CombinedTagTest.ReplayGainTrackGainGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_ReplayGainTrackPeak()</summary>
		[PexMethod]
		public double ReplayGainTrackPeakGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			double result = target.ReplayGainTrackPeak;
			return result;
			// TODO: add assertions to method CombinedTagTest.ReplayGainTrackPeakGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Subtitle()</summary>
		[PexMethod]
		public string SubtitleGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.Subtitle;
			return result;
			// TODO: add assertions to method CombinedTagTest.SubtitleGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method CombinedTagTest.TagTypesGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Tags()</summary>
		[PexMethod]
		public Tag[] TagsGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			Tag[] result = target.Tags;
			return result;
			// TODO: add assertions to method CombinedTagTest.TagsGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method CombinedTagTest.TitleGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_TitleSort()</summary>
		[PexMethod]
		public string TitleSortGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			string result = target.TitleSort;
			return result;
			// TODO: add assertions to method CombinedTagTest.TitleSortGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Track()</summary>
		[PexMethod]
		public uint TrackGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			uint result = target.Track;
			return result;
			// TODO: add assertions to method CombinedTagTest.TrackGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_TrackCount()</summary>
		[PexMethod]
		public uint TrackCountGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			uint result = target.TrackCount;
			return result;
			// TODO: add assertions to method CombinedTagTest.TrackCountGetTest(CombinedTag)
		}

		/// <summary>Test stub for get_Year()</summary>
		[PexMethod]
		public uint YearGetTest([PexAssumeUnderTest]CombinedTag target)
		{
			uint result = target.Year;
			return result;
			// TODO: add assertions to method CombinedTagTest.YearGetTest(CombinedTag)
		}

		/// <summary>Test stub for set_Album(String)</summary>
		[PexMethod]
		public void AlbumSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.Album = value;
			// TODO: add assertions to method CombinedTagTest.AlbumSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_AlbumArtists(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSetTest([PexAssumeUnderTest]CombinedTag target, string[] value)
		{
			target.AlbumArtists = value;
			// TODO: add assertions to method CombinedTagTest.AlbumArtistsSetTest(CombinedTag, String[])
		}

		/// <summary>Test stub for set_AlbumArtistsSort(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSortSetTest([PexAssumeUnderTest]CombinedTag target, string[] value)
		{
			target.AlbumArtistsSort = value;
			// TODO: add assertions to method CombinedTagTest.AlbumArtistsSortSetTest(CombinedTag, String[])
		}

		/// <summary>Test stub for set_AlbumSort(String)</summary>
		[PexMethod]
		public void AlbumSortSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.AlbumSort = value;
			// TODO: add assertions to method CombinedTagTest.AlbumSortSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_AmazonId(String)</summary>
		[PexMethod]
		public void AmazonIdSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.AmazonId = value;
			// TODO: add assertions to method CombinedTagTest.AmazonIdSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_BeatsPerMinute(UInt32)</summary>
		[PexMethod]
		public void BeatsPerMinuteSetTest([PexAssumeUnderTest]CombinedTag target, uint value)
		{
			target.BeatsPerMinute = value;
			// TODO: add assertions to method CombinedTagTest.BeatsPerMinuteSetTest(CombinedTag, UInt32)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method CombinedTagTest.CommentSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_Composers(String[])</summary>
		[PexMethod]
		public void ComposersSetTest([PexAssumeUnderTest]CombinedTag target, string[] value)
		{
			target.Composers = value;
			// TODO: add assertions to method CombinedTagTest.ComposersSetTest(CombinedTag, String[])
		}

		/// <summary>Test stub for set_ComposersSort(String[])</summary>
		[PexMethod]
		public void ComposersSortSetTest([PexAssumeUnderTest]CombinedTag target, string[] value)
		{
			target.ComposersSort = value;
			// TODO: add assertions to method CombinedTagTest.ComposersSortSetTest(CombinedTag, String[])
		}

		/// <summary>Test stub for set_Conductor(String)</summary>
		[PexMethod]
		public void ConductorSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.Conductor = value;
			// TODO: add assertions to method CombinedTagTest.ConductorSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method CombinedTagTest.CopyrightSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_DateTagged(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTaggedSetTest([PexAssumeUnderTest]CombinedTag target, DateTime? value)
		{
			target.DateTagged = value;
			// TODO: add assertions to method CombinedTagTest.DateTaggedSetTest(CombinedTag, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method CombinedTagTest.DescriptionSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_Disc(UInt32)</summary>
		[PexMethod]
		public void DiscSetTest([PexAssumeUnderTest]CombinedTag target, uint value)
		{
			target.Disc = value;
			// TODO: add assertions to method CombinedTagTest.DiscSetTest(CombinedTag, UInt32)
		}

		/// <summary>Test stub for set_DiscCount(UInt32)</summary>
		[PexMethod]
		public void DiscCountSetTest([PexAssumeUnderTest]CombinedTag target, uint value)
		{
			target.DiscCount = value;
			// TODO: add assertions to method CombinedTagTest.DiscCountSetTest(CombinedTag, UInt32)
		}

		/// <summary>Test stub for set_Genres(String[])</summary>
		[PexMethod]
		public void GenresSetTest([PexAssumeUnderTest]CombinedTag target, string[] value)
		{
			target.Genres = value;
			// TODO: add assertions to method CombinedTagTest.GenresSetTest(CombinedTag, String[])
		}

		/// <summary>Test stub for set_Grouping(String)</summary>
		[PexMethod]
		public void GroupingSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.Grouping = value;
			// TODO: add assertions to method CombinedTagTest.GroupingSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_Lyrics(String)</summary>
		[PexMethod]
		public void LyricsSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.Lyrics = value;
			// TODO: add assertions to method CombinedTagTest.LyricsSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzArtistIdSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.MusicBrainzArtistId = value;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzArtistIdSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzDiscId(String)</summary>
		[PexMethod]
		public void MusicBrainzDiscIdSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.MusicBrainzDiscId = value;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzDiscIdSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseArtistIdSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.MusicBrainzReleaseArtistId = value;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseArtistIdSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseCountry(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseCountrySetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.MusicBrainzReleaseCountry = value;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseCountrySetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseIdSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.MusicBrainzReleaseId = value;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseIdSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseStatus(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseStatusSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.MusicBrainzReleaseStatus = value;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseStatusSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseType(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseTypeSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.MusicBrainzReleaseType = value;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzReleaseTypeSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzTrackId(String)</summary>
		[PexMethod]
		public void MusicBrainzTrackIdSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.MusicBrainzTrackId = value;
			// TODO: add assertions to method CombinedTagTest.MusicBrainzTrackIdSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_MusicIpId(String)</summary>
		[PexMethod]
		public void MusicIpIdSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.MusicIpId = value;
			// TODO: add assertions to method CombinedTagTest.MusicIpIdSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_Performers(String[])</summary>
		[PexMethod]
		public void PerformersSetTest([PexAssumeUnderTest]CombinedTag target, string[] value)
		{
			target.Performers = value;
			// TODO: add assertions to method CombinedTagTest.PerformersSetTest(CombinedTag, String[])
		}

		/// <summary>Test stub for set_PerformersRole(String[])</summary>
		[PexMethod]
		public void PerformersRoleSetTest([PexAssumeUnderTest]CombinedTag target, string[] value)
		{
			target.PerformersRole = value;
			// TODO: add assertions to method CombinedTagTest.PerformersRoleSetTest(CombinedTag, String[])
		}

		/// <summary>Test stub for set_PerformersSort(String[])</summary>
		[PexMethod]
		public void PerformersSortSetTest([PexAssumeUnderTest]CombinedTag target, string[] value)
		{
			target.PerformersSort = value;
			// TODO: add assertions to method CombinedTagTest.PerformersSortSetTest(CombinedTag, String[])
		}

		/// <summary>Test stub for set_Pictures(IPicture[])</summary>
		[PexMethod]
		public void PicturesSetTest([PexAssumeUnderTest]CombinedTag target, IPicture[] value)
		{
			target.Pictures = value;
			// TODO: add assertions to method CombinedTagTest.PicturesSetTest(CombinedTag, IPicture[])
		}

		/// <summary>Test stub for set_ReplayGainAlbumGain(Double)</summary>
		[PexMethod]
		public void ReplayGainAlbumGainSetTest([PexAssumeUnderTest]CombinedTag target, double value)
		{
			target.ReplayGainAlbumGain = value;
			// TODO: add assertions to method CombinedTagTest.ReplayGainAlbumGainSetTest(CombinedTag, Double)
		}

		/// <summary>Test stub for set_ReplayGainAlbumPeak(Double)</summary>
		[PexMethod]
		public void ReplayGainAlbumPeakSetTest([PexAssumeUnderTest]CombinedTag target, double value)
		{
			target.ReplayGainAlbumPeak = value;
			// TODO: add assertions to method CombinedTagTest.ReplayGainAlbumPeakSetTest(CombinedTag, Double)
		}

		/// <summary>Test stub for set_ReplayGainTrackGain(Double)</summary>
		[PexMethod]
		public void ReplayGainTrackGainSetTest([PexAssumeUnderTest]CombinedTag target, double value)
		{
			target.ReplayGainTrackGain = value;
			// TODO: add assertions to method CombinedTagTest.ReplayGainTrackGainSetTest(CombinedTag, Double)
		}

		/// <summary>Test stub for set_ReplayGainTrackPeak(Double)</summary>
		[PexMethod]
		public void ReplayGainTrackPeakSetTest([PexAssumeUnderTest]CombinedTag target, double value)
		{
			target.ReplayGainTrackPeak = value;
			// TODO: add assertions to method CombinedTagTest.ReplayGainTrackPeakSetTest(CombinedTag, Double)
		}

		/// <summary>Test stub for set_Subtitle(String)</summary>
		[PexMethod]
		public void SubtitleSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.Subtitle = value;
			// TODO: add assertions to method CombinedTagTest.SubtitleSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method CombinedTagTest.TitleSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_TitleSort(String)</summary>
		[PexMethod]
		public void TitleSortSetTest([PexAssumeUnderTest]CombinedTag target, string value)
		{
			target.TitleSort = value;
			// TODO: add assertions to method CombinedTagTest.TitleSortSetTest(CombinedTag, String)
		}

		/// <summary>Test stub for set_Track(UInt32)</summary>
		[PexMethod]
		public void TrackSetTest([PexAssumeUnderTest]CombinedTag target, uint value)
		{
			target.Track = value;
			// TODO: add assertions to method CombinedTagTest.TrackSetTest(CombinedTag, UInt32)
		}

		/// <summary>Test stub for set_TrackCount(UInt32)</summary>
		[PexMethod]
		public void TrackCountSetTest([PexAssumeUnderTest]CombinedTag target, uint value)
		{
			target.TrackCount = value;
			// TODO: add assertions to method CombinedTagTest.TrackCountSetTest(CombinedTag, UInt32)
		}

		/// <summary>Test stub for set_Year(UInt32)</summary>
		[PexMethod]
		public void YearSetTest([PexAssumeUnderTest]CombinedTag target, uint value)
		{
			target.Year = value;
			// TODO: add assertions to method CombinedTagTest.YearSetTest(CombinedTag, UInt32)
		}
	}
}
