using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for Tag</summary>
    [TestClass]
    [PexClass(typeof(Tag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TagTest
    {

		/// <summary>Test stub for .ctor(Tags, TargetType, IUIDElement)</summary>
		[PexMethod]
		public Tag ConstructorTest(
			Tags tags,
			TargetType targetTypeValue,
			IUIDElement element
		)
		{
			Tag target = new Tag(tags, targetTypeValue, element);
			return target;
			// TODO: add assertions to method TagTest.ConstructorTest(Tags, TargetType, IUIDElement)
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]Tag target)
		{
			target.Clear();
			// TODO: add assertions to method TagTest.ClearTest(Tag)
		}

		/// <summary>Test stub for Get(String, String, Boolean)</summary>
		[PexMethod]
		public string[] GetTest(
			[PexAssumeUnderTest]Tag target,
			string key,
			string subkey,
			bool recu
		)
		{
			string[] result = target.Get(key, subkey, recu);
			return result;
			// TODO: add assertions to method TagTest.GetTest(Tag, String, String, Boolean)
		}

		/// <summary>Test stub for MakeTargetType(UInt16)</summary>
		[PexMethod]
		public TargetType MakeTargetTypeTest([PexAssumeUnderTest]Tag target, ushort targetTypeValue)
		{
			TargetType result = target.MakeTargetType(targetTypeValue);
			return result;
			// TODO: add assertions to method TagTest.MakeTargetTypeTest(Tag, UInt16)
		}

		/// <summary>Test stub for Remove(String, String)</summary>
		[PexMethod]
		public void RemoveTest(
			[PexAssumeUnderTest]Tag target,
			string key,
			string subkey
		)
		{
			target.Remove(key, subkey);
			// TODO: add assertions to method TagTest.RemoveTest(Tag, String, String)
		}

		/// <summary>Test stub for Set(String, String, String)</summary>
		[PexMethod]
		public void SetTest(
			[PexAssumeUnderTest]Tag target,
			string key,
			string subkey,
			string value
		)
		{
			target.Set(key, subkey, value);
			// TODO: add assertions to method TagTest.SetTest(Tag, String, String, String)
		}

		/// <summary>Test stub for Set(String, String, UInt32, String)</summary>
		[PexMethod]
		public void SetTest01(
			[PexAssumeUnderTest]Tag target,
			string key,
			string subkey,
			uint value,
			string format
		)
		{
			target.Set(key, subkey, value, format);
			// TODO: add assertions to method TagTest.SetTest01(Tag, String, String, UInt32, String)
		}

		/// <summary>Test stub for Set(String, String, String[])</summary>
		[PexMethod]
		public void SetTest02(
			[PexAssumeUnderTest]Tag target,
			string key,
			string subkey,
			string[] values
		)
		{
			target.Set(key, subkey, values);
			// TODO: add assertions to method TagTest.SetTest02(Tag, String, String, String[])
		}

		/// <summary>Test stub for get_Album()</summary>
		[PexMethod]
		public string AlbumGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Album;
			return result;
			// TODO: add assertions to method TagTest.AlbumGetTest(Tag)
		}

		/// <summary>Test stub for get_AlbumArtists()</summary>
		[PexMethod]
		public string[] AlbumArtistsGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.AlbumArtists;
			return result;
			// TODO: add assertions to method TagTest.AlbumArtistsGetTest(Tag)
		}

		/// <summary>Test stub for get_AlbumArtistsSort()</summary>
		[PexMethod]
		public string[] AlbumArtistsSortGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.AlbumArtistsSort;
			return result;
			// TODO: add assertions to method TagTest.AlbumArtistsSortGetTest(Tag)
		}

		/// <summary>Test stub for get_AlbumSort()</summary>
		[PexMethod]
		public string AlbumSortGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.AlbumSort;
			return result;
			// TODO: add assertions to method TagTest.AlbumSortGetTest(Tag)
		}

		/// <summary>Test stub for get_BeatsPerMinute()</summary>
		[PexMethod]
		public uint BeatsPerMinuteGetTest([PexAssumeUnderTest]Tag target)
		{
			uint result = target.BeatsPerMinute;
			return result;
			// TODO: add assertions to method TagTest.BeatsPerMinuteGetTest(Tag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method TagTest.CommentGetTest(Tag)
		}

		/// <summary>Test stub for get_Composers()</summary>
		[PexMethod]
		public string[] ComposersGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.Composers;
			return result;
			// TODO: add assertions to method TagTest.ComposersGetTest(Tag)
		}

		/// <summary>Test stub for get_ComposersSort()</summary>
		[PexMethod]
		public string[] ComposersSortGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.ComposersSort;
			return result;
			// TODO: add assertions to method TagTest.ComposersSortGetTest(Tag)
		}

		/// <summary>Test stub for get_Conductor()</summary>
		[PexMethod]
		public string ConductorGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Conductor;
			return result;
			// TODO: add assertions to method TagTest.ConductorGetTest(Tag)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method TagTest.CopyrightGetTest(Tag)
		}

		/// <summary>Test stub for get_DateTagged()</summary>
		[PexMethod]
		public DateTime? DateTaggedGetTest([PexAssumeUnderTest]Tag target)
		{
			DateTime? result = target.DateTagged;
			return result;
			// TODO: add assertions to method TagTest.DateTaggedGetTest(Tag)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method TagTest.DescriptionGetTest(Tag)
		}

		/// <summary>Test stub for get_Disc()</summary>
		[PexMethod]
		public uint DiscGetTest([PexAssumeUnderTest]Tag target)
		{
			uint result = target.Disc;
			return result;
			// TODO: add assertions to method TagTest.DiscGetTest(Tag)
		}

		/// <summary>Test stub for get_DiscCount()</summary>
		[PexMethod]
		public uint DiscCountGetTest([PexAssumeUnderTest]Tag target)
		{
			uint result = target.DiscCount;
			return result;
			// TODO: add assertions to method TagTest.DiscCountGetTest(Tag)
		}

		/// <summary>Test stub for get_Genres()</summary>
		[PexMethod]
		public string[] GenresGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.Genres;
			return result;
			// TODO: add assertions to method TagTest.GenresGetTest(Tag)
		}

		/// <summary>Test stub for get_Grouping()</summary>
		[PexMethod]
		public string GroupingGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Grouping;
			return result;
			// TODO: add assertions to method TagTest.GroupingGetTest(Tag)
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest([PexAssumeUnderTest]Tag target)
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method TagTest.IsEmptyGetTest(Tag)
		}

		/// <summary>Test stub for get_Lyrics()</summary>
		[PexMethod]
		public string LyricsGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Lyrics;
			return result;
			// TODO: add assertions to method TagTest.LyricsGetTest(Tag)
		}

		/// <summary>Test stub for get_MusicBrainzArtistId()</summary>
		[PexMethod]
		public string MusicBrainzArtistIdGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.MusicBrainzArtistId;
			return result;
			// TODO: add assertions to method TagTest.MusicBrainzArtistIdGetTest(Tag)
		}

		/// <summary>Test stub for get_MusicBrainzDiscId()</summary>
		[PexMethod]
		public string MusicBrainzDiscIdGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.MusicBrainzDiscId;
			return result;
			// TODO: add assertions to method TagTest.MusicBrainzDiscIdGetTest(Tag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseArtistId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseArtistIdGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.MusicBrainzReleaseArtistId;
			return result;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseArtistIdGetTest(Tag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseCountry()</summary>
		[PexMethod]
		public string MusicBrainzReleaseCountryGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.MusicBrainzReleaseCountry;
			return result;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseCountryGetTest(Tag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseIdGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.MusicBrainzReleaseId;
			return result;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseIdGetTest(Tag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseStatus()</summary>
		[PexMethod]
		public string MusicBrainzReleaseStatusGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.MusicBrainzReleaseStatus;
			return result;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseStatusGetTest(Tag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseType()</summary>
		[PexMethod]
		public string MusicBrainzReleaseTypeGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.MusicBrainzReleaseType;
			return result;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseTypeGetTest(Tag)
		}

		/// <summary>Test stub for get_MusicBrainzTrackId()</summary>
		[PexMethod]
		public string MusicBrainzTrackIdGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.MusicBrainzTrackId;
			return result;
			// TODO: add assertions to method TagTest.MusicBrainzTrackIdGetTest(Tag)
		}

		/// <summary>Test stub for get_MusicIpId()</summary>
		[PexMethod]
		public string MusicIpIdGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.MusicIpId;
			return result;
			// TODO: add assertions to method TagTest.MusicIpIdGetTest(Tag)
		}

		/// <summary>Test stub for get_Parent()</summary>
		[PexMethod]
		public Tag ParentGetTest([PexAssumeUnderTest]Tag target)
		{
			Tag result = target.Parent;
			return result;
			// TODO: add assertions to method TagTest.ParentGetTest(Tag)
		}

		/// <summary>Test stub for get_Performers()</summary>
		[PexMethod]
		public string[] PerformersGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.Performers;
			return result;
			// TODO: add assertions to method TagTest.PerformersGetTest(Tag)
		}

		/// <summary>Test stub for get_PerformersRole()</summary>
		[PexMethod]
		public string[] PerformersRoleGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.PerformersRole;
			return result;
			// TODO: add assertions to method TagTest.PerformersRoleGetTest(Tag)
		}

		/// <summary>Test stub for get_PerformersSort()</summary>
		[PexMethod]
		public string[] PerformersSortGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.PerformersSort;
			return result;
			// TODO: add assertions to method TagTest.PerformersSortGetTest(Tag)
		}

		/// <summary>Test stub for get_Pictures()</summary>
		[PexMethod]
		public IPicture[] PicturesGetTest([PexAssumeUnderTest]Tag target)
		{
			IPicture[] result = target.Pictures;
			return result;
			// TODO: add assertions to method TagTest.PicturesGetTest(Tag)
		}

		/// <summary>Test stub for get_Subtitle()</summary>
		[PexMethod]
		public string SubtitleGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Subtitle;
			return result;
			// TODO: add assertions to method TagTest.SubtitleGetTest(Tag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]Tag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method TagTest.TagTypesGetTest(Tag)
		}

		/// <summary>Test stub for get_TargetType()</summary>
		[PexMethod]
		public TargetType TargetTypeGetTest([PexAssumeUnderTest]Tag target)
		{
			TargetType result = target.TargetType;
			return result;
			// TODO: add assertions to method TagTest.TargetTypeGetTest(Tag)
		}

		/// <summary>Test stub for get_TargetTypeValue()</summary>
		[PexMethod]
		public ushort TargetTypeValueGetTest([PexAssumeUnderTest]Tag target)
		{
			ushort result = target.TargetTypeValue;
			return result;
			// TODO: add assertions to method TagTest.TargetTypeValueGetTest(Tag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method TagTest.TitleGetTest(Tag)
		}

		/// <summary>Test stub for get_TitleSort()</summary>
		[PexMethod]
		public string TitleSortGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.TitleSort;
			return result;
			// TODO: add assertions to method TagTest.TitleSortGetTest(Tag)
		}

		/// <summary>Test stub for get_Track()</summary>
		[PexMethod]
		public uint TrackGetTest([PexAssumeUnderTest]Tag target)
		{
			uint result = target.Track;
			return result;
			// TODO: add assertions to method TagTest.TrackGetTest(Tag)
		}

		/// <summary>Test stub for get_TrackCount()</summary>
		[PexMethod]
		public uint TrackCountGetTest([PexAssumeUnderTest]Tag target)
		{
			uint result = target.TrackCount;
			return result;
			// TODO: add assertions to method TagTest.TrackCountGetTest(Tag)
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

		/// <summary>Test stub for set_AlbumArtists(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.AlbumArtists = value;
			// TODO: add assertions to method TagTest.AlbumArtistsSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_AlbumArtistsSort(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSortSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.AlbumArtistsSort = value;
			// TODO: add assertions to method TagTest.AlbumArtistsSortSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_AlbumSort(String)</summary>
		[PexMethod]
		public void AlbumSortSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.AlbumSort = value;
			// TODO: add assertions to method TagTest.AlbumSortSetTest(Tag, String)
		}

		/// <summary>Test stub for set_BeatsPerMinute(UInt32)</summary>
		[PexMethod]
		public void BeatsPerMinuteSetTest([PexAssumeUnderTest]Tag target, uint value)
		{
			target.BeatsPerMinute = value;
			// TODO: add assertions to method TagTest.BeatsPerMinuteSetTest(Tag, UInt32)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method TagTest.CommentSetTest(Tag, String)
		}

		/// <summary>Test stub for set_Composers(String[])</summary>
		[PexMethod]
		public void ComposersSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.Composers = value;
			// TODO: add assertions to method TagTest.ComposersSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_ComposersSort(String[])</summary>
		[PexMethod]
		public void ComposersSortSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.ComposersSort = value;
			// TODO: add assertions to method TagTest.ComposersSortSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_Conductor(String)</summary>
		[PexMethod]
		public void ConductorSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Conductor = value;
			// TODO: add assertions to method TagTest.ConductorSetTest(Tag, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method TagTest.CopyrightSetTest(Tag, String)
		}

		/// <summary>Test stub for set_DateTagged(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTaggedSetTest([PexAssumeUnderTest]Tag target, DateTime? value)
		{
			target.DateTagged = value;
			// TODO: add assertions to method TagTest.DateTaggedSetTest(Tag, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method TagTest.DescriptionSetTest(Tag, String)
		}

		/// <summary>Test stub for set_Disc(UInt32)</summary>
		[PexMethod]
		public void DiscSetTest([PexAssumeUnderTest]Tag target, uint value)
		{
			target.Disc = value;
			// TODO: add assertions to method TagTest.DiscSetTest(Tag, UInt32)
		}

		/// <summary>Test stub for set_DiscCount(UInt32)</summary>
		[PexMethod]
		public void DiscCountSetTest([PexAssumeUnderTest]Tag target, uint value)
		{
			target.DiscCount = value;
			// TODO: add assertions to method TagTest.DiscCountSetTest(Tag, UInt32)
		}

		/// <summary>Test stub for set_Genres(String[])</summary>
		[PexMethod]
		public void GenresSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.Genres = value;
			// TODO: add assertions to method TagTest.GenresSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_Grouping(String)</summary>
		[PexMethod]
		public void GroupingSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Grouping = value;
			// TODO: add assertions to method TagTest.GroupingSetTest(Tag, String)
		}

		/// <summary>Test stub for set_Lyrics(String)</summary>
		[PexMethod]
		public void LyricsSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Lyrics = value;
			// TODO: add assertions to method TagTest.LyricsSetTest(Tag, String)
		}

		/// <summary>Test stub for set_MusicBrainzArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzArtistIdSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.MusicBrainzArtistId = value;
			// TODO: add assertions to method TagTest.MusicBrainzArtistIdSetTest(Tag, String)
		}

		/// <summary>Test stub for set_MusicBrainzDiscId(String)</summary>
		[PexMethod]
		public void MusicBrainzDiscIdSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.MusicBrainzDiscId = value;
			// TODO: add assertions to method TagTest.MusicBrainzDiscIdSetTest(Tag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseArtistIdSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.MusicBrainzReleaseArtistId = value;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseArtistIdSetTest(Tag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseCountry(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseCountrySetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.MusicBrainzReleaseCountry = value;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseCountrySetTest(Tag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseIdSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.MusicBrainzReleaseId = value;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseIdSetTest(Tag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseStatus(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseStatusSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.MusicBrainzReleaseStatus = value;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseStatusSetTest(Tag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseType(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseTypeSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.MusicBrainzReleaseType = value;
			// TODO: add assertions to method TagTest.MusicBrainzReleaseTypeSetTest(Tag, String)
		}

		/// <summary>Test stub for set_MusicBrainzTrackId(String)</summary>
		[PexMethod]
		public void MusicBrainzTrackIdSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.MusicBrainzTrackId = value;
			// TODO: add assertions to method TagTest.MusicBrainzTrackIdSetTest(Tag, String)
		}

		/// <summary>Test stub for set_MusicIpId(String)</summary>
		[PexMethod]
		public void MusicIpIdSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.MusicIpId = value;
			// TODO: add assertions to method TagTest.MusicIpIdSetTest(Tag, String)
		}

		/// <summary>Test stub for set_Performers(String[])</summary>
		[PexMethod]
		public void PerformersSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.Performers = value;
			// TODO: add assertions to method TagTest.PerformersSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_PerformersRole(String[])</summary>
		[PexMethod]
		public void PerformersRoleSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.PerformersRole = value;
			// TODO: add assertions to method TagTest.PerformersRoleSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_PerformersSort(String[])</summary>
		[PexMethod]
		public void PerformersSortSetTest([PexAssumeUnderTest]Tag target, string[] value)
		{
			target.PerformersSort = value;
			// TODO: add assertions to method TagTest.PerformersSortSetTest(Tag, String[])
		}

		/// <summary>Test stub for set_Pictures(IPicture[])</summary>
		[PexMethod]
		public void PicturesSetTest([PexAssumeUnderTest]Tag target, IPicture[] value)
		{
			target.Pictures = value;
			// TODO: add assertions to method TagTest.PicturesSetTest(Tag, IPicture[])
		}

		/// <summary>Test stub for set_Subtitle(String)</summary>
		[PexMethod]
		public void SubtitleSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Subtitle = value;
			// TODO: add assertions to method TagTest.SubtitleSetTest(Tag, String)
		}

		/// <summary>Test stub for set_TargetType(TargetType)</summary>
		[PexMethod]
		public void TargetTypeSetTest([PexAssumeUnderTest]Tag target, TargetType value)
		{
			target.TargetType = value;
			// TODO: add assertions to method TagTest.TargetTypeSetTest(Tag, TargetType)
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method TagTest.TitleSetTest(Tag, String)
		}

		/// <summary>Test stub for set_TitleSort(String)</summary>
		[PexMethod]
		public void TitleSortSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.TitleSort = value;
			// TODO: add assertions to method TagTest.TitleSortSetTest(Tag, String)
		}

		/// <summary>Test stub for set_Track(UInt32)</summary>
		[PexMethod]
		public void TrackSetTest([PexAssumeUnderTest]Tag target, uint value)
		{
			target.Track = value;
			// TODO: add assertions to method TagTest.TrackSetTest(Tag, UInt32)
		}

		/// <summary>Test stub for set_TrackCount(UInt32)</summary>
		[PexMethod]
		public void TrackCountSetTest([PexAssumeUnderTest]Tag target, uint value)
		{
			target.TrackCount = value;
			// TODO: add assertions to method TagTest.TrackCountSetTest(Tag, UInt32)
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
