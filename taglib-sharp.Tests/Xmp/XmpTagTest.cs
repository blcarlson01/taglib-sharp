using TagLib.Image;
using System.Xml;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Xmp;

namespace TagLib.Xmp.Tests
{
    /// <summary>This class contains parameterized unit tests for XmpTag</summary>
    [TestClass]
    [PexClass(typeof(XmpTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class XmpTagTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public XmpTag ConstructorTest()
		{
			XmpTag target = new XmpTag();
			return target;
			// TODO: add assertions to method XmpTagTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(String, File)</summary>
		[PexMethod]
		public XmpTag ConstructorTest01(string data, File file)
		{
			XmpTag target = new XmpTag(data, file);
			return target;
			// TODO: add assertions to method XmpTagTest.ConstructorTest01(String, File)
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]XmpTag target)
		{
			target.Clear();
			// TODO: add assertions to method XmpTagTest.ClearTest(XmpTag)
		}

		

		/// <summary>Test stub for FindNode(String, String)</summary>
		[PexMethod]
		public XmpNode FindNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name
		)
		{
			XmpNode result = target.FindNode(ns, name);
			return result;
			// TODO: add assertions to method XmpTagTest.FindNodeTest(XmpTag, String, String)
		}

		/// <summary>Test stub for GetCollectionNode(String, String)</summary>
		[PexMethod]
		public string[] GetCollectionNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name
		)
		{
			string[] result = target.GetCollectionNode(ns, name);
			return result;
			// TODO: add assertions to method XmpTagTest.GetCollectionNodeTest(XmpTag, String, String)
		}

		/// <summary>Test stub for GetLangAltNode(String, String)</summary>
		[PexMethod]
		public string GetLangAltNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name
		)
		{
			string result = target.GetLangAltNode(ns, name);
			return result;
			// TODO: add assertions to method XmpTagTest.GetLangAltNodeTest(XmpTag, String, String)
		}

		/// <summary>Test stub for GetRationalNode(String, String)</summary>
		[PexMethod]
		public double? GetRationalNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name
		)
		{
			double? result = target.GetRationalNode(ns, name);
			return result;
			// TODO: add assertions to method XmpTagTest.GetRationalNodeTest(XmpTag, String, String)
		}

		/// <summary>Test stub for GetTextNode(String, String)</summary>
		[PexMethod]
		public string GetTextNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name
		)
		{
			string result = target.GetTextNode(ns, name);
			return result;
			// TODO: add assertions to method XmpTagTest.GetTextNodeTest(XmpTag, String, String)
		}

		/// <summary>Test stub for GetUIntNode(String, String)</summary>
		[PexMethod]
		public uint? GetUIntNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name
		)
		{
			uint? result = target.GetUIntNode(ns, name);
			return result;
			// TODO: add assertions to method XmpTagTest.GetUIntNodeTest(XmpTag, String, String)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public string RenderTest([PexAssumeUnderTest]XmpTag target)
		{
			string result = target.Render();
			return result;
			// TODO: add assertions to method XmpTagTest.RenderTest(XmpTag)
		}

		/// <summary>Test stub for ReplaceFrom(XmpTag)</summary>
		[PexMethod]
		public void ReplaceFromTest([PexAssumeUnderTest]XmpTag target, XmpTag tag)
		{
			target.ReplaceFrom(tag);
			// TODO: add assertions to method XmpTagTest.ReplaceFromTest(XmpTag, XmpTag)
		}

		/// <summary>Test stub for SetCollectionNode(String, String, String[], XmpNodeType)</summary>
		[PexMethod]
		public void SetCollectionNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name,
			string[] values,
			XmpNodeType type
		)
		{
			target.SetCollectionNode(ns, name, values, type);
			// TODO: add assertions to method XmpTagTest.SetCollectionNodeTest(XmpTag, String, String, String[], XmpNodeType)
		}

		/// <summary>Test stub for SetLangAltNode(String, String, String)</summary>
		[PexMethod]
		public void SetLangAltNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name,
			string value
		)
		{
			target.SetLangAltNode(ns, name, value);
			// TODO: add assertions to method XmpTagTest.SetLangAltNodeTest(XmpTag, String, String, String)
		}

		/// <summary>Test stub for SetRationalNode(String, String, Double)</summary>
		[PexMethod]
		public void SetRationalNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name,
			double value
		)
		{
			target.SetRationalNode(ns, name, value);
			// TODO: add assertions to method XmpTagTest.SetRationalNodeTest(XmpTag, String, String, Double)
		}

		/// <summary>Test stub for SetTextNode(String, String, String)</summary>
		[PexMethod]
		public void SetTextNodeTest(
			[PexAssumeUnderTest]XmpTag target,
			string ns,
			string name,
			string value
		)
		{
			target.SetTextNode(ns, name, value);
			// TODO: add assertions to method XmpTagTest.SetTextNodeTest(XmpTag, String, String, String)
		}

		/// <summary>Test stub for get_Altitude()</summary>
		[PexMethod]
		public double? AltitudeGetTest([PexAssumeUnderTest]XmpTag target)
		{
			double? result = target.Altitude;
			return result;
			// TODO: add assertions to method XmpTagTest.AltitudeGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]XmpTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method XmpTagTest.CommentGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]XmpTag target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method XmpTagTest.CopyrightGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Creator()</summary>
		[PexMethod]
		public string CreatorGetTest([PexAssumeUnderTest]XmpTag target)
		{
			string result = target.Creator;
			return result;
			// TODO: add assertions to method XmpTagTest.CreatorGetTest(XmpTag)
		}

		/// <summary>Test stub for get_DateTime()</summary>
		[PexMethod]
		public DateTime? DateTimeGetTest([PexAssumeUnderTest]XmpTag target)
		{
			DateTime? result = target.DateTime;
			return result;
			// TODO: add assertions to method XmpTagTest.DateTimeGetTest(XmpTag)
		}

		/// <summary>Test stub for get_ExposureTime()</summary>
		[PexMethod]
		public double? ExposureTimeGetTest([PexAssumeUnderTest]XmpTag target)
		{
			double? result = target.ExposureTime;
			return result;
			// TODO: add assertions to method XmpTagTest.ExposureTimeGetTest(XmpTag)
		}

		/// <summary>Test stub for get_FNumber()</summary>
		[PexMethod]
		public double? FNumberGetTest([PexAssumeUnderTest]XmpTag target)
		{
			double? result = target.FNumber;
			return result;
			// TODO: add assertions to method XmpTagTest.FNumberGetTest(XmpTag)
		}

		/// <summary>Test stub for get_FocalLength()</summary>
		[PexMethod]
		public double? FocalLengthGetTest([PexAssumeUnderTest]XmpTag target)
		{
			double? result = target.FocalLength;
			return result;
			// TODO: add assertions to method XmpTagTest.FocalLengthGetTest(XmpTag)
		}

		/// <summary>Test stub for get_FocalLengthIn35mmFilm()</summary>
		[PexMethod]
		public uint? FocalLengthIn35mmFilmGetTest([PexAssumeUnderTest]XmpTag target)
		{
			uint? result = target.FocalLengthIn35mmFilm;
			return result;
			// TODO: add assertions to method XmpTagTest.FocalLengthIn35mmFilmGetTest(XmpTag)
		}

		/// <summary>Test stub for get_ISOSpeedRatings()</summary>
		[PexMethod]
		public uint? ISOSpeedRatingsGetTest([PexAssumeUnderTest]XmpTag target)
		{
			uint? result = target.ISOSpeedRatings;
			return result;
			// TODO: add assertions to method XmpTagTest.ISOSpeedRatingsGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Keywords()</summary>
		[PexMethod]
		public string[] KeywordsGetTest([PexAssumeUnderTest]XmpTag target)
		{
			string[] result = target.Keywords;
			return result;
			// TODO: add assertions to method XmpTagTest.KeywordsGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Latitude()</summary>
		[PexMethod]
		public double? LatitudeGetTest([PexAssumeUnderTest]XmpTag target)
		{
			double? result = target.Latitude;
			return result;
			// TODO: add assertions to method XmpTagTest.LatitudeGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Longitude()</summary>
		[PexMethod]
		public double? LongitudeGetTest([PexAssumeUnderTest]XmpTag target)
		{
			double? result = target.Longitude;
			return result;
			// TODO: add assertions to method XmpTagTest.LongitudeGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Make()</summary>
		[PexMethod]
		public string MakeGetTest([PexAssumeUnderTest]XmpTag target)
		{
			string result = target.Make;
			return result;
			// TODO: add assertions to method XmpTagTest.MakeGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Model()</summary>
		[PexMethod]
		public string ModelGetTest([PexAssumeUnderTest]XmpTag target)
		{
			string result = target.Model;
			return result;
			// TODO: add assertions to method XmpTagTest.ModelGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Orientation()</summary>
		[PexMethod]
		public ImageOrientation OrientationGetTest([PexAssumeUnderTest]XmpTag target)
		{
			ImageOrientation result = target.Orientation;
			return result;
			// TODO: add assertions to method XmpTagTest.OrientationGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Rating()</summary>
		[PexMethod]
		public uint? RatingGetTest([PexAssumeUnderTest]XmpTag target)
		{
			uint? result = target.Rating;
			return result;
			// TODO: add assertions to method XmpTagTest.RatingGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Software()</summary>
		[PexMethod]
		public string SoftwareGetTest([PexAssumeUnderTest]XmpTag target)
		{
			string result = target.Software;
			return result;
			// TODO: add assertions to method XmpTagTest.SoftwareGetTest(XmpTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]XmpTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method XmpTagTest.TagTypesGetTest(XmpTag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]XmpTag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method XmpTagTest.TitleGetTest(XmpTag)
		}

		/// <summary>Test stub for set_Altitude(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void AltitudeSetTest([PexAssumeUnderTest]XmpTag target, double? value)
		{
			target.Altitude = value;
			// TODO: add assertions to method XmpTagTest.AltitudeSetTest(XmpTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]XmpTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method XmpTagTest.CommentSetTest(XmpTag, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]XmpTag target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method XmpTagTest.CopyrightSetTest(XmpTag, String)
		}

		/// <summary>Test stub for set_Creator(String)</summary>
		[PexMethod]
		public void CreatorSetTest([PexAssumeUnderTest]XmpTag target, string value)
		{
			target.Creator = value;
			// TODO: add assertions to method XmpTagTest.CreatorSetTest(XmpTag, String)
		}

		/// <summary>Test stub for set_DateTime(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTimeSetTest([PexAssumeUnderTest]XmpTag target, DateTime? value)
		{
			target.DateTime = value;
			// TODO: add assertions to method XmpTagTest.DateTimeSetTest(XmpTag, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_ExposureTime(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void ExposureTimeSetTest([PexAssumeUnderTest]XmpTag target, double? value)
		{
			target.ExposureTime = value;
			// TODO: add assertions to method XmpTagTest.ExposureTimeSetTest(XmpTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_FNumber(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void FNumberSetTest([PexAssumeUnderTest]XmpTag target, double? value)
		{
			target.FNumber = value;
			// TODO: add assertions to method XmpTagTest.FNumberSetTest(XmpTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_FocalLength(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void FocalLengthSetTest([PexAssumeUnderTest]XmpTag target, double? value)
		{
			target.FocalLength = value;
			// TODO: add assertions to method XmpTagTest.FocalLengthSetTest(XmpTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_FocalLengthIn35mmFilm(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void FocalLengthIn35mmFilmSetTest([PexAssumeUnderTest]XmpTag target, uint? value)
		{
			target.FocalLengthIn35mmFilm = value;
			// TODO: add assertions to method XmpTagTest.FocalLengthIn35mmFilmSetTest(XmpTag, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for set_ISOSpeedRatings(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void ISOSpeedRatingsSetTest([PexAssumeUnderTest]XmpTag target, uint? value)
		{
			target.ISOSpeedRatings = value;
			// TODO: add assertions to method XmpTagTest.ISOSpeedRatingsSetTest(XmpTag, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for set_Keywords(String[])</summary>
		[PexMethod]
		public void KeywordsSetTest([PexAssumeUnderTest]XmpTag target, string[] value)
		{
			target.Keywords = value;
			// TODO: add assertions to method XmpTagTest.KeywordsSetTest(XmpTag, String[])
		}

		/// <summary>Test stub for set_Latitude(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void LatitudeSetTest([PexAssumeUnderTest]XmpTag target, double? value)
		{
			target.Latitude = value;
			// TODO: add assertions to method XmpTagTest.LatitudeSetTest(XmpTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_Longitude(Nullable`1&lt;Double&gt;)</summary>
		[PexMethod]
		public void LongitudeSetTest([PexAssumeUnderTest]XmpTag target, double? value)
		{
			target.Longitude = value;
			// TODO: add assertions to method XmpTagTest.LongitudeSetTest(XmpTag, Nullable`1<Double>)
		}

		/// <summary>Test stub for set_Make(String)</summary>
		[PexMethod]
		public void MakeSetTest([PexAssumeUnderTest]XmpTag target, string value)
		{
			target.Make = value;
			// TODO: add assertions to method XmpTagTest.MakeSetTest(XmpTag, String)
		}

		/// <summary>Test stub for set_Model(String)</summary>
		[PexMethod]
		public void ModelSetTest([PexAssumeUnderTest]XmpTag target, string value)
		{
			target.Model = value;
			// TODO: add assertions to method XmpTagTest.ModelSetTest(XmpTag, String)
		}

		/// <summary>Test stub for set_Orientation(ImageOrientation)</summary>
		[PexMethod]
		public void OrientationSetTest([PexAssumeUnderTest]XmpTag target, ImageOrientation value)
		{
			target.Orientation = value;
			// TODO: add assertions to method XmpTagTest.OrientationSetTest(XmpTag, ImageOrientation)
		}

		/// <summary>Test stub for set_Rating(Nullable`1&lt;UInt32&gt;)</summary>
		[PexMethod]
		public void RatingSetTest([PexAssumeUnderTest]XmpTag target, uint? value)
		{
			target.Rating = value;
			// TODO: add assertions to method XmpTagTest.RatingSetTest(XmpTag, Nullable`1<UInt32>)
		}

		/// <summary>Test stub for set_Software(String)</summary>
		[PexMethod]
		public void SoftwareSetTest([PexAssumeUnderTest]XmpTag target, string value)
		{
			target.Software = value;
			// TODO: add assertions to method XmpTagTest.SoftwareSetTest(XmpTag, String)
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]XmpTag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method XmpTagTest.TitleSetTest(XmpTag, String)
		}
	}
}
