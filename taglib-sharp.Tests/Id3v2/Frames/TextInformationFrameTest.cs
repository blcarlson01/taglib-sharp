using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for TextInformationFrame</summary>
    [TestClass]
    [PexClass(typeof(TextInformationFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TextInformationFrameTest
    {

		/// <summary>Test stub for .ctor(ByteVector, StringType)</summary>
		[PexMethod]
		public TextInformationFrame ConstructorTest(ByteVector ident, StringType encoding)
		{
			TextInformationFrame target = new TextInformationFrame(ident, encoding);
			return target;
			// TODO: add assertions to method TextInformationFrameTest.ConstructorTest(ByteVector, StringType)
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public TextInformationFrame ConstructorTest01(ByteVector ident)
		{
			TextInformationFrame target = new TextInformationFrame(ident);
			return target;
			// TODO: add assertions to method TextInformationFrameTest.ConstructorTest01(ByteVector)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public TextInformationFrame ConstructorTest02(ByteVector data, byte version)
		{
			TextInformationFrame target = new TextInformationFrame(data, version);
			return target;
			// TODO: add assertions to method TextInformationFrameTest.ConstructorTest02(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]TextInformationFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method TextInformationFrameTest.CloneTest(TextInformationFrame)
		}

		/// <summary>Test stub for Get(Tag, ByteVector, StringType, Boolean)</summary>
		[PexMethod]
		public TextInformationFrame GetTest(
			Tag tag,
			ByteVector ident,
			StringType encoding,
			bool create
		)
		{
			TextInformationFrame result = TextInformationFrame.Get(tag, ident, encoding, create);
			return result;
			// TODO: add assertions to method TextInformationFrameTest.GetTest(Tag, ByteVector, StringType, Boolean)
		}

		/// <summary>Test stub for Get(Tag, ByteVector, Boolean)</summary>
		[PexMethod]
		public TextInformationFrame GetTest01(
			Tag tag,
			ByteVector ident,
			bool create
		)
		{
			TextInformationFrame result = TextInformationFrame.Get(tag, ident, create);
			return result;
			// TODO: add assertions to method TextInformationFrameTest.GetTest01(Tag, ByteVector, Boolean)
		}

		/// <summary>Test stub for Render(Byte)</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]TextInformationFrame target, byte version)
		{
			ByteVector result = target.Render(version);
			return result;
			// TODO: add assertions to method TextInformationFrameTest.RenderTest(TextInformationFrame, Byte)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]TextInformationFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method TextInformationFrameTest.ToStringTest(TextInformationFrame)
		}

		

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public string[] TextGetTest([PexAssumeUnderTest]TextInformationFrame target)
		{
			string[] result = target.Text;
			return result;
			// TODO: add assertions to method TextInformationFrameTest.TextGetTest(TextInformationFrame)
		}

		/// <summary>Test stub for get_TextEncoding()</summary>
		[PexMethod]
		public StringType TextEncodingGetTest([PexAssumeUnderTest]TextInformationFrame target)
		{
			StringType result = target.TextEncoding;
			return result;
			// TODO: add assertions to method TextInformationFrameTest.TextEncodingGetTest(TextInformationFrame)
		}

		/// <summary>Test stub for set_Text(String[])</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]TextInformationFrame target, string[] value)
		{
			target.Text = value;
			// TODO: add assertions to method TextInformationFrameTest.TextSetTest(TextInformationFrame, String[])
		}

		/// <summary>Test stub for set_TextEncoding(StringType)</summary>
		[PexMethod]
		public void TextEncodingSetTest([PexAssumeUnderTest]TextInformationFrame target, StringType value)
		{
			target.TextEncoding = value;
			// TODO: add assertions to method TextInformationFrameTest.TextEncodingSetTest(TextInformationFrame, StringType)
		}
	}
}
