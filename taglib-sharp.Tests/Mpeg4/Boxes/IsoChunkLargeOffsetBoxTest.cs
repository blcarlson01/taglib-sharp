using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoChunkLargeOffsetBox</summary>
    [TestClass]
    [PexClass(typeof(IsoChunkLargeOffsetBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoChunkLargeOffsetBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoChunkLargeOffsetBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoChunkLargeOffsetBox target = new IsoChunkLargeOffsetBox(header, file, handler);
			return target;
			// TODO: add assertions to method IsoChunkLargeOffsetBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for Overwrite(File, Int64, Int64)</summary>
		[PexMethod]
		public void OverwriteTest(
			[PexAssumeUnderTest]IsoChunkLargeOffsetBox target,
			File file,
			long sizeDifference,
			long after
		)
		{
			target.Overwrite(file, sizeDifference, after);
			// TODO: add assertions to method IsoChunkLargeOffsetBoxTest.OverwriteTest(IsoChunkLargeOffsetBox, File, Int64, Int64)
		}

		/// <summary>Test stub for Render(Int64, Int64)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]IsoChunkLargeOffsetBox target,
			long sizeDifference,
			long after
		)
		{
			ByteVector result = target.Render(sizeDifference, after);
			return result;
			// TODO: add assertions to method IsoChunkLargeOffsetBoxTest.RenderTest(IsoChunkLargeOffsetBox, Int64, Int64)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]IsoChunkLargeOffsetBox target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method IsoChunkLargeOffsetBoxTest.DataGetTest(IsoChunkLargeOffsetBox)
		}

		/// <summary>Test stub for get_Offsets()</summary>
		[PexMethod]
		public ulong[] OffsetsGetTest([PexAssumeUnderTest]IsoChunkLargeOffsetBox target)
		{
			ulong[] result = target.Offsets;
			return result;
			// TODO: add assertions to method IsoChunkLargeOffsetBoxTest.OffsetsGetTest(IsoChunkLargeOffsetBox)
		}
	}
}
