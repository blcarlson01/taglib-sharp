using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Flac;

namespace TagLib.Flac.Tests
{
    /// <summary>This class contains parameterized unit tests for Picture</summary>
    [TestClass]
    [PexClass(typeof(Picture))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PictureTest
    {

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public Picture ConstructorTest(ByteVector data)
		{
			Picture target = new Picture(data);
			return target;
			// TODO: add assertions to method PictureTest.ConstructorTest(ByteVector)
		}

		/// <summary>Test stub for .ctor(IPicture)</summary>
		[PexMethod]
		public Picture ConstructorTest01(IPicture picture)
		{
			Picture target = new Picture(picture);
			return target;
			// TODO: add assertions to method PictureTest.ConstructorTest01(IPicture)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]Picture target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method PictureTest.RenderTest(Picture)
		}

		/// <summary>Test stub for get_ColorDepth()</summary>
		[PexMethod]
		public int ColorDepthGetTest([PexAssumeUnderTest]Picture target)
		{
			int result = target.ColorDepth;
			return result;
			// TODO: add assertions to method PictureTest.ColorDepthGetTest(Picture)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]Picture target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method PictureTest.DataGetTest(Picture)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Picture target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method PictureTest.DescriptionGetTest(Picture)
		}

		/// <summary>Test stub for get_Filename()</summary>
		[PexMethod]
		public string FilenameGetTest([PexAssumeUnderTest]Picture target)
		{
			string result = target.Filename;
			return result;
			// TODO: add assertions to method PictureTest.FilenameGetTest(Picture)
		}

		/// <summary>Test stub for get_Height()</summary>
		[PexMethod]
		public int HeightGetTest([PexAssumeUnderTest]Picture target)
		{
			int result = target.Height;
			return result;
			// TODO: add assertions to method PictureTest.HeightGetTest(Picture)
		}

		/// <summary>Test stub for get_IndexedColors()</summary>
		[PexMethod]
		public int IndexedColorsGetTest([PexAssumeUnderTest]Picture target)
		{
			int result = target.IndexedColors;
			return result;
			// TODO: add assertions to method PictureTest.IndexedColorsGetTest(Picture)
		}

		/// <summary>Test stub for get_MimeType()</summary>
		[PexMethod]
		public string MimeTypeGetTest([PexAssumeUnderTest]Picture target)
		{
			string result = target.MimeType;
			return result;
			// TODO: add assertions to method PictureTest.MimeTypeGetTest(Picture)
		}

		/// <summary>Test stub for get_Type()</summary>
		[PexMethod]
		public PictureType TypeGetTest([PexAssumeUnderTest]Picture target)
		{
			PictureType result = target.Type;
			return result;
			// TODO: add assertions to method PictureTest.TypeGetTest(Picture)
		}

		/// <summary>Test stub for get_Width()</summary>
		[PexMethod]
		public int WidthGetTest([PexAssumeUnderTest]Picture target)
		{
			int result = target.Width;
			return result;
			// TODO: add assertions to method PictureTest.WidthGetTest(Picture)
		}

		/// <summary>Test stub for set_ColorDepth(Int32)</summary>
		[PexMethod]
		public void ColorDepthSetTest([PexAssumeUnderTest]Picture target, int value)
		{
			target.ColorDepth = value;
			// TODO: add assertions to method PictureTest.ColorDepthSetTest(Picture, Int32)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]Picture target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method PictureTest.DataSetTest(Picture, ByteVector)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]Picture target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method PictureTest.DescriptionSetTest(Picture, String)
		}

		/// <summary>Test stub for set_Filename(String)</summary>
		[PexMethod]
		public void FilenameSetTest([PexAssumeUnderTest]Picture target, string value)
		{
			target.Filename = value;
			// TODO: add assertions to method PictureTest.FilenameSetTest(Picture, String)
		}

		/// <summary>Test stub for set_Height(Int32)</summary>
		[PexMethod]
		public void HeightSetTest([PexAssumeUnderTest]Picture target, int value)
		{
			target.Height = value;
			// TODO: add assertions to method PictureTest.HeightSetTest(Picture, Int32)
		}

		/// <summary>Test stub for set_IndexedColors(Int32)</summary>
		[PexMethod]
		public void IndexedColorsSetTest([PexAssumeUnderTest]Picture target, int value)
		{
			target.IndexedColors = value;
			// TODO: add assertions to method PictureTest.IndexedColorsSetTest(Picture, Int32)
		}

		/// <summary>Test stub for set_MimeType(String)</summary>
		[PexMethod]
		public void MimeTypeSetTest([PexAssumeUnderTest]Picture target, string value)
		{
			target.MimeType = value;
			// TODO: add assertions to method PictureTest.MimeTypeSetTest(Picture, String)
		}

		/// <summary>Test stub for set_Type(PictureType)</summary>
		[PexMethod]
		public void TypeSetTest([PexAssumeUnderTest]Picture target, PictureType value)
		{
			target.Type = value;
			// TODO: add assertions to method PictureTest.TypeSetTest(Picture, PictureType)
		}

		/// <summary>Test stub for set_Width(Int32)</summary>
		[PexMethod]
		public void WidthSetTest([PexAssumeUnderTest]Picture target, int value)
		{
			target.Width = value;
			// TODO: add assertions to method PictureTest.WidthSetTest(Picture, Int32)
		}
	}
}
