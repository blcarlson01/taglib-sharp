using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for TermsOfUseFrame</summary>
    [TestClass]
    [PexClass(typeof(TermsOfUseFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TermsOfUseFrameTest
    {

		/// <summary>Test stub for .ctor(String, StringType)</summary>
		[PexMethod]
		public TermsOfUseFrame ConstructorTest(string language, StringType encoding)
		{
			TermsOfUseFrame target = new TermsOfUseFrame(language, encoding);
			return target;
			// TODO: add assertions to method TermsOfUseFrameTest.ConstructorTest(String, StringType)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public TermsOfUseFrame ConstructorTest01(string language)
		{
			TermsOfUseFrame target = new TermsOfUseFrame(language);
			return target;
			// TODO: add assertions to method TermsOfUseFrameTest.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public TermsOfUseFrame ConstructorTest02(ByteVector data, byte version)
		{
			TermsOfUseFrame target = new TermsOfUseFrame(data, version);
			return target;
			// TODO: add assertions to method TermsOfUseFrameTest.ConstructorTest02(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]TermsOfUseFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method TermsOfUseFrameTest.CloneTest(TermsOfUseFrame)
		}

		/// <summary>Test stub for Get(Tag, String, Boolean)</summary>
		[PexMethod]
		public TermsOfUseFrame GetTest(
			Tag tag,
			string language,
			bool create
		)
		{
			TermsOfUseFrame result = TermsOfUseFrame.Get(tag, language, create);
			return result;
			// TODO: add assertions to method TermsOfUseFrameTest.GetTest(Tag, String, Boolean)
		}

		/// <summary>Test stub for GetPreferred(Tag, String)</summary>
		[PexMethod]
		public TermsOfUseFrame GetPreferredTest(Tag tag, string language)
		{
			TermsOfUseFrame result = TermsOfUseFrame.GetPreferred(tag, language);
			return result;
			// TODO: add assertions to method TermsOfUseFrameTest.GetPreferredTest(Tag, String)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]TermsOfUseFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method TermsOfUseFrameTest.ToStringTest(TermsOfUseFrame)
		}

		/// <summary>Test stub for get_Language()</summary>
		[PexMethod]
		public string LanguageGetTest([PexAssumeUnderTest]TermsOfUseFrame target)
		{
			string result = target.Language;
			return result;
			// TODO: add assertions to method TermsOfUseFrameTest.LanguageGetTest(TermsOfUseFrame)
		}

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public string TextGetTest([PexAssumeUnderTest]TermsOfUseFrame target)
		{
			string result = target.Text;
			return result;
			// TODO: add assertions to method TermsOfUseFrameTest.TextGetTest(TermsOfUseFrame)
		}

		/// <summary>Test stub for get_TextEncoding()</summary>
		[PexMethod]
		public StringType TextEncodingGetTest([PexAssumeUnderTest]TermsOfUseFrame target)
		{
			StringType result = target.TextEncoding;
			return result;
			// TODO: add assertions to method TermsOfUseFrameTest.TextEncodingGetTest(TermsOfUseFrame)
		}

		/// <summary>Test stub for set_Language(String)</summary>
		[PexMethod]
		public void LanguageSetTest([PexAssumeUnderTest]TermsOfUseFrame target, string value)
		{
			target.Language = value;
			// TODO: add assertions to method TermsOfUseFrameTest.LanguageSetTest(TermsOfUseFrame, String)
		}

		/// <summary>Test stub for set_Text(String)</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]TermsOfUseFrame target, string value)
		{
			target.Text = value;
			// TODO: add assertions to method TermsOfUseFrameTest.TextSetTest(TermsOfUseFrame, String)
		}

		/// <summary>Test stub for set_TextEncoding(StringType)</summary>
		[PexMethod]
		public void TextEncodingSetTest([PexAssumeUnderTest]TermsOfUseFrame target, StringType value)
		{
			target.TextEncoding = value;
			// TODO: add assertions to method TermsOfUseFrameTest.TextEncodingSetTest(TermsOfUseFrame, StringType)
		}
	}
}
