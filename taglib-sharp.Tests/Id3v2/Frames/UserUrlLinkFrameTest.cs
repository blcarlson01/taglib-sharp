using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for UserUrlLinkFrame</summary>
    [TestClass]
    [PexClass(typeof(UserUrlLinkFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UserUrlLinkFrameTest
    {

		/// <summary>Test stub for .ctor(String, StringType)</summary>
		[PexMethod]
		public UserUrlLinkFrame ConstructorTest(string description, StringType encoding)
		{
			UserUrlLinkFrame target = new UserUrlLinkFrame(description, encoding);
			return target;
			// TODO: add assertions to method UserUrlLinkFrameTest.ConstructorTest(String, StringType)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public UserUrlLinkFrame ConstructorTest01(string description)
		{
			UserUrlLinkFrame target = new UserUrlLinkFrame(description);
			return target;
			// TODO: add assertions to method UserUrlLinkFrameTest.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public UserUrlLinkFrame ConstructorTest02(ByteVector data, byte version)
		{
			UserUrlLinkFrame target = new UserUrlLinkFrame(data, version);
			return target;
			// TODO: add assertions to method UserUrlLinkFrameTest.ConstructorTest02(ByteVector, Byte)
		}

	

		/// <summary>Test stub for Get(Tag, String, StringType, Boolean)</summary>
		[PexMethod]
		public UserUrlLinkFrame GetTest(
			Tag tag,
			string description,
			StringType type,
			bool create
		)
		{
			UserUrlLinkFrame result = UserUrlLinkFrame.Get(tag, description, type, create);
			return result;
			// TODO: add assertions to method UserUrlLinkFrameTest.GetTest(Tag, String, StringType, Boolean)
		}

		/// <summary>Test stub for Get(Tag, String, Boolean)</summary>
		[PexMethod]
		public UserUrlLinkFrame GetTest01(
			Tag tag,
			string description,
			bool create
		)
		{
			UserUrlLinkFrame result = UserUrlLinkFrame.Get(tag, description, create);
			return result;
			// TODO: add assertions to method UserUrlLinkFrameTest.GetTest01(Tag, String, Boolean)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]UserUrlLinkFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method UserUrlLinkFrameTest.ToStringTest(UserUrlLinkFrame)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]UserUrlLinkFrame target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method UserUrlLinkFrameTest.DescriptionGetTest(UserUrlLinkFrame)
		}

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public string[] TextGetTest([PexAssumeUnderTest]UserUrlLinkFrame target)
		{
			string[] result = target.Text;
			return result;
			// TODO: add assertions to method UserUrlLinkFrameTest.TextGetTest(UserUrlLinkFrame)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]UserUrlLinkFrame target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method UserUrlLinkFrameTest.DescriptionSetTest(UserUrlLinkFrame, String)
		}

		/// <summary>Test stub for set_Text(String[])</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]UserUrlLinkFrame target, string[] value)
		{
			target.Text = value;
			// TODO: add assertions to method UserUrlLinkFrameTest.TextSetTest(UserUrlLinkFrame, String[])
		}
	}
}
