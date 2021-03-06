using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoChunkOffsetBox</summary>
    [TestClass]
    [PexClass(typeof(IsoChunkOffsetBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoChunkOffsetBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoChunkOffsetBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoChunkOffsetBox target = new IsoChunkOffsetBox(header, file, handler);
			return target;
			// TODO: add assertions to method IsoChunkOffsetBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for Overwrite(File, Int64, Int64)</summary>
		[PexMethod]
		public void OverwriteTest(
			[PexAssumeUnderTest]IsoChunkOffsetBox target,
			File file,
			long sizeDifference,
			long after
		)
		{
			target.Overwrite(file, sizeDifference, after);
			// TODO: add assertions to method IsoChunkOffsetBoxTest.OverwriteTest(IsoChunkOffsetBox, File, Int64, Int64)
		}

		/// <summary>Test stub for Render(Int64, Int64)</summary>
		[PexMethod]
		public ByteVector RenderTest(
			[PexAssumeUnderTest]IsoChunkOffsetBox target,
			long sizeDifference,
			long after
		)
		{
			ByteVector result = target.Render(sizeDifference, after);
			return result;
			// TODO: add assertions to method IsoChunkOffsetBoxTest.RenderTest(IsoChunkOffsetBox, Int64, Int64)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]IsoChunkOffsetBox target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method IsoChunkOffsetBoxTest.DataGetTest(IsoChunkOffsetBox)
		}

		/// <summary>Test stub for get_Offsets()</summary>
		[PexMethod]
		public uint[] OffsetsGetTest([PexAssumeUnderTest]IsoChunkOffsetBox target)
		{
			uint[] result = target.Offsets;
			return result;
			// TODO: add assertions to method IsoChunkOffsetBoxTest.OffsetsGetTest(IsoChunkOffsetBox)
		}
	}
}
