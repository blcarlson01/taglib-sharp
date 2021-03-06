using TagLib;
using TagLib.Image;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;

namespace TagLib.IFD.Tests
{
    /// <summary>This class contains parameterized unit tests for IFDTag</summary>
    [TestClass]
    [PexClass(typeof(IFDTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IFDTagTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public IFDTag ConstructorTest()
		{
			IFDTag target = new IFDTag();
			return target;
			// TODO: add assertions to method IFDTagTest.ConstructorTest()
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]IFDTag target)
		{
			target.Clear();
			// TODO: add assertions to method IFDTagTest.ClearTest(IFDTag)
		}

		/// <summary>Test stub for get_Altitude()</summary>
		[PexMethod]
		public double? AltitudeGetTest([PexAssumeUnderTest]IFDTag target)
		{
			double? result = target.Altitude;
			return result;
			// TODO: add assertions to method IFDTagTest.AltitudeGetTest(IFDTag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]IFDTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method IFDTagTest.CommentGetTest(IFDTag)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]IFDTag target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method IFDTagTest.CopyrightGetTest(IFDTag)
		}

		/// <summary>Test stub for get_Creator()</summary>
		[PexMethod]
		public string CreatorGetTest([PexAssumeUnderTest]IFDTag target)
		{
			string result = target.Creator;
			return result;
			// TODO: add assertions to method IFDTagTest.CreatorGetTest(IFDTag)
		}

		/// <summary>Test stub for get_DateTime()</summary>
		[PexMethod]
		public DateTime? DateTimeGetTest([PexAssumeUnderTest]IFDTag target)
		{
			DateTime? result = target.DateTime;
			return result;
			// TODO: add assertions to method IFDTagTest.DateTimeGetTest(IFDTag)
		}

		/// <summary>Test stub for get_DateTimeDigitized()</summary>
		[PexMethod]
		public DateTime? DateTimeDigitizedGetTest([PexAssumeUnderTest]IFDTag target)
		{
			DateTime? result = target.DateTimeDigitized;
			return result;
			// TODO: add assertions to method IFDTagTest.DateTimeDigitizedGetTest(IFDTag)
		}

		/// <summary>Test stub for get_DateTimeOriginal()</summary>
		[PexMethod]
		public DateTime? DateTimeOriginalGetTest([PexAssumeUnderTest]IFDTag target)
		{
			DateTime? result = target.DateTimeOriginal;
			return result;
			// TODO: add assertions to method IFDTagTest.DateTimeOriginalGetTest(IFDTag)
		}

		/// <summary>Test stub for get_ExifIFD()</summary>
		[PexMethod]
		public IFDStructure ExifIFDGetTest([PexAssumeUnderTest]IFDTag target)
		{
			IFDStructure result = target.ExifIFD;
			return result;
			// TODO: add assertions to method IFDTagTest.ExifIFDGetTest(IFDTag)
		}

		/// <summary>Test stub for get_ExposureTime()</summary>
		[PexMethod]
		public double? ExposureTimeGetTest([PexAssumeUnderTest]IFDTag target)
		{
			double? result = target.ExposureTime;
			return result;
			// TODO: add assertions to method IFDTagTest.ExposureTimeGetTest(IFDTag)
		}

		/// <summary>Test stub for get_FNumber()</summary>
		[PexMethod]
		public double? FNumberGetTest([PexAssumeUnderTest]IFDTag target)
		{
			double? result = target.FNumber;
			return result;
			// TODO: add assertions to method IFDTagTest.FNumberGetTest(IFDTag)
		}

		/// <summary>Test stub for get_FocalLength()</summary>
		[PexMethod]
		public double? FocalLengthGetTest([PexAssumeUnderTest]IFDTag target)
		{
			double? result = target.FocalLength;
			return result;
			// TODO: add assertions to method IFDTagTest.FocalLengthGetTest(IFDTag)
		}

		/// <summary>Test stub for get_FocalLengthIn35mmFilm()</summary>
		[PexMethod]
		public uint? FocalLengthIn35mmFilmGetTest([PexAssumeUnderTest]IFDTag target)
		{
			uint? result = target.FocalLengthIn35mmFilm;
			return result;
			// TODO: add assertions to method IFDTagTest.FocalLengthIn35mmFilmGetTest(IFDTag)
		}

		/// <summary>Test stub for get_GPSIFD()</summary>
		[PexMethod]
		public IFDStructure GPSIFDGetTest([PexAssumeUnderTest]IFDTag target)
		{
			IFDStructure result = target.GPSIFD;
			return result;
			// TODO: add assertions to method IFDTagTest.GPSIFDGetTest(IFDTag)
		}

		/// <summary>Test stub for get_ISOSpeedRatings()</summary>
		[PexMethod]
		public uint? ISOSpeedRatingsGetTest([PexAssumeUnderTest]IFDTag target)
		{
			uint? result = target.ISOSpeedRatings;
			return result;
			// TODO: add assertions to method IFDTagTest.ISOSpeedRatingsGetTest(IFDTag)
		}

		/// <summary>Test stub for get_Latitude()</summary>
		[PexMethod]
		public double? LatitudeGetTest([PexAssumeUnderTest]IFDTag target)
		{
			double? result = target.Latitude;
			return result;
			// TODO: add assertions to method IFDTagTest.LatitudeGetTest(IFDTag)
		}

		/// <summary>Test stub for get_Longitude()</summary>
		[PexMethod]
		public double? LongitudeGetTest([PexAssumeUnderTest]IFDTag target)
		{
			double? result = target.Longitude;
			return result;
			// TODO: add assertions to method IFDTagTest.LongitudeGetTest(IFDTag)
		}

		/// <summary>Test stub for get_Make()</summary>
		[PexMethod]
		public string MakeGetTest([PexAssumeUnderTest]IFDTag target)
		{
			string result = target.Make;
			return result;
			// TODO: add assertions to method IFDTagTest.MakeGetTest(IFDTag)
		}

		/// <summary>Test stub for get_Model()</summary>
		[PexMethod]
		public string ModelGetTest([PexAssumeUnderTest]IFDTag target)
		{
			string result = target.Model;
			return result;
			// TODO: add assertions to method IFDTagTest.ModelGetTest(IFDTag)
		}

		/// <summary>Test stub for get_Orientation()</summary>
		[PexMethod]
		public ImageOrientation OrientationGetTest([PexAssumeUnderTest]IFDTag target)
		{
			ImageOrientation result = target.Orientation;
			return result;
			// TODO: add assertions to method IFDTagTest.OrientationGetTest(IFDTag)
		}

		/// <summary>Test stub for get_Software()</summary>
		[PexMethod]
		public string SoftwareGetTest([PexAssumeUnderTest]IFDTag target)
		{
			string result = target.Software;
			return result;
			// TODO: add assertions to method IFDTagTest.SoftwareGetTest(IFDTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]IFDTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method IFDTagTest.TagTypesGetTest(IFDTag)
		}

		/// <summary>Test stub for set_Altitude(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void AltitudeSetTest([PexAssumeUnderTest]IFDTag target, double? value)
		{
			target.Altitude = value;
			// TODO: add assertions to method IFDTagTest.AltitudeSetTest(IFDTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]IFDTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method IFDTagTest.CommentSetTest(IFDTag, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]IFDTag target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method IFDTagTest.CopyrightSetTest(IFDTag, String)
		}

		/// <summary>Test stub for set_Creator(String)</summary>
		[PexMethod]
		public void CreatorSetTest([PexAssumeUnderTest]IFDTag target, string value)
		{
			target.Creator = value;
			// TODO: add assertions to method IFDTagTest.CreatorSetTest(IFDTag, String)
		}

		/// <summary>Test stub for set_DateTime(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTimeSetTest([PexAssumeUnderTest]IFDTag target, DateTime? value)
		{
			target.DateTime = value;
			// TODO: add assertions to method IFDTagTest.DateTimeSetTest(IFDTag, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_DateTimeDigitized(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTimeDigitizedSetTest([PexAssumeUnderTest]IFDTag target, DateTime? value)
		{
			target.DateTimeDigitized = value;
			// TODO: add assertions to method IFDTagTest.DateTimeDigitizedSetTest(IFDTag, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_DateTimeOriginal(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTimeOriginalSetTest([PexAssumeUnderTest]IFDTag target, DateTime? value)
		{
			target.DateTimeOriginal = value;
			// TODO: add assertions to method IFDTagTest.DateTimeOriginalSetTest(IFDTag, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_ExposureTime(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void ExposureTimeSetTest([PexAssumeUnderTest]IFDTag target, double? value)
		{
			target.ExposureTime = value;
			// TODO: add assertions to method IFDTagTest.ExposureTimeSetTest(IFDTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_FNumber(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void FNumberSetTest([PexAssumeUnderTest]IFDTag target, double? value)
		{
			target.FNumber = value;
			// TODO: add assertions to method IFDTagTest.FNumberSetTest(IFDTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_FocalLength(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void FocalLengthSetTest([PexAssumeUnderTest]IFDTag target, double? value)
		{
			target.FocalLength = value;
			// TODO: add assertions to method IFDTagTest.FocalLengthSetTest(IFDTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_FocalLengthIn35mmFilm(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void FocalLengthIn35mmFilmSetTest([PexAssumeUnderTest]IFDTag target, uint? value)
		{
			target.FocalLengthIn35mmFilm = value;
			// TODO: add assertions to method IFDTagTest.FocalLengthIn35mmFilmSetTest(IFDTag, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for set_ISOSpeedRatings(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void ISOSpeedRatingsSetTest([PexAssumeUnderTest]IFDTag target, uint? value)
		{
			target.ISOSpeedRatings = value;
			// TODO: add assertions to method IFDTagTest.ISOSpeedRatingsSetTest(IFDTag, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for set_Latitude(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void LatitudeSetTest([PexAssumeUnderTest]IFDTag target, double? value)
		{
			target.Latitude = value;
			// TODO: add assertions to method IFDTagTest.LatitudeSetTest(IFDTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_Longitude(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void LongitudeSetTest([PexAssumeUnderTest]IFDTag target, double? value)
		{
			target.Longitude = value;
			// TODO: add assertions to method IFDTagTest.LongitudeSetTest(IFDTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_Make(String)</summary>
		[PexMethod]
		public void MakeSetTest([PexAssumeUnderTest]IFDTag target, string value)
		{
			target.Make = value;
			// TODO: add assertions to method IFDTagTest.MakeSetTest(IFDTag, String)
		}

		/// <summary>Test stub for set_Model(String)</summary>
		[PexMethod]
		public void ModelSetTest([PexAssumeUnderTest]IFDTag target, string value)
		{
			target.Model = value;
			// TODO: add assertions to method IFDTagTest.ModelSetTest(IFDTag, String)
		}

		/// <summary>Test stub for set_Orientation(ImageOrientation)</summary>
		[PexMethod]
		public void OrientationSetTest([PexAssumeUnderTest]IFDTag target, ImageOrientation value)
		{
			target.Orientation = value;
			// TODO: add assertions to method IFDTagTest.OrientationSetTest(IFDTag, ImageOrientation)
		}

		/// <summary>Test stub for set_Software(String)</summary>
		[PexMethod]
		public void SoftwareSetTest([PexAssumeUnderTest]IFDTag target, string value)
		{
			target.Software = value;
			// TODO: add assertions to method IFDTagTest.SoftwareSetTest(IFDTag, String)
		}
	}
}
