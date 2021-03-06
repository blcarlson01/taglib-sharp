using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for SynchronisedLyricsFrame</summary>
    [TestClass]
    [PexClass(typeof(SynchronisedLyricsFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SynchronisedLyricsFrameTest
    {

		/// <summary>Test stub for .ctor(String, String, SynchedTextType, StringType)</summary>
		[PexMethod]
		public SynchronisedLyricsFrame ConstructorTest(
			string description,
			string language,
			SynchedTextType type,
			StringType encoding
		)
		{
			SynchronisedLyricsFrame target = new SynchronisedLyricsFrame(description, language, type, encoding);
			return target;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.ConstructorTest(String, String, SynchedTextType, StringType)
		}

		/// <summary>Test stub for .ctor(String, String, SynchedTextType)</summary>
		[PexMethod]
		public SynchronisedLyricsFrame ConstructorTest01(
			string description,
			string language,
			SynchedTextType type
		)
		{
			SynchronisedLyricsFrame target = new SynchronisedLyricsFrame(description, language, type);
			return target;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.ConstructorTest01(String, String, SynchedTextType)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public SynchronisedLyricsFrame ConstructorTest02(ByteVector data, byte version)
		{
			SynchronisedLyricsFrame target = new SynchronisedLyricsFrame(data, version);
			return target;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.ConstructorTest02(ByteVector, Byte)
		}


		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]SynchronisedLyricsFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.CloneTest(SynchronisedLyricsFrame)
		}

		/// <summary>Test stub for Get(Tag, String, String, SynchedTextType, Boolean)</summary>
		[PexMethod]
		public SynchronisedLyricsFrame GetTest(
			Tag tag,
			string description,
			string language,
			SynchedTextType type,
			bool create
		)
		{
			SynchronisedLyricsFrame result
			   = SynchronisedLyricsFrame.Get(tag, description, language, type, create);
			return result;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.GetTest(Tag, String, String, SynchedTextType, Boolean)
		}

		/// <summary>Test stub for GetPreferred(Tag, String, String, SynchedTextType)</summary>
		[PexMethod]
		public SynchronisedLyricsFrame GetPreferredTest(
			Tag tag,
			string description,
			string language,
			SynchedTextType type
		)
		{
			SynchronisedLyricsFrame result
			   = SynchronisedLyricsFrame.GetPreferred(tag, description, language, type);
			return result;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.GetPreferredTest(Tag, String, String, SynchedTextType)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.DescriptionGetTest(SynchronisedLyricsFrame)
		}

		/// <summary>Test stub for get_Format()</summary>
		[PexMethod]
		public TimestampFormat FormatGetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target)
		{
			TimestampFormat result = target.Format;
			return result;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.FormatGetTest(SynchronisedLyricsFrame)
		}

		/// <summary>Test stub for get_Language()</summary>
		[PexMethod]
		public string LanguageGetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target)
		{
			string result = target.Language;
			return result;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.LanguageGetTest(SynchronisedLyricsFrame)
		}

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public SynchedText[] TextGetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target)
		{
			SynchedText[] result = target.Text;
			return result;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.TextGetTest(SynchronisedLyricsFrame)
		}

		/// <summary>Test stub for get_TextEncoding()</summary>
		[PexMethod]
		public StringType TextEncodingGetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target)
		{
			StringType result = target.TextEncoding;
			return result;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.TextEncodingGetTest(SynchronisedLyricsFrame)
		}

		/// <summary>Test stub for get_Type()</summary>
		[PexMethod]
		public SynchedTextType TypeGetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target)
		{
			SynchedTextType result = target.Type;
			return result;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.TypeGetTest(SynchronisedLyricsFrame)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.DescriptionSetTest(SynchronisedLyricsFrame, String)
		}

		/// <summary>Test stub for set_Format(TimestampFormat)</summary>
		[PexMethod]
		public void FormatSetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target, TimestampFormat value)
		{
			target.Format = value;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.FormatSetTest(SynchronisedLyricsFrame, TimestampFormat)
		}

		/// <summary>Test stub for set_Language(String)</summary>
		[PexMethod]
		public void LanguageSetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target, string value)
		{
			target.Language = value;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.LanguageSetTest(SynchronisedLyricsFrame, String)
		}

		/// <summary>Test stub for set_Text(SynchedText[])</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target, SynchedText[] value)
		{
			target.Text = value;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.TextSetTest(SynchronisedLyricsFrame, SynchedText[])
		}

		/// <summary>Test stub for set_TextEncoding(StringType)</summary>
		[PexMethod]
		public void TextEncodingSetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target, StringType value)
		{
			target.TextEncoding = value;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.TextEncodingSetTest(SynchronisedLyricsFrame, StringType)
		}

		/// <summary>Test stub for set_Type(SynchedTextType)</summary>
		[PexMethod]
		public void TypeSetTest([PexAssumeUnderTest]SynchronisedLyricsFrame target, SynchedTextType value)
		{
			target.Type = value;
			// TODO: add assertions to method SynchronisedLyricsFrameTest.TypeSetTest(SynchronisedLyricsFrame, SynchedTextType)
		}
	}
}
