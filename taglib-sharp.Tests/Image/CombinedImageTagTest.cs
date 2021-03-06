using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Image;

namespace TagLib.Image.Tests
{
    /// <summary>This class contains parameterized unit tests for CombinedImageTag</summary>
    [TestClass]
    [PexClass(typeof(CombinedImageTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CombinedImageTagTest
    {

		/// <summary>Test stub for .ctor(TagTypes)</summary>
		[PexMethod]
		public CombinedImageTag ConstructorTest(TagTypes allowed_types)
		{
			CombinedImageTag target = new CombinedImageTag(allowed_types);
			return target;
			// TODO: add assertions to method CombinedImageTagTest.ConstructorTest(TagTypes)
		}

	

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			target.Clear();
			// TODO: add assertions to method CombinedImageTagTest.ClearTest(CombinedImageTag)
		}

	

		/// <summary>Test stub for get_AllTags()</summary>
		[PexMethod]
		public List<ImageTag> AllTagsGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			List<ImageTag> result = target.AllTags;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.AllTagsGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Altitude()</summary>
		[PexMethod]
		public double? AltitudeGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			double? result = target.Altitude;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.AltitudeGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.CommentGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.CopyrightGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Creator()</summary>
		[PexMethod]
		public string CreatorGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			string result = target.Creator;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.CreatorGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_DateTime()</summary>
		[PexMethod]
		public DateTime? DateTimeGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			DateTime? result = target.DateTime;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.DateTimeGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_ExposureTime()</summary>
		[PexMethod]
		public double? ExposureTimeGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			double? result = target.ExposureTime;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.ExposureTimeGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_FNumber()</summary>
		[PexMethod]
		public double? FNumberGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			double? result = target.FNumber;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.FNumberGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_FocalLength()</summary>
		[PexMethod]
		public double? FocalLengthGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			double? result = target.FocalLength;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.FocalLengthGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_FocalLengthIn35mmFilm()</summary>
		[PexMethod]
		public uint? FocalLengthIn35mmFilmGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			uint? result = target.FocalLengthIn35mmFilm;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.FocalLengthIn35mmFilmGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_ISOSpeedRatings()</summary>
		[PexMethod]
		public uint? ISOSpeedRatingsGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			uint? result = target.ISOSpeedRatings;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.ISOSpeedRatingsGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Keywords()</summary>
		[PexMethod]
		public string[] KeywordsGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			string[] result = target.Keywords;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.KeywordsGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Latitude()</summary>
		[PexMethod]
		public double? LatitudeGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			double? result = target.Latitude;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.LatitudeGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Longitude()</summary>
		[PexMethod]
		public double? LongitudeGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			double? result = target.Longitude;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.LongitudeGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Make()</summary>
		[PexMethod]
		public string MakeGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			string result = target.Make;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.MakeGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Model()</summary>
		[PexMethod]
		public string ModelGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			string result = target.Model;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.ModelGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Orientation()</summary>
		[PexMethod]
		public ImageOrientation OrientationGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			ImageOrientation result = target.Orientation;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.OrientationGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Rating()</summary>
		[PexMethod]
		public uint? RatingGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			uint? result = target.Rating;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.RatingGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Software()</summary>
		[PexMethod]
		public string SoftwareGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			string result = target.Software;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.SoftwareGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.TagTypesGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]CombinedImageTag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method CombinedImageTagTest.TitleGetTest(CombinedImageTag)
		}

		/// <summary>Test stub for set_Altitude(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void AltitudeSetTest([PexAssumeUnderTest]CombinedImageTag target, double? value)
		{
			target.Altitude = value;
			// TODO: add assertions to method CombinedImageTagTest.AltitudeSetTest(CombinedImageTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]CombinedImageTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method CombinedImageTagTest.CommentSetTest(CombinedImageTag, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]CombinedImageTag target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method CombinedImageTagTest.CopyrightSetTest(CombinedImageTag, String)
		}

		/// <summary>Test stub for set_Creator(String)</summary>
		[PexMethod]
		public void CreatorSetTest([PexAssumeUnderTest]CombinedImageTag target, string value)
		{
			target.Creator = value;
			// TODO: add assertions to method CombinedImageTagTest.CreatorSetTest(CombinedImageTag, String)
		}

		/// <summary>Test stub for set_DateTime(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTimeSetTest([PexAssumeUnderTest]CombinedImageTag target, DateTime? value)
		{
			target.DateTime = value;
			// TODO: add assertions to method CombinedImageTagTest.DateTimeSetTest(CombinedImageTag, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_ExposureTime(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void ExposureTimeSetTest([PexAssumeUnderTest]CombinedImageTag target, double? value)
		{
			target.ExposureTime = value;
			// TODO: add assertions to method CombinedImageTagTest.ExposureTimeSetTest(CombinedImageTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_FNumber(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void FNumberSetTest([PexAssumeUnderTest]CombinedImageTag target, double? value)
		{
			target.FNumber = value;
			// TODO: add assertions to method CombinedImageTagTest.FNumberSetTest(CombinedImageTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_FocalLength(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void FocalLengthSetTest([PexAssumeUnderTest]CombinedImageTag target, double? value)
		{
			target.FocalLength = value;
			// TODO: add assertions to method CombinedImageTagTest.FocalLengthSetTest(CombinedImageTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_FocalLengthIn35mmFilm(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void FocalLengthIn35mmFilmSetTest([PexAssumeUnderTest]CombinedImageTag target, uint? value)
		{
			target.FocalLengthIn35mmFilm = value;
			// TODO: add assertions to method CombinedImageTagTest.FocalLengthIn35mmFilmSetTest(CombinedImageTag, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for set_ISOSpeedRatings(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void ISOSpeedRatingsSetTest([PexAssumeUnderTest]CombinedImageTag target, uint? value)
		{
			target.ISOSpeedRatings = value;
			// TODO: add assertions to method CombinedImageTagTest.ISOSpeedRatingsSetTest(CombinedImageTag, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for set_Keywords(String[])</summary>
		[PexMethod]
		public void KeywordsSetTest([PexAssumeUnderTest]CombinedImageTag target, string[] value)
		{
			target.Keywords = value;
			// TODO: add assertions to method CombinedImageTagTest.KeywordsSetTest(CombinedImageTag, String[])
		}

		/// <summary>Test stub for set_Latitude(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void LatitudeSetTest([PexAssumeUnderTest]CombinedImageTag target, double? value)
		{
			target.Latitude = value;
			// TODO: add assertions to method CombinedImageTagTest.LatitudeSetTest(CombinedImageTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_Longitude(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void LongitudeSetTest([PexAssumeUnderTest]CombinedImageTag target, double? value)
		{
			target.Longitude = value;
			// TODO: add assertions to method CombinedImageTagTest.LongitudeSetTest(CombinedImageTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_Make(String)</summary>
		[PexMethod]
		public void MakeSetTest([PexAssumeUnderTest]CombinedImageTag target, string value)
		{
			target.Make = value;
			// TODO: add assertions to method CombinedImageTagTest.MakeSetTest(CombinedImageTag, String)
		}

		/// <summary>Test stub for set_Model(String)</summary>
		[PexMethod]
		public void ModelSetTest([PexAssumeUnderTest]CombinedImageTag target, string value)
		{
			target.Model = value;
			// TODO: add assertions to method CombinedImageTagTest.ModelSetTest(CombinedImageTag, String)
		}

		/// <summary>Test stub for set_Orientation(ImageOrientation)</summary>
		[PexMethod]
		public void OrientationSetTest([PexAssumeUnderTest]CombinedImageTag target, ImageOrientation value)
		{
			target.Orientation = value;
			// TODO: add assertions to method CombinedImageTagTest.OrientationSetTest(CombinedImageTag, ImageOrientation)
		}

		/// <summary>Test stub for set_Rating(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void RatingSetTest([PexAssumeUnderTest]CombinedImageTag target, uint? value)
		{
			target.Rating = value;
			// TODO: add assertions to method CombinedImageTagTest.RatingSetTest(CombinedImageTag, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for set_Software(String)</summary>
		[PexMethod]
		public void SoftwareSetTest([PexAssumeUnderTest]CombinedImageTag target, string value)
		{
			target.Software = value;
			// TODO: add assertions to method CombinedImageTagTest.SoftwareSetTest(CombinedImageTag, String)
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]CombinedImageTag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method CombinedImageTagTest.TitleSetTest(CombinedImageTag, String)
		}
	}
}
