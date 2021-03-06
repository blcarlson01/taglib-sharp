using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg;

namespace TagLib.Ogg.Tests
{
    /// <summary>This class contains parameterized unit tests for GroupedComment</summary>
    [TestClass]
    [PexClass(typeof(GroupedComment))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GroupedCommentTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public GroupedComment ConstructorTest()
		{
			GroupedComment target = new GroupedComment();
			return target;
			// TODO: add assertions to method GroupedCommentTest.ConstructorTest()
		}

		/// <summary>Test stub for AddComment(UInt32, XiphComment)</summary>
		[PexMethod]
		public void AddCommentTest(
			[PexAssumeUnderTest]GroupedComment target,
			uint streamSerialNumber,
			XiphComment comment
		)
		{
			target.AddComment(streamSerialNumber, comment);
			// TODO: add assertions to method GroupedCommentTest.AddCommentTest(GroupedComment, UInt32, XiphComment)
		}

		/// <summary>Test stub for AddComment(UInt32, ByteVector)</summary>
		[PexMethod]
		public void AddCommentTest01(
			[PexAssumeUnderTest]GroupedComment target,
			uint streamSerialNumber,
			ByteVector data
		)
		{
			target.AddComment(streamSerialNumber, data);
			// TODO: add assertions to method GroupedCommentTest.AddCommentTest01(GroupedComment, UInt32, ByteVector)
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]GroupedComment target)
		{
			target.Clear();
			// TODO: add assertions to method GroupedCommentTest.ClearTest(GroupedComment)
		}

		/// <summary>Test stub for GetComment(UInt32)</summary>
		[PexMethod]
		public XiphComment GetCommentTest([PexAssumeUnderTest]GroupedComment target, uint streamSerialNumber)
		{
			XiphComment result = target.GetComment(streamSerialNumber);
			return result;
			// TODO: add assertions to method GroupedCommentTest.GetCommentTest(GroupedComment, UInt32)
		}

		/// <summary>Test stub for get_Album()</summary>
		[PexMethod]
		public string AlbumGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.Album;
			return result;
			// TODO: add assertions to method GroupedCommentTest.AlbumGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_AlbumArtists()</summary>
		[PexMethod]
		public string[] AlbumArtistsGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string[] result = target.AlbumArtists;
			return result;
			// TODO: add assertions to method GroupedCommentTest.AlbumArtistsGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_AlbumArtistsSort()</summary>
		[PexMethod]
		public string[] AlbumArtistsSortGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string[] result = target.AlbumArtistsSort;
			return result;
			// TODO: add assertions to method GroupedCommentTest.AlbumArtistsSortGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_AlbumSort()</summary>
		[PexMethod]
		public string AlbumSortGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.AlbumSort;
			return result;
			// TODO: add assertions to method GroupedCommentTest.AlbumSortGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_AmazonId()</summary>
		[PexMethod]
		public string AmazonIdGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.AmazonId;
			return result;
			// TODO: add assertions to method GroupedCommentTest.AmazonIdGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_BeatsPerMinute()</summary>
		[PexMethod]
		public uint BeatsPerMinuteGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			uint result = target.BeatsPerMinute;
			return result;
			// TODO: add assertions to method GroupedCommentTest.BeatsPerMinuteGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method GroupedCommentTest.CommentGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Comments()</summary>
		[PexMethod]
		public IEnumerable<XiphComment> CommentsGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			IEnumerable<XiphComment> result = target.Comments;
			return result;
			// TODO: add assertions to method GroupedCommentTest.CommentsGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Composers()</summary>
		[PexMethod]
		public string[] ComposersGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string[] result = target.Composers;
			return result;
			// TODO: add assertions to method GroupedCommentTest.ComposersGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_ComposersSort()</summary>
		[PexMethod]
		public string[] ComposersSortGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string[] result = target.ComposersSort;
			return result;
			// TODO: add assertions to method GroupedCommentTest.ComposersSortGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Conductor()</summary>
		[PexMethod]
		public string ConductorGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.Conductor;
			return result;
			// TODO: add assertions to method GroupedCommentTest.ConductorGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method GroupedCommentTest.CopyrightGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_DateTagged()</summary>
		[PexMethod]
		public DateTime? DateTaggedGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			DateTime? result = target.DateTagged;
			return result;
			// TODO: add assertions to method GroupedCommentTest.DateTaggedGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method GroupedCommentTest.DescriptionGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Disc()</summary>
		[PexMethod]
		public uint DiscGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			uint result = target.Disc;
			return result;
			// TODO: add assertions to method GroupedCommentTest.DiscGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_DiscCount()</summary>
		[PexMethod]
		public uint DiscCountGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			uint result = target.DiscCount;
			return result;
			// TODO: add assertions to method GroupedCommentTest.DiscCountGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Genres()</summary>
		[PexMethod]
		public string[] GenresGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string[] result = target.Genres;
			return result;
			// TODO: add assertions to method GroupedCommentTest.GenresGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Grouping()</summary>
		[PexMethod]
		public string GroupingGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.Grouping;
			return result;
			// TODO: add assertions to method GroupedCommentTest.GroupingGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method GroupedCommentTest.IsEmptyGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Lyrics()</summary>
		[PexMethod]
		public string LyricsGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.Lyrics;
			return result;
			// TODO: add assertions to method GroupedCommentTest.LyricsGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_MusicBrainzArtistId()</summary>
		[PexMethod]
		public string MusicBrainzArtistIdGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.MusicBrainzArtistId;
			return result;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzArtistIdGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_MusicBrainzDiscId()</summary>
		[PexMethod]
		public string MusicBrainzDiscIdGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.MusicBrainzDiscId;
			return result;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzDiscIdGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseArtistId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseArtistIdGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.MusicBrainzReleaseArtistId;
			return result;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseArtistIdGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseCountry()</summary>
		[PexMethod]
		public string MusicBrainzReleaseCountryGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.MusicBrainzReleaseCountry;
			return result;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseCountryGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseIdGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.MusicBrainzReleaseId;
			return result;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseIdGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseStatus()</summary>
		[PexMethod]
		public string MusicBrainzReleaseStatusGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.MusicBrainzReleaseStatus;
			return result;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseStatusGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseType()</summary>
		[PexMethod]
		public string MusicBrainzReleaseTypeGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.MusicBrainzReleaseType;
			return result;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseTypeGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_MusicBrainzTrackId()</summary>
		[PexMethod]
		public string MusicBrainzTrackIdGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.MusicBrainzTrackId;
			return result;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzTrackIdGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_MusicIpId()</summary>
		[PexMethod]
		public string MusicIpIdGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.MusicIpId;
			return result;
			// TODO: add assertions to method GroupedCommentTest.MusicIpIdGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Performers()</summary>
		[PexMethod]
		public string[] PerformersGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string[] result = target.Performers;
			return result;
			// TODO: add assertions to method GroupedCommentTest.PerformersGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_PerformersRole()</summary>
		[PexMethod]
		public string[] PerformersRoleGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string[] result = target.PerformersRole;
			return result;
			// TODO: add assertions to method GroupedCommentTest.PerformersRoleGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_PerformersSort()</summary>
		[PexMethod]
		public string[] PerformersSortGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string[] result = target.PerformersSort;
			return result;
			// TODO: add assertions to method GroupedCommentTest.PerformersSortGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Pictures()</summary>
		[PexMethod]
		public IPicture[] PicturesGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			IPicture[] result = target.Pictures;
			return result;
			// TODO: add assertions to method GroupedCommentTest.PicturesGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_ReplayGainAlbumGain()</summary>
		[PexMethod]
		public double ReplayGainAlbumGainGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			double result = target.ReplayGainAlbumGain;
			return result;
			// TODO: add assertions to method GroupedCommentTest.ReplayGainAlbumGainGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_ReplayGainAlbumPeak()</summary>
		[PexMethod]
		public double ReplayGainAlbumPeakGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			double result = target.ReplayGainAlbumPeak;
			return result;
			// TODO: add assertions to method GroupedCommentTest.ReplayGainAlbumPeakGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_ReplayGainTrackGain()</summary>
		[PexMethod]
		public double ReplayGainTrackGainGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			double result = target.ReplayGainTrackGain;
			return result;
			// TODO: add assertions to method GroupedCommentTest.ReplayGainTrackGainGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_ReplayGainTrackPeak()</summary>
		[PexMethod]
		public double ReplayGainTrackPeakGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			double result = target.ReplayGainTrackPeak;
			return result;
			// TODO: add assertions to method GroupedCommentTest.ReplayGainTrackPeakGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Subtitle()</summary>
		[PexMethod]
		public string SubtitleGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.Subtitle;
			return result;
			// TODO: add assertions to method GroupedCommentTest.SubtitleGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method GroupedCommentTest.TagTypesGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method GroupedCommentTest.TitleGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_TitleSort()</summary>
		[PexMethod]
		public string TitleSortGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			string result = target.TitleSort;
			return result;
			// TODO: add assertions to method GroupedCommentTest.TitleSortGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Track()</summary>
		[PexMethod]
		public uint TrackGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			uint result = target.Track;
			return result;
			// TODO: add assertions to method GroupedCommentTest.TrackGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_TrackCount()</summary>
		[PexMethod]
		public uint TrackCountGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			uint result = target.TrackCount;
			return result;
			// TODO: add assertions to method GroupedCommentTest.TrackCountGetTest(GroupedComment)
		}

		/// <summary>Test stub for get_Year()</summary>
		[PexMethod]
		public uint YearGetTest([PexAssumeUnderTest]GroupedComment target)
		{
			uint result = target.Year;
			return result;
			// TODO: add assertions to method GroupedCommentTest.YearGetTest(GroupedComment)
		}

		/// <summary>Test stub for set_Album(String)</summary>
		[PexMethod]
		public void AlbumSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.Album = value;
			// TODO: add assertions to method GroupedCommentTest.AlbumSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_AlbumArtists(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSetTest([PexAssumeUnderTest]GroupedComment target, string[] value)
		{
			target.AlbumArtists = value;
			// TODO: add assertions to method GroupedCommentTest.AlbumArtistsSetTest(GroupedComment, String[])
		}

		/// <summary>Test stub for set_AlbumArtistsSort(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSortSetTest([PexAssumeUnderTest]GroupedComment target, string[] value)
		{
			target.AlbumArtistsSort = value;
			// TODO: add assertions to method GroupedCommentTest.AlbumArtistsSortSetTest(GroupedComment, String[])
		}

		/// <summary>Test stub for set_AlbumSort(String)</summary>
		[PexMethod]
		public void AlbumSortSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.AlbumSort = value;
			// TODO: add assertions to method GroupedCommentTest.AlbumSortSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_AmazonId(String)</summary>
		[PexMethod]
		public void AmazonIdSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.AmazonId = value;
			// TODO: add assertions to method GroupedCommentTest.AmazonIdSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_BeatsPerMinute(UInt32)</summary>
		[PexMethod]
		public void BeatsPerMinuteSetTest([PexAssumeUnderTest]GroupedComment target, uint value)
		{
			target.BeatsPerMinute = value;
			// TODO: add assertions to method GroupedCommentTest.BeatsPerMinuteSetTest(GroupedComment, UInt32)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method GroupedCommentTest.CommentSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_Composers(String[])</summary>
		[PexMethod]
		public void ComposersSetTest([PexAssumeUnderTest]GroupedComment target, string[] value)
		{
			target.Composers = value;
			// TODO: add assertions to method GroupedCommentTest.ComposersSetTest(GroupedComment, String[])
		}

		/// <summary>Test stub for set_ComposersSort(String[])</summary>
		[PexMethod]
		public void ComposersSortSetTest([PexAssumeUnderTest]GroupedComment target, string[] value)
		{
			target.ComposersSort = value;
			// TODO: add assertions to method GroupedCommentTest.ComposersSortSetTest(GroupedComment, String[])
		}

		/// <summary>Test stub for set_Conductor(String)</summary>
		[PexMethod]
		public void ConductorSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.Conductor = value;
			// TODO: add assertions to method GroupedCommentTest.ConductorSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method GroupedCommentTest.CopyrightSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_DateTagged(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTaggedSetTest([PexAssumeUnderTest]GroupedComment target, DateTime? value)
		{
			target.DateTagged = value;
			// TODO: add assertions to method GroupedCommentTest.DateTaggedSetTest(GroupedComment, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method GroupedCommentTest.DescriptionSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_Disc(UInt32)</summary>
		[PexMethod]
		public void DiscSetTest([PexAssumeUnderTest]GroupedComment target, uint value)
		{
			target.Disc = value;
			// TODO: add assertions to method GroupedCommentTest.DiscSetTest(GroupedComment, UInt32)
		}

		/// <summary>Test stub for set_DiscCount(UInt32)</summary>
		[PexMethod]
		public void DiscCountSetTest([PexAssumeUnderTest]GroupedComment target, uint value)
		{
			target.DiscCount = value;
			// TODO: add assertions to method GroupedCommentTest.DiscCountSetTest(GroupedComment, UInt32)
		}

		/// <summary>Test stub for set_Genres(String[])</summary>
		[PexMethod]
		public void GenresSetTest([PexAssumeUnderTest]GroupedComment target, string[] value)
		{
			target.Genres = value;
			// TODO: add assertions to method GroupedCommentTest.GenresSetTest(GroupedComment, String[])
		}

		/// <summary>Test stub for set_Grouping(String)</summary>
		[PexMethod]
		public void GroupingSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.Grouping = value;
			// TODO: add assertions to method GroupedCommentTest.GroupingSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_Lyrics(String)</summary>
		[PexMethod]
		public void LyricsSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.Lyrics = value;
			// TODO: add assertions to method GroupedCommentTest.LyricsSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzArtistIdSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.MusicBrainzArtistId = value;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzArtistIdSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzDiscId(String)</summary>
		[PexMethod]
		public void MusicBrainzDiscIdSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.MusicBrainzDiscId = value;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzDiscIdSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseArtistIdSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.MusicBrainzReleaseArtistId = value;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseArtistIdSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseCountry(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseCountrySetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.MusicBrainzReleaseCountry = value;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseCountrySetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseIdSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.MusicBrainzReleaseId = value;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseIdSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseStatus(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseStatusSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.MusicBrainzReleaseStatus = value;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseStatusSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseType(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseTypeSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.MusicBrainzReleaseType = value;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzReleaseTypeSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_MusicBrainzTrackId(String)</summary>
		[PexMethod]
		public void MusicBrainzTrackIdSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.MusicBrainzTrackId = value;
			// TODO: add assertions to method GroupedCommentTest.MusicBrainzTrackIdSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_MusicIpId(String)</summary>
		[PexMethod]
		public void MusicIpIdSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.MusicIpId = value;
			// TODO: add assertions to method GroupedCommentTest.MusicIpIdSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_Performers(String[])</summary>
		[PexMethod]
		public void PerformersSetTest([PexAssumeUnderTest]GroupedComment target, string[] value)
		{
			target.Performers = value;
			// TODO: add assertions to method GroupedCommentTest.PerformersSetTest(GroupedComment, String[])
		}

		/// <summary>Test stub for set_PerformersRole(String[])</summary>
		[PexMethod]
		public void PerformersRoleSetTest([PexAssumeUnderTest]GroupedComment target, string[] value)
		{
			target.PerformersRole = value;
			// TODO: add assertions to method GroupedCommentTest.PerformersRoleSetTest(GroupedComment, String[])
		}

		/// <summary>Test stub for set_PerformersSort(String[])</summary>
		[PexMethod]
		public void PerformersSortSetTest([PexAssumeUnderTest]GroupedComment target, string[] value)
		{
			target.PerformersSort = value;
			// TODO: add assertions to method GroupedCommentTest.PerformersSortSetTest(GroupedComment, String[])
		}

		/// <summary>Test stub for set_Pictures(IPicture[])</summary>
		[PexMethod]
		public void PicturesSetTest([PexAssumeUnderTest]GroupedComment target, IPicture[] value)
		{
			target.Pictures = value;
			// TODO: add assertions to method GroupedCommentTest.PicturesSetTest(GroupedComment, IPicture[])
		}

		/// <summary>Test stub for set_ReplayGainAlbumGain(Double)</summary>
		[PexMethod]
		public void ReplayGainAlbumGainSetTest([PexAssumeUnderTest]GroupedComment target, double value)
		{
			target.ReplayGainAlbumGain = value;
			// TODO: add assertions to method GroupedCommentTest.ReplayGainAlbumGainSetTest(GroupedComment, Double)
		}

		/// <summary>Test stub for set_ReplayGainAlbumPeak(Double)</summary>
		[PexMethod]
		public void ReplayGainAlbumPeakSetTest([PexAssumeUnderTest]GroupedComment target, double value)
		{
			target.ReplayGainAlbumPeak = value;
			// TODO: add assertions to method GroupedCommentTest.ReplayGainAlbumPeakSetTest(GroupedComment, Double)
		}

		/// <summary>Test stub for set_ReplayGainTrackGain(Double)</summary>
		[PexMethod]
		public void ReplayGainTrackGainSetTest([PexAssumeUnderTest]GroupedComment target, double value)
		{
			target.ReplayGainTrackGain = value;
			// TODO: add assertions to method GroupedCommentTest.ReplayGainTrackGainSetTest(GroupedComment, Double)
		}

		/// <summary>Test stub for set_ReplayGainTrackPeak(Double)</summary>
		[PexMethod]
		public void ReplayGainTrackPeakSetTest([PexAssumeUnderTest]GroupedComment target, double value)
		{
			target.ReplayGainTrackPeak = value;
			// TODO: add assertions to method GroupedCommentTest.ReplayGainTrackPeakSetTest(GroupedComment, Double)
		}

		/// <summary>Test stub for set_Subtitle(String)</summary>
		[PexMethod]
		public void SubtitleSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.Subtitle = value;
			// TODO: add assertions to method GroupedCommentTest.SubtitleSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method GroupedCommentTest.TitleSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_TitleSort(String)</summary>
		[PexMethod]
		public void TitleSortSetTest([PexAssumeUnderTest]GroupedComment target, string value)
		{
			target.TitleSort = value;
			// TODO: add assertions to method GroupedCommentTest.TitleSortSetTest(GroupedComment, String)
		}

		/// <summary>Test stub for set_Track(UInt32)</summary>
		[PexMethod]
		public void TrackSetTest([PexAssumeUnderTest]GroupedComment target, uint value)
		{
			target.Track = value;
			// TODO: add assertions to method GroupedCommentTest.TrackSetTest(GroupedComment, UInt32)
		}

		/// <summary>Test stub for set_TrackCount(UInt32)</summary>
		[PexMethod]
		public void TrackCountSetTest([PexAssumeUnderTest]GroupedComment target, uint value)
		{
			target.TrackCount = value;
			// TODO: add assertions to method GroupedCommentTest.TrackCountSetTest(GroupedComment, UInt32)
		}

		/// <summary>Test stub for set_Year(UInt32)</summary>
		[PexMethod]
		public void YearSetTest([PexAssumeUnderTest]GroupedComment target, uint value)
		{
			target.Year = value;
			// TODO: add assertions to method GroupedCommentTest.YearSetTest(GroupedComment, UInt32)
		}
	}
}
