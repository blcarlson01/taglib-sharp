using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for PopularimeterFrame</summary>
    [TestClass]
    [PexClass(typeof(PopularimeterFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PopularimeterFrameTest
    {

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public PopularimeterFrame ConstructorTest(string user)
		{
			PopularimeterFrame target = new PopularimeterFrame(user);
			return target;
			// TODO: add assertions to method PopularimeterFrameTest.ConstructorTest(String)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public PopularimeterFrame ConstructorTest01(ByteVector data, byte version)
		{
			PopularimeterFrame target = new PopularimeterFrame(data, version);
			return target;
			// TODO: add assertions to method PopularimeterFrameTest.ConstructorTest01(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]PopularimeterFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method PopularimeterFrameTest.CloneTest(PopularimeterFrame)
		}

		/// <summary>Test stub for Get(Tag, String, Boolean)</summary>
		[PexMethod]
		public PopularimeterFrame GetTest(
			Tag tag,
			string user,
			bool create
		)
		{
			PopularimeterFrame result = PopularimeterFrame.Get(tag, user, create);
			return result;
			// TODO: add assertions to method PopularimeterFrameTest.GetTest(Tag, String, Boolean)
		}

		/// <summary>Test stub for get_PlayCount()</summary>
		[PexMethod]
		public ulong PlayCountGetTest([PexAssumeUnderTest]PopularimeterFrame target)
		{
			ulong result = target.PlayCount;
			return result;
			// TODO: add assertions to method PopularimeterFrameTest.PlayCountGetTest(PopularimeterFrame)
		}

		/// <summary>Test stub for get_Rating()</summary>
		[PexMethod]
		public byte RatingGetTest([PexAssumeUnderTest]PopularimeterFrame target)
		{
			byte result = target.Rating;
			return result;
			// TODO: add assertions to method PopularimeterFrameTest.RatingGetTest(PopularimeterFrame)
		}

		/// <summary>Test stub for get_User()</summary>
		[PexMethod]
		public string UserGetTest([PexAssumeUnderTest]PopularimeterFrame target)
		{
			string result = target.User;
			return result;
			// TODO: add assertions to method PopularimeterFrameTest.UserGetTest(PopularimeterFrame)
		}

		/// <summary>Test stub for set_PlayCount(UInt64)</summary>
		[PexMethod]
		public void PlayCountSetTest([PexAssumeUnderTest]PopularimeterFrame target, ulong value)
		{
			target.PlayCount = value;
			// TODO: add assertions to method PopularimeterFrameTest.PlayCountSetTest(PopularimeterFrame, UInt64)
		}

		/// <summary>Test stub for set_Rating(Byte)</summary>
		[PexMethod]
		public void RatingSetTest([PexAssumeUnderTest]PopularimeterFrame target, byte value)
		{
			target.Rating = value;
			// TODO: add assertions to method PopularimeterFrameTest.RatingSetTest(PopularimeterFrame, Byte)
		}

		/// <summary>Test stub for set_User(String)</summary>
		[PexMethod]
		public void UserSetTest([PexAssumeUnderTest]PopularimeterFrame target, string value)
		{
			target.User = value;
			// TODO: add assertions to method PopularimeterFrameTest.UserSetTest(PopularimeterFrame, String)
		}
	}
}
