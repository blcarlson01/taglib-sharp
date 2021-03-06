using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for UnsynchronisedLyricsFrame</summary>
    [TestClass]
    [PexClass(typeof(UnsynchronisedLyricsFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnsynchronisedLyricsFrameTest
    {

		/// <summary>Test stub for .ctor(String, String, StringType)</summary>
		[PexMethod]
		public UnsynchronisedLyricsFrame ConstructorTest(
			string description,
			string language,
			StringType encoding
		)
		{
			UnsynchronisedLyricsFrame target = new UnsynchronisedLyricsFrame(description, language, encoding);
			return target;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.ConstructorTest(String, String, StringType)
		}

		/// <summary>Test stub for .ctor(String, String)</summary>
		[PexMethod]
		public UnsynchronisedLyricsFrame ConstructorTest01(string description, string language)
		{
			UnsynchronisedLyricsFrame target = new UnsynchronisedLyricsFrame(description, language);
			return target;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.ConstructorTest01(String, String)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public UnsynchronisedLyricsFrame ConstructorTest02(string description)
		{
			UnsynchronisedLyricsFrame target = new UnsynchronisedLyricsFrame(description);
			return target;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.ConstructorTest02(String)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public UnsynchronisedLyricsFrame ConstructorTest03(ByteVector data, byte version)
		{
			UnsynchronisedLyricsFrame target = new UnsynchronisedLyricsFrame(data, version);
			return target;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.ConstructorTest03(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.CloneTest(UnsynchronisedLyricsFrame)
		}

		/// <summary>Test stub for Get(Tag, String, String, Boolean)</summary>
		[PexMethod]
		public UnsynchronisedLyricsFrame GetTest(
			Tag tag,
			string description,
			string language,
			bool create
		)
		{
			UnsynchronisedLyricsFrame result = UnsynchronisedLyricsFrame.Get(tag, description, language, create)
			  ;
			return result;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.GetTest(Tag, String, String, Boolean)
		}

		/// <summary>Test stub for GetPreferred(Tag, String, String)</summary>
		[PexMethod]
		public UnsynchronisedLyricsFrame GetPreferredTest(
			Tag tag,
			string description,
			string language
		)
		{
			UnsynchronisedLyricsFrame result
			   = UnsynchronisedLyricsFrame.GetPreferred(tag, description, language);
			return result;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.GetPreferredTest(Tag, String, String)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.ToStringTest(UnsynchronisedLyricsFrame)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.DescriptionGetTest(UnsynchronisedLyricsFrame)
		}

		/// <summary>Test stub for get_Language()</summary>
		[PexMethod]
		public string LanguageGetTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target)
		{
			string result = target.Language;
			return result;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.LanguageGetTest(UnsynchronisedLyricsFrame)
		}

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public string TextGetTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target)
		{
			string result = target.Text;
			return result;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.TextGetTest(UnsynchronisedLyricsFrame)
		}

		/// <summary>Test stub for get_TextEncoding()</summary>
		[PexMethod]
		public StringType TextEncodingGetTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target)
		{
			StringType result = target.TextEncoding;
			return result;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.TextEncodingGetTest(UnsynchronisedLyricsFrame)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.DescriptionSetTest(UnsynchronisedLyricsFrame, String)
		}

		/// <summary>Test stub for set_Language(String)</summary>
		[PexMethod]
		public void LanguageSetTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target, string value)
		{
			target.Language = value;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.LanguageSetTest(UnsynchronisedLyricsFrame, String)
		}

		/// <summary>Test stub for set_Text(String)</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target, string value)
		{
			target.Text = value;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.TextSetTest(UnsynchronisedLyricsFrame, String)
		}

		/// <summary>Test stub for set_TextEncoding(StringType)</summary>
		[PexMethod]
		public void TextEncodingSetTest([PexAssumeUnderTest]UnsynchronisedLyricsFrame target, StringType value)
		{
			target.TextEncoding = value;
			// TODO: add assertions to method UnsynchronisedLyricsFrameTest.TextEncodingSetTest(UnsynchronisedLyricsFrame, StringType)
		}
	}
}
