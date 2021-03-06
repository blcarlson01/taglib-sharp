using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for UniqueFileIdentifierFrame</summary>
    [TestClass]
    [PexClass(typeof(UniqueFileIdentifierFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UniqueFileIdentifierFrameTest
    {

		/// <summary>Test stub for .ctor(String, ByteVector)</summary>
		[PexMethod]
		public UniqueFileIdentifierFrame ConstructorTest(string owner, ByteVector identifier)
		{
			UniqueFileIdentifierFrame target = new UniqueFileIdentifierFrame(owner, identifier);
			return target;
			// TODO: add assertions to method UniqueFileIdentifierFrameTest.ConstructorTest(String, ByteVector)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public UniqueFileIdentifierFrame ConstructorTest01(string owner)
		{
			UniqueFileIdentifierFrame target = new UniqueFileIdentifierFrame(owner);
			return target;
			// TODO: add assertions to method UniqueFileIdentifierFrameTest.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public UniqueFileIdentifierFrame ConstructorTest02(ByteVector data, byte version)
		{
			UniqueFileIdentifierFrame target = new UniqueFileIdentifierFrame(data, version);
			return target;
			// TODO: add assertions to method UniqueFileIdentifierFrameTest.ConstructorTest02(ByteVector, Byte)
		}

		

		/// <summary>Test stub for Clone()</summary>
		[PexMethod]
		public Frame CloneTest([PexAssumeUnderTest]UniqueFileIdentifierFrame target)
		{
			Frame result = target.Clone();
			return result;
			// TODO: add assertions to method UniqueFileIdentifierFrameTest.CloneTest(UniqueFileIdentifierFrame)
		}

		/// <summary>Test stub for Get(Tag, String, Boolean)</summary>
		[PexMethod]
		public UniqueFileIdentifierFrame GetTest(
			Tag tag,
			string owner,
			bool create
		)
		{
			UniqueFileIdentifierFrame result = UniqueFileIdentifierFrame.Get(tag, owner, create);
			return result;
			// TODO: add assertions to method UniqueFileIdentifierFrameTest.GetTest(Tag, String, Boolean)
		}

		/// <summary>Test stub for get_Identifier()</summary>
		[PexMethod]
		public ByteVector IdentifierGetTest([PexAssumeUnderTest]UniqueFileIdentifierFrame target)
		{
			ByteVector result = target.Identifier;
			return result;
			// TODO: add assertions to method UniqueFileIdentifierFrameTest.IdentifierGetTest(UniqueFileIdentifierFrame)
		}

		/// <summary>Test stub for get_Owner()</summary>
		[PexMethod]
		public string OwnerGetTest([PexAssumeUnderTest]UniqueFileIdentifierFrame target)
		{
			string result = target.Owner;
			return result;
			// TODO: add assertions to method UniqueFileIdentifierFrameTest.OwnerGetTest(UniqueFileIdentifierFrame)
		}

		/// <summary>Test stub for set_Identifier(ByteVector)</summary>
		[PexMethod]
		public void IdentifierSetTest([PexAssumeUnderTest]UniqueFileIdentifierFrame target, ByteVector value)
		{
			target.Identifier = value;
			// TODO: add assertions to method UniqueFileIdentifierFrameTest.IdentifierSetTest(UniqueFileIdentifierFrame, ByteVector)
		}
	}
}
