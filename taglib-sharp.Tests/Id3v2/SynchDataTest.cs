using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for SynchData</summary>
    [TestClass]
    [PexClass(typeof(SynchData))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SynchDataTest
    {

		/// <summary>Test stub for FromUInt(UInt32)</summary>
		[PexMethod]
		public ByteVector FromUIntTest(uint value)
		{
			ByteVector result = SynchData.FromUInt(value);
			return result;
			// TODO: add assertions to method SynchDataTest.FromUIntTest(UInt32)
		}

		/// <summary>Test stub for ResynchByteVector(ByteVector)</summary>
		[PexMethod]
		public void ResynchByteVectorTest(ByteVector data)
		{
			SynchData.ResynchByteVector(data);
			// TODO: add assertions to method SynchDataTest.ResynchByteVectorTest(ByteVector)
		}

		/// <summary>Test stub for ToUInt(ByteVector)</summary>
		[PexMethod]
		public uint ToUIntTest(ByteVector data)
		{
			uint result = SynchData.ToUInt(data);
			return result;
			// TODO: add assertions to method SynchDataTest.ToUIntTest(ByteVector)
		}

		/// <summary>Test stub for UnsynchByteVector(ByteVector)</summary>
		[PexMethod]
		public void UnsynchByteVectorTest(ByteVector data)
		{
			SynchData.UnsynchByteVector(data);
			// TODO: add assertions to method SynchDataTest.UnsynchByteVectorTest(ByteVector)
		}
	}
}
