using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for AttachedPictureFrame</summary>
    [TestClass]
    [PexClass(typeof(AttachedPictureFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AttachedPictureFrameTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public AttachedPictureFrame ConstructorTest()
		{
			AttachedPictureFrame target = new AttachedPictureFrame();
			return target;
			// TODO: add assertions to method AttachedPictureFrameTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(IPicture)</summary>
		[PexMethod]
		public AttachedPictureFrame ConstructorTest01(IPicture picture)
		{
			AttachedPictureFrame target = new AttachedPictureFrame(picture);
			return target;
			// TODO: add assertions to method AttachedPictureFrameTest.ConstructorTest01(IPicture)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public AttachedPictureFrame ConstructorTest02(ByteVector data, byte version)
		{
			AttachedPictureFrame target = new AttachedPictureFrame(data, version);
			return target;
			// TODO: add assertions to method AttachedPictureFrameTest.ConstructorTest02(ByteVector, Byte)
		}

		
		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]AttachedPictureFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.CloneTest(AttachedPictureFrame)
		}

		/// <summary>Test stub for Get(Tag, String, Boolean)</summary>
		[PexMethod]
		public AttachedPictureFrame GetTest(
			Tag tag,
			string description,
			bool create
		)
		{
			AttachedPictureFrame result = AttachedPictureFrame.Get(tag, description, create);
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.GetTest(Tag, String, Boolean)
		}

		/// <summary>Test stub for Get(Tag, PictureType, Boolean)</summary>
		[PexMethod]
		public AttachedPictureFrame GetTest01(
			Tag tag,
			PictureType type,
			bool create
		)
		{
			AttachedPictureFrame result = AttachedPictureFrame.Get(tag, type, create);
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.GetTest01(Tag, PictureType, Boolean)
		}

		/// <summary>Test stub for Get(Tag, String, PictureType, Boolean)</summary>
		[PexMethod]
		public AttachedPictureFrame GetTest02(
			Tag tag,
			string description,
			PictureType type,
			bool create
		)
		{
			AttachedPictureFrame result = AttachedPictureFrame.Get(tag, description, type, create);
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.GetTest02(Tag, String, PictureType, Boolean)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]AttachedPictureFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.ToStringTest(AttachedPictureFrame)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]AttachedPictureFrame target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.DataGetTest(AttachedPictureFrame)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]AttachedPictureFrame target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.DescriptionGetTest(AttachedPictureFrame)
		}

		/// <summary>Test stub for get_Filename()</summary>
		[PexMethod]
		public string FilenameGetTest([PexAssumeUnderTest]AttachedPictureFrame target)
		{
			string result = target.Filename;
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.FilenameGetTest(AttachedPictureFrame)
		}

		/// <summary>Test stub for get_MimeType()</summary>
		[PexMethod]
		public string MimeTypeGetTest([PexAssumeUnderTest]AttachedPictureFrame target)
		{
			string result = target.MimeType;
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.MimeTypeGetTest(AttachedPictureFrame)
		}

		/// <summary>Test stub for get_TextEncoding()</summary>
		[PexMethod]
		public StringType TextEncodingGetTest([PexAssumeUnderTest]AttachedPictureFrame target)
		{
			StringType result = target.TextEncoding;
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.TextEncodingGetTest(AttachedPictureFrame)
		}

		/// <summary>Test stub for get_Type()</summary>
		[PexMethod]
		public PictureType TypeGetTest([PexAssumeUnderTest]AttachedPictureFrame target)
		{
			PictureType result = target.Type;
			return result;
			// TODO: add assertions to method AttachedPictureFrameTest.TypeGetTest(AttachedPictureFrame)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]AttachedPictureFrame target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method AttachedPictureFrameTest.DataSetTest(AttachedPictureFrame, ByteVector)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]AttachedPictureFrame target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method AttachedPictureFrameTest.DescriptionSetTest(AttachedPictureFrame, String)
		}

		/// <summary>Test stub for set_Filename(String)</summary>
		[PexMethod]
		public void FilenameSetTest([PexAssumeUnderTest]AttachedPictureFrame target, string value)
		{
			target.Filename = value;
			// TODO: add assertions to method AttachedPictureFrameTest.FilenameSetTest(AttachedPictureFrame, String)
		}

		/// <summary>Test stub for set_MimeType(String)</summary>
		[PexMethod]
		public void MimeTypeSetTest([PexAssumeUnderTest]AttachedPictureFrame target, string value)
		{
			target.MimeType = value;
			// TODO: add assertions to method AttachedPictureFrameTest.MimeTypeSetTest(AttachedPictureFrame, String)
		}

		/// <summary>Test stub for set_TextEncoding(StringType)</summary>
		[PexMethod]
		public void TextEncodingSetTest([PexAssumeUnderTest]AttachedPictureFrame target, StringType value)
		{
			target.TextEncoding = value;
			// TODO: add assertions to method AttachedPictureFrameTest.TextEncodingSetTest(AttachedPictureFrame, StringType)
		}

		/// <summary>Test stub for set_Type(PictureType)</summary>
		[PexMethod]
		public void TypeSetTest([PexAssumeUnderTest]AttachedPictureFrame target, PictureType value)
		{
			target.Type = value;
			// TODO: add assertions to method AttachedPictureFrameTest.TypeSetTest(AttachedPictureFrame, PictureType)
		}
	}
}
