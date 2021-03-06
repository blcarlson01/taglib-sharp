using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for UrlLinkFrame</summary>
    [TestClass]
    [PexClass(typeof(UrlLinkFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UrlLinkFrameTest
    {

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public UrlLinkFrame ConstructorTest(ByteVector ident)
		{
			UrlLinkFrame target = new UrlLinkFrame(ident);
			return target;
			// TODO: add assertions to method UrlLinkFrameTest.ConstructorTest(ByteVector)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public UrlLinkFrame ConstructorTest01(ByteVector data, byte version)
		{
			UrlLinkFrame target = new UrlLinkFrame(data, version);
			return target;
			// TODO: add assertions to method UrlLinkFrameTest.ConstructorTest01(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]UrlLinkFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method UrlLinkFrameTest.CloneTest(UrlLinkFrame)
		}

		/// <summary>Test stub for Get(Tag, ByteVector, Boolean)</summary>
		[PexMethod]
		public UrlLinkFrame GetTest(
			Tag tag,
			ByteVector ident,
			bool create
		)
		{
			UrlLinkFrame result = UrlLinkFrame.Get(tag, ident, create);
			return result;
			// TODO: add assertions to method UrlLinkFrameTest.GetTest(Tag, ByteVector, Boolean)
		}

		/// <summary>Test stub for Render(Byte)</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]UrlLinkFrame target, byte version)
		{
			ByteVector result = target.Render(version);
			return result;
			// TODO: add assertions to method UrlLinkFrameTest.RenderTest(UrlLinkFrame, Byte)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]UrlLinkFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method UrlLinkFrameTest.ToStringTest(UrlLinkFrame)
		}

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public string[] TextGetTest([PexAssumeUnderTest]UrlLinkFrame target)
		{
			string[] result = target.Text;
			return result;
			// TODO: add assertions to method UrlLinkFrameTest.TextGetTest(UrlLinkFrame)
		}

		/// <summary>Test stub for get_TextEncoding()</summary>
		[PexMethod]
		public StringType TextEncodingGetTest([PexAssumeUnderTest]UrlLinkFrame target)
		{
			StringType result = target.TextEncoding;
			return result;
			// TODO: add assertions to method UrlLinkFrameTest.TextEncodingGetTest(UrlLinkFrame)
		}

		/// <summary>Test stub for set_Text(String[])</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]UrlLinkFrame target, string[] value)
		{
			target.Text = value;
			// TODO: add assertions to method UrlLinkFrameTest.TextSetTest(UrlLinkFrame, String[])
		}

		/// <summary>Test stub for set_TextEncoding(StringType)</summary>
		[PexMethod]
		public void TextEncodingSetTest([PexAssumeUnderTest]UrlLinkFrame target, StringType value)
		{
			target.TextEncoding = value;
			// TODO: add assertions to method UrlLinkFrameTest.TextEncodingSetTest(UrlLinkFrame, StringType)
		}
	}
}
