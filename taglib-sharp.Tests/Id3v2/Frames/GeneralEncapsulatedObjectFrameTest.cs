using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for GeneralEncapsulatedObjectFrame</summary>
    [TestClass]
    [PexClass(typeof(GeneralEncapsulatedObjectFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GeneralEncapsulatedObjectFrameTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public GeneralEncapsulatedObjectFrame ConstructorTest()
		{
			GeneralEncapsulatedObjectFrame target = new GeneralEncapsulatedObjectFrame();
			return target;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public GeneralEncapsulatedObjectFrame ConstructorTest01(ByteVector data, byte version)
		{
			GeneralEncapsulatedObjectFrame target = new GeneralEncapsulatedObjectFrame(data, version);
			return target;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.ConstructorTest01(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.CloneTest(GeneralEncapsulatedObjectFrame)
		}

		/// <summary>Test stub for Get(Tag, String, Boolean)</summary>
		[PexMethod]
		public GeneralEncapsulatedObjectFrame GetTest(
			Tag tag,
			string description,
			bool create
		)
		{
			GeneralEncapsulatedObjectFrame result = GeneralEncapsulatedObjectFrame.Get(tag, description, create)
			  ;
			return result;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.GetTest(Tag, String, Boolean)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.ToStringTest(GeneralEncapsulatedObjectFrame)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.DescriptionGetTest(GeneralEncapsulatedObjectFrame)
		}

		/// <summary>Test stub for get_FileName()</summary>
		[PexMethod]
		public string FileNameGetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target)
		{
			string result = target.FileName;
			return result;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.FileNameGetTest(GeneralEncapsulatedObjectFrame)
		}

		/// <summary>Test stub for get_MimeType()</summary>
		[PexMethod]
		public string MimeTypeGetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target)
		{
			string result = target.MimeType;
			return result;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.MimeTypeGetTest(GeneralEncapsulatedObjectFrame)
		}

		/// <summary>Test stub for get_Object()</summary>
		[PexMethod]
		public ByteVector ObjectGetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target)
		{
			ByteVector result = target.Object;
			return result;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.ObjectGetTest(GeneralEncapsulatedObjectFrame)
		}

		/// <summary>Test stub for get_TextEncoding()</summary>
		[PexMethod]
		public StringType TextEncodingGetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target)
		{
			StringType result = target.TextEncoding;
			return result;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.TextEncodingGetTest(GeneralEncapsulatedObjectFrame)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.DescriptionSetTest(GeneralEncapsulatedObjectFrame, String)
		}

		/// <summary>Test stub for set_FileName(String)</summary>
		[PexMethod]
		public void FileNameSetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target, string value)
		{
			target.FileName = value;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.FileNameSetTest(GeneralEncapsulatedObjectFrame, String)
		}

		/// <summary>Test stub for set_MimeType(String)</summary>
		[PexMethod]
		public void MimeTypeSetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target, string value)
		{
			target.MimeType = value;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.MimeTypeSetTest(GeneralEncapsulatedObjectFrame, String)
		}

		/// <summary>Test stub for set_Object(ByteVector)</summary>
		[PexMethod]
		public void ObjectSetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target, ByteVector value)
		{
			target.Object = value;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.ObjectSetTest(GeneralEncapsulatedObjectFrame, ByteVector)
		}

		/// <summary>Test stub for set_TextEncoding(StringType)</summary>
		[PexMethod]
		public void TextEncodingSetTest([PexAssumeUnderTest]GeneralEncapsulatedObjectFrame target, StringType value)
		{
			target.TextEncoding = value;
			// TODO: add assertions to method GeneralEncapsulatedObjectFrameTest.TextEncodingSetTest(GeneralEncapsulatedObjectFrame, StringType)
		}
	}
}
