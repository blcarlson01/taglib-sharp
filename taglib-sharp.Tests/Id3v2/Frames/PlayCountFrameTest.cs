using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for PlayCountFrame</summary>
    [TestClass]
    [PexClass(typeof(PlayCountFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PlayCountFrameTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public PlayCountFrame ConstructorTest()
		{
			PlayCountFrame target = new PlayCountFrame();
			return target;
			// TODO: add assertions to method PlayCountFrameTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public PlayCountFrame ConstructorTest01(ByteVector data, byte version)
		{
			PlayCountFrame target = new PlayCountFrame(data, version);
			return target;
			// TODO: add assertions to method PlayCountFrameTest.ConstructorTest01(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]PlayCountFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method PlayCountFrameTest.CloneTest(PlayCountFrame)
		}

		/// <summary>Test stub for Get(Tag, Boolean)</summary>
		[PexMethod]
		public PlayCountFrame GetTest(Tag tag, bool create)
		{
			PlayCountFrame result = PlayCountFrame.Get(tag, create);
			return result;
			// TODO: add assertions to method PlayCountFrameTest.GetTest(Tag, Boolean)
		}

		/// <summary>Test stub for get_PlayCount()</summary>
		[PexMethod]
		public ulong PlayCountGetTest([PexAssumeUnderTest]PlayCountFrame target)
		{
			ulong result = target.PlayCount;
			return result;
			// TODO: add assertions to method PlayCountFrameTest.PlayCountGetTest(PlayCountFrame)
		}

		/// <summary>Test stub for set_PlayCount(UInt64)</summary>
		[PexMethod]
		public void PlayCountSetTest([PexAssumeUnderTest]PlayCountFrame target, ulong value)
		{
			target.PlayCount = value;
			// TODO: add assertions to method PlayCountFrameTest.PlayCountSetTest(PlayCountFrame, UInt64)
		}
	}
}
