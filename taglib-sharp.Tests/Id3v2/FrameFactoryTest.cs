using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Id3v2;

namespace TagLib.Id3v2.Tests
{
    /// <summary>This class contains parameterized unit tests for FrameFactory</summary>
    [TestClass]
    [PexClass(typeof(FrameFactory))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FrameFactoryTest
    {

		/// <summary>Test stub for AddFrameCreator(FrameCreator)</summary>
		[PexMethod]
		public void AddFrameCreatorTest(FrameFactory.FrameCreator creator)
		{
			FrameFactory.AddFrameCreator(creator);
			// TODO: add assertions to method FrameFactoryTest.AddFrameCreatorTest(FrameCreator)
		}

		/// <summary>Test stub for CreateFrame(ByteVector, Int32&amp;, Byte, Boolean)</summary>
		[PexMethod]
		public Frame CreateFrameTest(
			ByteVector data,
			ref int offset,
			byte version,
			bool alreadyUnsynched
		)
		{
			Frame result = FrameFactory.CreateFrame(data, ref offset, version, alreadyUnsynched);
			return result;
			// TODO: add assertions to method FrameFactoryTest.CreateFrameTest(ByteVector, Int32&, Byte, Boolean)
		}
	}
}
