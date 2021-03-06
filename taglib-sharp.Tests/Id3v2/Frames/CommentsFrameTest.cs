using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for CommentsFrame</summary>
    [TestClass]
    [PexClass(typeof(CommentsFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CommentsFrameTest
    {

		/// <summary>Test stub for .ctor(String, String, StringType)</summary>
		[PexMethod]
		public CommentsFrame ConstructorTest(
			string description,
			string language,
			StringType encoding
		)
		{
			CommentsFrame target = new CommentsFrame(description, language, encoding);
			return target;
			// TODO: add assertions to method CommentsFrameTest.ConstructorTest(String, String, StringType)
		}

		/// <summary>Test stub for .ctor(String, String)</summary>
		[PexMethod]
		public CommentsFrame ConstructorTest01(string description, string language)
		{
			CommentsFrame target = new CommentsFrame(description, language);
			return target;
			// TODO: add assertions to method CommentsFrameTest.ConstructorTest01(String, String)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public CommentsFrame ConstructorTest02(string description)
		{
			CommentsFrame target = new CommentsFrame(description);
			return target;
			// TODO: add assertions to method CommentsFrameTest.ConstructorTest02(String)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public CommentsFrame ConstructorTest03(ByteVector data, byte version)
		{
			CommentsFrame target = new CommentsFrame(data, version);
			return target;
			// TODO: add assertions to method CommentsFrameTest.ConstructorTest03(ByteVector, Byte)
		}

		
		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]CommentsFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method CommentsFrameTest.CloneTest(CommentsFrame)
		}

		/// <summary>Test stub for Get(Tag, String, String, Boolean)</summary>
		[PexMethod]
		public CommentsFrame GetTest(
			Tag tag,
			string description,
			string language,
			bool create
		)
		{
			CommentsFrame result = CommentsFrame.Get(tag, description, language, create);
			return result;
			// TODO: add assertions to method CommentsFrameTest.GetTest(Tag, String, String, Boolean)
		}

		/// <summary>Test stub for GetPreferred(Tag, String, String)</summary>
		[PexMethod]
		public CommentsFrame GetPreferredTest(
			Tag tag,
			string description,
			string language
		)
		{
			CommentsFrame result = CommentsFrame.GetPreferred(tag, description, language);
			return result;
			// TODO: add assertions to method CommentsFrameTest.GetPreferredTest(Tag, String, String)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]CommentsFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method CommentsFrameTest.ToStringTest(CommentsFrame)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]CommentsFrame target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method CommentsFrameTest.DescriptionGetTest(CommentsFrame)
		}

		/// <summary>Test stub for get_Language()</summary>
		[PexMethod]
		public string LanguageGetTest([PexAssumeUnderTest]CommentsFrame target)
		{
			string result = target.Language;
			return result;
			// TODO: add assertions to method CommentsFrameTest.LanguageGetTest(CommentsFrame)
		}

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public string TextGetTest([PexAssumeUnderTest]CommentsFrame target)
		{
			string result = target.Text;
			return result;
			// TODO: add assertions to method CommentsFrameTest.TextGetTest(CommentsFrame)
		}

		/// <summary>Test stub for get_TextEncoding()</summary>
		[PexMethod]
		public StringType TextEncodingGetTest([PexAssumeUnderTest]CommentsFrame target)
		{
			StringType result = target.TextEncoding;
			return result;
			// TODO: add assertions to method CommentsFrameTest.TextEncodingGetTest(CommentsFrame)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]CommentsFrame target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method CommentsFrameTest.DescriptionSetTest(CommentsFrame, String)
		}

		/// <summary>Test stub for set_Language(String)</summary>
		[PexMethod]
		public void LanguageSetTest([PexAssumeUnderTest]CommentsFrame target, string value)
		{
			target.Language = value;
			// TODO: add assertions to method CommentsFrameTest.LanguageSetTest(CommentsFrame, String)
		}

		/// <summary>Test stub for set_Text(String)</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]CommentsFrame target, string value)
		{
			target.Text = value;
			// TODO: add assertions to method CommentsFrameTest.TextSetTest(CommentsFrame, String)
		}

		/// <summary>Test stub for set_TextEncoding(StringType)</summary>
		[PexMethod]
		public void TextEncodingSetTest([PexAssumeUnderTest]CommentsFrame target, StringType value)
		{
			target.TextEncoding = value;
			// TODO: add assertions to method CommentsFrameTest.TextEncodingSetTest(CommentsFrame, StringType)
		}
	}
}
