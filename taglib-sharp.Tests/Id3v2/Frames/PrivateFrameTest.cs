using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for PrivateFrame</summary>
    [TestClass]
    [PexClass(typeof(PrivateFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PrivateFrameTest
    {

		/// <summary>Test stub for .ctor(String, ByteVector)</summary>
		[PexMethod]
		public PrivateFrame ConstructorTest(string owner, ByteVector data)
		{
			PrivateFrame target = new PrivateFrame(owner, data);
			return target;
			// TODO: add assertions to method PrivateFrameTest.ConstructorTest(String, ByteVector)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public PrivateFrame ConstructorTest01(string owner)
		{
			PrivateFrame target = new PrivateFrame(owner);
			return target;
			// TODO: add assertions to method PrivateFrameTest.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public PrivateFrame ConstructorTest02(ByteVector data, byte version)
		{
			PrivateFrame target = new PrivateFrame(data, version);
			return target;
			// TODO: add assertions to method PrivateFrameTest.ConstructorTest02(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]PrivateFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method PrivateFrameTest.CloneTest(PrivateFrame)
		}

		/// <summary>Test stub for Get(Tag, String, Boolean)</summary>
		[PexMethod]
		public PrivateFrame GetTest(
			Tag tag,
			string owner,
			bool create
		)
		{
			PrivateFrame result = PrivateFrame.Get(tag, owner, create);
			return result;
			// TODO: add assertions to method PrivateFrameTest.GetTest(Tag, String, Boolean)
		}

		/// <summary>Test stub for get_Owner()</summary>
		[PexMethod]
		public string OwnerGetTest([PexAssumeUnderTest]PrivateFrame target)
		{
			string result = target.Owner;
			return result;
			// TODO: add assertions to method PrivateFrameTest.OwnerGetTest(PrivateFrame)
		}

		/// <summary>Test stub for get_PrivateData()</summary>
		[PexMethod]
		public ByteVector PrivateDataGetTest([PexAssumeUnderTest]PrivateFrame target)
		{
			ByteVector result = target.PrivateData;
			return result;
			// TODO: add assertions to method PrivateFrameTest.PrivateDataGetTest(PrivateFrame)
		}

		/// <summary>Test stub for set_PrivateData(ByteVector)</summary>
		[PexMethod]
		public void PrivateDataSetTest([PexAssumeUnderTest]PrivateFrame target, ByteVector value)
		{
			target.PrivateData = value;
			// TODO: add assertions to method PrivateFrameTest.PrivateDataSetTest(PrivateFrame, ByteVector)
		}
	}
}
