using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for UserTextInformationFrame</summary>
    [TestClass]
    [PexClass(typeof(UserTextInformationFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UserTextInformationFrameTest
    {

		/// <summary>Test stub for .ctor(String, StringType)</summary>
		[PexMethod]
		public UserTextInformationFrame ConstructorTest(string description, StringType encoding)
		{
			UserTextInformationFrame target = new UserTextInformationFrame(description, encoding);
			return target;
			// TODO: add assertions to method UserTextInformationFrameTest.ConstructorTest(String, StringType)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public UserTextInformationFrame ConstructorTest01(string description)
		{
			UserTextInformationFrame target = new UserTextInformationFrame(description);
			return target;
			// TODO: add assertions to method UserTextInformationFrameTest.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public UserTextInformationFrame ConstructorTest02(ByteVector data, byte version)
		{
			UserTextInformationFrame target = new UserTextInformationFrame(data, version);
			return target;
			// TODO: add assertions to method UserTextInformationFrameTest.ConstructorTest02(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Get(Tag, String, StringType, Boolean, Boolean)</summary>
		[PexMethod]
		public UserTextInformationFrame GetTest(
			Tag tag,
			string description,
			StringType type,
			bool create,
			bool caseSensitive
		)
		{
			UserTextInformationFrame result
			   = UserTextInformationFrame.Get(tag, description, type, create, caseSensitive);
			return result;
			// TODO: add assertions to method UserTextInformationFrameTest.GetTest(Tag, String, StringType, Boolean, Boolean)
		}

		/// <summary>Test stub for Get(Tag, String, StringType, Boolean)</summary>
		[PexMethod]
		public UserTextInformationFrame GetTest01(
			Tag tag,
			string description,
			StringType type,
			bool create
		)
		{
			UserTextInformationFrame result = UserTextInformationFrame.Get(tag, description, type, create);
			return result;
			// TODO: add assertions to method UserTextInformationFrameTest.GetTest01(Tag, String, StringType, Boolean)
		}

		/// <summary>Test stub for Get(Tag, String, Boolean)</summary>
		[PexMethod]
		public UserTextInformationFrame GetTest02(
			Tag tag,
			string description,
			bool create
		)
		{
			UserTextInformationFrame result = UserTextInformationFrame.Get(tag, description, create);
			return result;
			// TODO: add assertions to method UserTextInformationFrameTest.GetTest02(Tag, String, Boolean)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]UserTextInformationFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method UserTextInformationFrameTest.ToStringTest(UserTextInformationFrame)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]UserTextInformationFrame target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method UserTextInformationFrameTest.DescriptionGetTest(UserTextInformationFrame)
		}

		/// <summary>Test stub for get_Text()</summary>
		[PexMethod]
		public string[] TextGetTest([PexAssumeUnderTest]UserTextInformationFrame target)
		{
			string[] result = target.Text;
			return result;
			// TODO: add assertions to method UserTextInformationFrameTest.TextGetTest(UserTextInformationFrame)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]UserTextInformationFrame target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method UserTextInformationFrameTest.DescriptionSetTest(UserTextInformationFrame, String)
		}

		/// <summary>Test stub for set_Text(String[])</summary>
		[PexMethod]
		public void TextSetTest([PexAssumeUnderTest]UserTextInformationFrame target, string[] value)
		{
			target.Text = value;
			// TODO: add assertions to method UserTextInformationFrameTest.TextSetTest(UserTextInformationFrame, String[])
		}
	}
}
