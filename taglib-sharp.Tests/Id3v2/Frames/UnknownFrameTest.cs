using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for UnknownFrame</summary>
    [TestClass]
    [PexClass(typeof(UnknownFrame))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnknownFrameTest
    {

		/// <summary>Test stub for .ctor(ByteVector, ByteVector)</summary>
		[PexMethod]
		public UnknownFrame ConstructorTest(ByteVector type, ByteVector data)
		{
			UnknownFrame target = new UnknownFrame(type, data);
			return target;
			// TODO: add assertions to method UnknownFrameTest.ConstructorTest(ByteVector, ByteVector)
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public UnknownFrame ConstructorTest01(ByteVector type)
		{
			UnknownFrame target = new UnknownFrame(type);
			return target;
			// TODO: add assertions to method UnknownFrameTest.ConstructorTest01(ByteVector)
		}

		/// <summary>Test stub for .ctor(ByteVector, Byte)</summary>
		[PexMethod]
		public UnknownFrame ConstructorTest02(ByteVector data, byte version)
		{
			UnknownFrame target = new UnknownFrame(data, version);
			return target;
			// TODO: add assertions to method UnknownFrameTest.ConstructorTest02(ByteVector, Byte)
		}

	

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]UnknownFrame target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method UnknownFrameTest.ToStringTest(UnknownFrame)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]UnknownFrame target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method UnknownFrameTest.DataGetTest(UnknownFrame)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]UnknownFrame target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method UnknownFrameTest.DataSetTest(UnknownFrame, ByteVector)
		}
	}
}
