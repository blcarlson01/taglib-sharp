using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for AppleTag</summary>
    [TestClass]
    [PexClass(typeof(AppleTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AppleTagTest
    {

		/// <summary>Test stub for .ctor(IsoUserDataBox)</summary>
		[PexMethod]
		public AppleTag ConstructorTest(IsoUserDataBox box)
		{
			AppleTag target = new AppleTag(box);
			return target;
			// TODO: add assertions to method AppleTagTest.ConstructorTest(IsoUserDataBox)
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]AppleTag target)
		{
			target.Clear();
			// TODO: add assertions to method AppleTagTest.ClearTest(AppleTag)
		}

		/// <summary>Test stub for ClearData(ByteVector)</summary>
		[PexMethod]
		public void ClearDataTest([PexAssumeUnderTest]AppleTag target, ByteVector type)
		{
			target.ClearData(type);
			// TODO: add assertions to method AppleTagTest.ClearDataTest(AppleTag, ByteVector)
		}

		/// <summary>Test stub for DataBoxes(IEnumerable`1&lt;ByteVector&gt;)</summary>
		[PexMethod]
		public IEnumerable<AppleDataBox> DataBoxesTest([PexAssumeUnderTest]AppleTag target, IEnumerable<ByteVector> types)
		{
			IEnumerable<AppleDataBox> result = target.DataBoxes(types);
			return result;
			// TODO: add assertions to method AppleTagTest.DataBoxesTest(AppleTag, IEnumerable`1<ByteVector>)
		}

		/// <summary>Test stub for DataBoxes(ByteVector[])</summary>
		[PexMethod]
		public IEnumerable<AppleDataBox> DataBoxesTest01([PexAssumeUnderTest]AppleTag target, ByteVector[] types)
		{
			IEnumerable<AppleDataBox> result = target.DataBoxes(types);
			return result;
			// TODO: add assertions to method AppleTagTest.DataBoxesTest01(AppleTag, ByteVector[])
		}

		/// <summary>Test stub for DataBoxes(String, String)</summary>
		[PexMethod]
		public IEnumerable<AppleDataBox> DataBoxesTest02(
			[PexAssumeUnderTest]AppleTag target,
			string mean,
			string name
		)
		{
			IEnumerable<AppleDataBox> result = target.DataBoxes(mean, name);
			return result;
			// TODO: add assertions to method AppleTagTest.DataBoxesTest02(AppleTag, String, String)
		}

		/// <summary>Test stub for DetachIlst()</summary>
		[PexMethod]
		public void DetachIlstTest([PexAssumeUnderTest]AppleTag target)
		{
			target.DetachIlst();
			// TODO: add assertions to method AppleTagTest.DetachIlstTest(AppleTag)
		}

		
		/// <summary>Test stub for GetDashBox(String, String)</summary>
		[PexMethod]
		public string GetDashBoxTest(
			[PexAssumeUnderTest]AppleTag target,
			string meanstring,
			string namestring
		)
		{
			string result = target.GetDashBox(meanstring, namestring);
			return result;
			// TODO: add assertions to method AppleTagTest.GetDashBoxTest(AppleTag, String, String)
		}

		/// <summary>Test stub for GetEnumerator()</summary>
		[PexMethod]
		public IEnumerator<Box> GetEnumeratorTest([PexAssumeUnderTest]AppleTag target)
		{
			IEnumerator<Box> result = target.GetEnumerator();
			return result;
			// TODO: add assertions to method AppleTagTest.GetEnumeratorTest(AppleTag)
		}

		/// <summary>Test stub for GetText(ByteVector)</summary>
		[PexMethod]
		public string[] GetTextTest([PexAssumeUnderTest]AppleTag target, ByteVector type)
		{
			string[] result = target.GetText(type);
			return result;
			// TODO: add assertions to method AppleTagTest.GetTextTest(AppleTag, ByteVector)
		}

		/// <summary>Test stub for SetDashBox(String, String, String)</summary>
		[PexMethod]
		public void SetDashBoxTest(
			[PexAssumeUnderTest]AppleTag target,
			string meanstring,
			string namestring,
			string datastring
		)
		{
			target.SetDashBox(meanstring, namestring, datastring);
			// TODO: add assertions to method AppleTagTest.SetDashBoxTest(AppleTag, String, String, String)
		}

		/// <summary>Test stub for SetData(ByteVector, AppleDataBox[])</summary>
		[PexMethod]
		public void SetDataTest(
			[PexAssumeUnderTest]AppleTag target,
			ByteVector type,
			AppleDataBox[] boxes
		)
		{
			target.SetData(type, boxes);
			// TODO: add assertions to method AppleTagTest.SetDataTest(AppleTag, ByteVector, AppleDataBox[])
		}

		/// <summary>Test stub for SetData(ByteVector, ByteVectorCollection, UInt32)</summary>
		[PexMethod]
		public void SetDataTest01(
			[PexAssumeUnderTest]AppleTag target,
			ByteVector type,
			ByteVectorCollection data,
			uint flags
		)
		{
			target.SetData(type, data, flags);
			// TODO: add assertions to method AppleTagTest.SetDataTest01(AppleTag, ByteVector, ByteVectorCollection, UInt32)
		}

		/// <summary>Test stub for SetData(ByteVector, ByteVector, UInt32)</summary>
		[PexMethod]
		public void SetDataTest02(
			[PexAssumeUnderTest]AppleTag target,
			ByteVector type,
			ByteVector data,
			uint flags
		)
		{
			target.SetData(type, data, flags);
			// TODO: add assertions to method AppleTagTest.SetDataTest02(AppleTag, ByteVector, ByteVector, UInt32)
		}

		/// <summary>Test stub for SetText(ByteVector, String[])</summary>
		[PexMethod]
		public void SetTextTest(
			[PexAssumeUnderTest]AppleTag target,
			ByteVector type,
			string[] text
		)
		{
			target.SetText(type, text);
			// TODO: add assertions to method AppleTagTest.SetTextTest(AppleTag, ByteVector, String[])
		}

		/// <summary>Test stub for SetText(ByteVector, String)</summary>
		[PexMethod]
		public void SetTextTest01(
			[PexAssumeUnderTest]AppleTag target,
			ByteVector type,
			string text
		)
		{
			target.SetText(type, text);
			// TODO: add assertions to method AppleTagTest.SetTextTest01(AppleTag, ByteVector, String)
		}

		/// <summary>Test stub for get_Album()</summary>
		[PexMethod]
		public string AlbumGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.Album;
			return result;
			// TODO: add assertions to method AppleTagTest.AlbumGetTest(AppleTag)
		}

		/// <summary>Test stub for get_AlbumArtists()</summary>
		[PexMethod]
		public string[] AlbumArtistsGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string[] result = target.AlbumArtists;
			return result;
			// TODO: add assertions to method AppleTagTest.AlbumArtistsGetTest(AppleTag)
		}

		/// <summary>Test stub for get_AlbumArtistsSort()</summary>
		[PexMethod]
		public string[] AlbumArtistsSortGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string[] result = target.AlbumArtistsSort;
			return result;
			// TODO: add assertions to method AppleTagTest.AlbumArtistsSortGetTest(AppleTag)
		}

		/// <summary>Test stub for get_AlbumSort()</summary>
		[PexMethod]
		public string AlbumSortGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.AlbumSort;
			return result;
			// TODO: add assertions to method AppleTagTest.AlbumSortGetTest(AppleTag)
		}

		/// <summary>Test stub for get_AmazonId()</summary>
		[PexMethod]
		public string AmazonIdGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.AmazonId;
			return result;
			// TODO: add assertions to method AppleTagTest.AmazonIdGetTest(AppleTag)
		}

		/// <summary>Test stub for get_BeatsPerMinute()</summary>
		[PexMethod]
		public uint BeatsPerMinuteGetTest([PexAssumeUnderTest]AppleTag target)
		{
			uint result = target.BeatsPerMinute;
			return result;
			// TODO: add assertions to method AppleTagTest.BeatsPerMinuteGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method AppleTagTest.CommentGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Composers()</summary>
		[PexMethod]
		public string[] ComposersGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string[] result = target.Composers;
			return result;
			// TODO: add assertions to method AppleTagTest.ComposersGetTest(AppleTag)
		}

		/// <summary>Test stub for get_ComposersSort()</summary>
		[PexMethod]
		public string[] ComposersSortGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string[] result = target.ComposersSort;
			return result;
			// TODO: add assertions to method AppleTagTest.ComposersSortGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Conductor()</summary>
		[PexMethod]
		public string ConductorGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.Conductor;
			return result;
			// TODO: add assertions to method AppleTagTest.ConductorGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method AppleTagTest.CopyrightGetTest(AppleTag)
		}

		/// <summary>Test stub for get_DateTagged()</summary>
		[PexMethod]
		public DateTime? DateTaggedGetTest([PexAssumeUnderTest]AppleTag target)
		{
			DateTime? result = target.DateTagged;
			return result;
			// TODO: add assertions to method AppleTagTest.DateTaggedGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method AppleTagTest.DescriptionGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Disc()</summary>
		[PexMethod]
		public uint DiscGetTest([PexAssumeUnderTest]AppleTag target)
		{
			uint result = target.Disc;
			return result;
			// TODO: add assertions to method AppleTagTest.DiscGetTest(AppleTag)
		}

		/// <summary>Test stub for get_DiscCount()</summary>
		[PexMethod]
		public uint DiscCountGetTest([PexAssumeUnderTest]AppleTag target)
		{
			uint result = target.DiscCount;
			return result;
			// TODO: add assertions to method AppleTagTest.DiscCountGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Genres()</summary>
		[PexMethod]
		public string[] GenresGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string[] result = target.Genres;
			return result;
			// TODO: add assertions to method AppleTagTest.GenresGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Grouping()</summary>
		[PexMethod]
		public string GroupingGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.Grouping;
			return result;
			// TODO: add assertions to method AppleTagTest.GroupingGetTest(AppleTag)
		}

		/// <summary>Test stub for get_IsCompilation()</summary>
		[PexMethod]
		public bool IsCompilationGetTest([PexAssumeUnderTest]AppleTag target)
		{
			bool result = target.IsCompilation;
			return result;
			// TODO: add assertions to method AppleTagTest.IsCompilationGetTest(AppleTag)
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest([PexAssumeUnderTest]AppleTag target)
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method AppleTagTest.IsEmptyGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Lyrics()</summary>
		[PexMethod]
		public string LyricsGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.Lyrics;
			return result;
			// TODO: add assertions to method AppleTagTest.LyricsGetTest(AppleTag)
		}

		/// <summary>Test stub for get_MusicBrainzArtistId()</summary>
		[PexMethod]
		public string MusicBrainzArtistIdGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.MusicBrainzArtistId;
			return result;
			// TODO: add assertions to method AppleTagTest.MusicBrainzArtistIdGetTest(AppleTag)
		}

		/// <summary>Test stub for get_MusicBrainzDiscId()</summary>
		[PexMethod]
		public string MusicBrainzDiscIdGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.MusicBrainzDiscId;
			return result;
			// TODO: add assertions to method AppleTagTest.MusicBrainzDiscIdGetTest(AppleTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseArtistId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseArtistIdGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.MusicBrainzReleaseArtistId;
			return result;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseArtistIdGetTest(AppleTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseCountry()</summary>
		[PexMethod]
		public string MusicBrainzReleaseCountryGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.MusicBrainzReleaseCountry;
			return result;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseCountryGetTest(AppleTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseId()</summary>
		[PexMethod]
		public string MusicBrainzReleaseIdGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.MusicBrainzReleaseId;
			return result;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseIdGetTest(AppleTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseStatus()</summary>
		[PexMethod]
		public string MusicBrainzReleaseStatusGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.MusicBrainzReleaseStatus;
			return result;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseStatusGetTest(AppleTag)
		}

		/// <summary>Test stub for get_MusicBrainzReleaseType()</summary>
		[PexMethod]
		public string MusicBrainzReleaseTypeGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.MusicBrainzReleaseType;
			return result;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseTypeGetTest(AppleTag)
		}

		/// <summary>Test stub for get_MusicBrainzTrackId()</summary>
		[PexMethod]
		public string MusicBrainzTrackIdGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.MusicBrainzTrackId;
			return result;
			// TODO: add assertions to method AppleTagTest.MusicBrainzTrackIdGetTest(AppleTag)
		}

		/// <summary>Test stub for get_MusicIpId()</summary>
		[PexMethod]
		public string MusicIpIdGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.MusicIpId;
			return result;
			// TODO: add assertions to method AppleTagTest.MusicIpIdGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Performers()</summary>
		[PexMethod]
		public string[] PerformersGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string[] result = target.Performers;
			return result;
			// TODO: add assertions to method AppleTagTest.PerformersGetTest(AppleTag)
		}

		/// <summary>Test stub for get_PerformersRole()</summary>
		[PexMethod]
		public string[] PerformersRoleGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string[] result = target.PerformersRole;
			return result;
			// TODO: add assertions to method AppleTagTest.PerformersRoleGetTest(AppleTag)
		}

		/// <summary>Test stub for get_PerformersSort()</summary>
		[PexMethod]
		public string[] PerformersSortGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string[] result = target.PerformersSort;
			return result;
			// TODO: add assertions to method AppleTagTest.PerformersSortGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Pictures()</summary>
		[PexMethod]
		public IPicture[] PicturesGetTest([PexAssumeUnderTest]AppleTag target)
		{
			IPicture[] result = target.Pictures;
			return result;
			// TODO: add assertions to method AppleTagTest.PicturesGetTest(AppleTag)
		}

		/// <summary>Test stub for get_ReplayGainAlbumGain()</summary>
		[PexMethod]
		public double ReplayGainAlbumGainGetTest([PexAssumeUnderTest]AppleTag target)
		{
			double result = target.ReplayGainAlbumGain;
			return result;
			// TODO: add assertions to method AppleTagTest.ReplayGainAlbumGainGetTest(AppleTag)
		}

		/// <summary>Test stub for get_ReplayGainAlbumPeak()</summary>
		[PexMethod]
		public double ReplayGainAlbumPeakGetTest([PexAssumeUnderTest]AppleTag target)
		{
			double result = target.ReplayGainAlbumPeak;
			return result;
			// TODO: add assertions to method AppleTagTest.ReplayGainAlbumPeakGetTest(AppleTag)
		}

		/// <summary>Test stub for get_ReplayGainTrackGain()</summary>
		[PexMethod]
		public double ReplayGainTrackGainGetTest([PexAssumeUnderTest]AppleTag target)
		{
			double result = target.ReplayGainTrackGain;
			return result;
			// TODO: add assertions to method AppleTagTest.ReplayGainTrackGainGetTest(AppleTag)
		}

		/// <summary>Test stub for get_ReplayGainTrackPeak()</summary>
		[PexMethod]
		public double ReplayGainTrackPeakGetTest([PexAssumeUnderTest]AppleTag target)
		{
			double result = target.ReplayGainTrackPeak;
			return result;
			// TODO: add assertions to method AppleTagTest.ReplayGainTrackPeakGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Subtitle()</summary>
		[PexMethod]
		public string SubtitleGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.Subtitle;
			return result;
			// TODO: add assertions to method AppleTagTest.SubtitleGetTest(AppleTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]AppleTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method AppleTagTest.TagTypesGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method AppleTagTest.TitleGetTest(AppleTag)
		}

		/// <summary>Test stub for get_TitleSort()</summary>
		[PexMethod]
		public string TitleSortGetTest([PexAssumeUnderTest]AppleTag target)
		{
			string result = target.TitleSort;
			return result;
			// TODO: add assertions to method AppleTagTest.TitleSortGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Track()</summary>
		[PexMethod]
		public uint TrackGetTest([PexAssumeUnderTest]AppleTag target)
		{
			uint result = target.Track;
			return result;
			// TODO: add assertions to method AppleTagTest.TrackGetTest(AppleTag)
		}

		/// <summary>Test stub for get_TrackCount()</summary>
		[PexMethod]
		public uint TrackCountGetTest([PexAssumeUnderTest]AppleTag target)
		{
			uint result = target.TrackCount;
			return result;
			// TODO: add assertions to method AppleTagTest.TrackCountGetTest(AppleTag)
		}

		/// <summary>Test stub for get_Year()</summary>
		[PexMethod]
		public uint YearGetTest([PexAssumeUnderTest]AppleTag target)
		{
			uint result = target.Year;
			return result;
			// TODO: add assertions to method AppleTagTest.YearGetTest(AppleTag)
		}

		/// <summary>Test stub for set_Album(String)</summary>
		[PexMethod]
		public void AlbumSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.Album = value;
			// TODO: add assertions to method AppleTagTest.AlbumSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_AlbumArtists(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSetTest([PexAssumeUnderTest]AppleTag target, string[] value)
		{
			target.AlbumArtists = value;
			// TODO: add assertions to method AppleTagTest.AlbumArtistsSetTest(AppleTag, String[])
		}

		/// <summary>Test stub for set_AlbumArtistsSort(String[])</summary>
		[PexMethod]
		public void AlbumArtistsSortSetTest([PexAssumeUnderTest]AppleTag target, string[] value)
		{
			target.AlbumArtistsSort = value;
			// TODO: add assertions to method AppleTagTest.AlbumArtistsSortSetTest(AppleTag, String[])
		}

		/// <summary>Test stub for set_AlbumSort(String)</summary>
		[PexMethod]
		public void AlbumSortSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.AlbumSort = value;
			// TODO: add assertions to method AppleTagTest.AlbumSortSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_AmazonId(String)</summary>
		[PexMethod]
		public void AmazonIdSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.AmazonId = value;
			// TODO: add assertions to method AppleTagTest.AmazonIdSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_BeatsPerMinute(UInt32)</summary>
		[PexMethod]
		public void BeatsPerMinuteSetTest([PexAssumeUnderTest]AppleTag target, uint value)
		{
			target.BeatsPerMinute = value;
			// TODO: add assertions to method AppleTagTest.BeatsPerMinuteSetTest(AppleTag, UInt32)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method AppleTagTest.CommentSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_Composers(String[])</summary>
		[PexMethod]
		public void ComposersSetTest([PexAssumeUnderTest]AppleTag target, string[] value)
		{
			target.Composers = value;
			// TODO: add assertions to method AppleTagTest.ComposersSetTest(AppleTag, String[])
		}

		/// <summary>Test stub for set_ComposersSort(String[])</summary>
		[PexMethod]
		public void ComposersSortSetTest([PexAssumeUnderTest]AppleTag target, string[] value)
		{
			target.ComposersSort = value;
			// TODO: add assertions to method AppleTagTest.ComposersSortSetTest(AppleTag, String[])
		}

		/// <summary>Test stub for set_Conductor(String)</summary>
		[PexMethod]
		public void ConductorSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.Conductor = value;
			// TODO: add assertions to method AppleTagTest.ConductorSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method AppleTagTest.CopyrightSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_DateTagged(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTaggedSetTest([PexAssumeUnderTest]AppleTag target, DateTime? value)
		{
			target.DateTagged = value;
			// TODO: add assertions to method AppleTagTest.DateTaggedSetTest(AppleTag, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method AppleTagTest.DescriptionSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_Disc(UInt32)</summary>
		[PexMethod]
		public void DiscSetTest([PexAssumeUnderTest]AppleTag target, uint value)
		{
			target.Disc = value;
			// TODO: add assertions to method AppleTagTest.DiscSetTest(AppleTag, UInt32)
		}

		/// <summary>Test stub for set_DiscCount(UInt32)</summary>
		[PexMethod]
		public void DiscCountSetTest([PexAssumeUnderTest]AppleTag target, uint value)
		{
			target.DiscCount = value;
			// TODO: add assertions to method AppleTagTest.DiscCountSetTest(AppleTag, UInt32)
		}

		/// <summary>Test stub for set_Genres(String[])</summary>
		[PexMethod]
		public void GenresSetTest([PexAssumeUnderTest]AppleTag target, string[] value)
		{
			target.Genres = value;
			// TODO: add assertions to method AppleTagTest.GenresSetTest(AppleTag, String[])
		}

		/// <summary>Test stub for set_Grouping(String)</summary>
		[PexMethod]
		public void GroupingSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.Grouping = value;
			// TODO: add assertions to method AppleTagTest.GroupingSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_IsCompilation(Boolean)</summary>
		[PexMethod]
		public void IsCompilationSetTest([PexAssumeUnderTest]AppleTag target, bool value)
		{
			target.IsCompilation = value;
			// TODO: add assertions to method AppleTagTest.IsCompilationSetTest(AppleTag, Boolean)
		}

		/// <summary>Test stub for set_Lyrics(String)</summary>
		[PexMethod]
		public void LyricsSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.Lyrics = value;
			// TODO: add assertions to method AppleTagTest.LyricsSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzArtistIdSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.MusicBrainzArtistId = value;
			// TODO: add assertions to method AppleTagTest.MusicBrainzArtistIdSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzDiscId(String)</summary>
		[PexMethod]
		public void MusicBrainzDiscIdSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.MusicBrainzDiscId = value;
			// TODO: add assertions to method AppleTagTest.MusicBrainzDiscIdSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseArtistId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseArtistIdSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.MusicBrainzReleaseArtistId = value;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseArtistIdSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseCountry(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseCountrySetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.MusicBrainzReleaseCountry = value;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseCountrySetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseId(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseIdSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.MusicBrainzReleaseId = value;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseIdSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseStatus(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseStatusSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.MusicBrainzReleaseStatus = value;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseStatusSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzReleaseType(String)</summary>
		[PexMethod]
		public void MusicBrainzReleaseTypeSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.MusicBrainzReleaseType = value;
			// TODO: add assertions to method AppleTagTest.MusicBrainzReleaseTypeSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_MusicBrainzTrackId(String)</summary>
		[PexMethod]
		public void MusicBrainzTrackIdSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.MusicBrainzTrackId = value;
			// TODO: add assertions to method AppleTagTest.MusicBrainzTrackIdSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_MusicIpId(String)</summary>
		[PexMethod]
		public void MusicIpIdSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.MusicIpId = value;
			// TODO: add assertions to method AppleTagTest.MusicIpIdSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_Performers(String[])</summary>
		[PexMethod]
		public void PerformersSetTest([PexAssumeUnderTest]AppleTag target, string[] value)
		{
			target.Performers = value;
			// TODO: add assertions to method AppleTagTest.PerformersSetTest(AppleTag, String[])
		}

		/// <summary>Test stub for set_PerformersRole(String[])</summary>
		[PexMethod]
		public void PerformersRoleSetTest([PexAssumeUnderTest]AppleTag target, string[] value)
		{
			target.PerformersRole = value;
			// TODO: add assertions to method AppleTagTest.PerformersRoleSetTest(AppleTag, String[])
		}

		/// <summary>Test stub for set_PerformersSort(String[])</summary>
		[PexMethod]
		public void PerformersSortSetTest([PexAssumeUnderTest]AppleTag target, string[] value)
		{
			target.PerformersSort = value;
			// TODO: add assertions to method AppleTagTest.PerformersSortSetTest(AppleTag, String[])
		}

		/// <summary>Test stub for set_Pictures(IPicture[])</summary>
		[PexMethod]
		public void PicturesSetTest([PexAssumeUnderTest]AppleTag target, IPicture[] value)
		{
			target.Pictures = value;
			// TODO: add assertions to method AppleTagTest.PicturesSetTest(AppleTag, IPicture[])
		}

		/// <summary>Test stub for set_ReplayGainAlbumGain(Double)</summary>
		[PexMethod]
		public void ReplayGainAlbumGainSetTest([PexAssumeUnderTest]AppleTag target, double value)
		{
			target.ReplayGainAlbumGain = value;
			// TODO: add assertions to method AppleTagTest.ReplayGainAlbumGainSetTest(AppleTag, Double)
		}

		/// <summary>Test stub for set_ReplayGainAlbumPeak(Double)</summary>
		[PexMethod]
		public void ReplayGainAlbumPeakSetTest([PexAssumeUnderTest]AppleTag target, double value)
		{
			target.ReplayGainAlbumPeak = value;
			// TODO: add assertions to method AppleTagTest.ReplayGainAlbumPeakSetTest(AppleTag, Double)
		}

		/// <summary>Test stub for set_ReplayGainTrackGain(Double)</summary>
		[PexMethod]
		public void ReplayGainTrackGainSetTest([PexAssumeUnderTest]AppleTag target, double value)
		{
			target.ReplayGainTrackGain = value;
			// TODO: add assertions to method AppleTagTest.ReplayGainTrackGainSetTest(AppleTag, Double)
		}

		/// <summary>Test stub for set_ReplayGainTrackPeak(Double)</summary>
		[PexMethod]
		public void ReplayGainTrackPeakSetTest([PexAssumeUnderTest]AppleTag target, double value)
		{
			target.ReplayGainTrackPeak = value;
			// TODO: add assertions to method AppleTagTest.ReplayGainTrackPeakSetTest(AppleTag, Double)
		}

		/// <summary>Test stub for set_Subtitle(String)</summary>
		[PexMethod]
		public void SubtitleSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.Subtitle = value;
			// TODO: add assertions to method AppleTagTest.SubtitleSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method AppleTagTest.TitleSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_TitleSort(String)</summary>
		[PexMethod]
		public void TitleSortSetTest([PexAssumeUnderTest]AppleTag target, string value)
		{
			target.TitleSort = value;
			// TODO: add assertions to method AppleTagTest.TitleSortSetTest(AppleTag, String)
		}

		/// <summary>Test stub for set_Track(UInt32)</summary>
		[PexMethod]
		public void TrackSetTest([PexAssumeUnderTest]AppleTag target, uint value)
		{
			target.Track = value;
			// TODO: add assertions to method AppleTagTest.TrackSetTest(AppleTag, UInt32)
		}

		/// <summary>Test stub for set_TrackCount(UInt32)</summary>
		[PexMethod]
		public void TrackCountSetTest([PexAssumeUnderTest]AppleTag target, uint value)
		{
			target.TrackCount = value;
			// TODO: add assertions to method AppleTagTest.TrackCountSetTest(AppleTag, UInt32)
		}

		/// <summary>Test stub for set_Year(UInt32)</summary>
		[PexMethod]
		public void YearSetTest([PexAssumeUnderTest]AppleTag target, uint value)
		{
			target.Year = value;
			// TODO: add assertions to method AppleTagTest.YearSetTest(AppleTag, UInt32)
		}
	}
}
