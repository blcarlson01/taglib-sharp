using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Aac;

namespace TagLib.Aac.Tests
{
    /// <summary>This class contains parameterized unit tests for BitStream</summary>
    [TestClass]
    [PexClass(typeof(BitStream))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BitStreamTest
    {

		/// <summary>Test stub for .ctor(Byte[])</summary>
		[PexMethod]
		public BitStream ConstructorTest(byte[] buffer)
		{
			BitStream target = new BitStream(buffer);

			PexAssert.IsNotNull(target);
			return target;
			// TODO: add assertions to method BitStreamTest.ConstructorTest(Byte[])
		}

		/// <summary>Test stub for ReadInt32(Int32)</summary>
		[PexMethod]
		public int ReadInt32Test([PexAssumeUnderTest]BitStream target, int numberOfBits)
		{
			int result = target.ReadInt32(numberOfBits);
			return result;
			// TODO: add assertions to method BitStreamTest.ReadInt32Test(BitStream, Int32)
		}
	}
}
