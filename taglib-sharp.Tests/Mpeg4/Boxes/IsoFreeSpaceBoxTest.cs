using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoFreeSpaceBox</summary>
    [TestClass]
    [PexClass(typeof(IsoFreeSpaceBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoFreeSpaceBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoFreeSpaceBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoFreeSpaceBox target = new IsoFreeSpaceBox(header, file, handler);
			return target;
			// TODO: add assertions to method IsoFreeSpaceBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for .ctor(Int64)</summary>
		[PexMethod]
		public IsoFreeSpaceBox ConstructorTest01(long padding)
		{
			IsoFreeSpaceBox target = new IsoFreeSpaceBox(padding);
			return target;
			// TODO: add assertions to method IsoFreeSpaceBoxTest.ConstructorTest01(Int64)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]IsoFreeSpaceBox target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method IsoFreeSpaceBoxTest.DataGetTest(IsoFreeSpaceBox)
		}

		/// <summary>Test stub for get_PaddingSize()</summary>
		[PexMethod]
		public long PaddingSizeGetTest([PexAssumeUnderTest]IsoFreeSpaceBox target)
		{
			long result = target.PaddingSize;
			return result;
			// TODO: add assertions to method IsoFreeSpaceBoxTest.PaddingSizeGetTest(IsoFreeSpaceBox)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]IsoFreeSpaceBox target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method IsoFreeSpaceBoxTest.DataSetTest(IsoFreeSpaceBox, ByteVector)
		}

		/// <summary>Test stub for set_PaddingSize(Int64)</summary>
		[PexMethod]
		public void PaddingSizeSetTest([PexAssumeUnderTest]IsoFreeSpaceBox target, long value)
		{
			target.PaddingSize = value;
			// TODO: add assertions to method IsoFreeSpaceBoxTest.PaddingSizeSetTest(IsoFreeSpaceBox, Int64)
		}
	}
}
