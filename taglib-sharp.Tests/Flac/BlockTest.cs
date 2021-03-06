using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Flac;

namespace TagLib.Flac.Tests
{
    /// <summary>This class contains parameterized unit tests for Block</summary>
    [TestClass]
    [PexClass(typeof(Block))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BlockTest
    {

		/// <summary>Test stub for .ctor(BlockHeader, ByteVector)</summary>
		[PexMethod]
		public Block ConstructorTest(BlockHeader header, ByteVector data)
		{
			Block target = new Block(header, data);
			return target;
			// TODO: add assertions to method BlockTest.ConstructorTest(BlockHeader, ByteVector)
		}

		/// <summary>Test stub for .ctor(BlockType, ByteVector)</summary>
		[PexMethod]
		public Block ConstructorTest01(BlockType type, ByteVector data)
		{
			Block target = new Block(type, data);
			return target;
			// TODO: add assertions to method BlockTest.ConstructorTest01(BlockType, ByteVector)
		}

		/// <summary>Test stub for Render(Boolean)</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]Block target, bool isLastBlock)
		{
			ByteVector result = target.Render(isLastBlock);
			return result;
			// TODO: add assertions to method BlockTest.RenderTest(Block, Boolean)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]Block target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method BlockTest.DataGetTest(Block)
		}

		/// <summary>Test stub for get_DataSize()</summary>
		[PexMethod]
		public uint DataSizeGetTest([PexAssumeUnderTest]Block target)
		{
			uint result = target.DataSize;
			return result;
			// TODO: add assertions to method BlockTest.DataSizeGetTest(Block)
		}

		/// <summary>Test stub for get_IsLastBlock()</summary>
		[PexMethod]
		public bool IsLastBlockGetTest([PexAssumeUnderTest]Block target)
		{
			bool result = target.IsLastBlock;
			return result;
			// TODO: add assertions to method BlockTest.IsLastBlockGetTest(Block)
		}

		/// <summary>Test stub for get_TotalSize()</summary>
		[PexMethod]
		public uint TotalSizeGetTest([PexAssumeUnderTest]Block target)
		{
			uint result = target.TotalSize;
			return result;
			// TODO: add assertions to method BlockTest.TotalSizeGetTest(Block)
		}

		/// <summary>Test stub for get_Type()</summary>
		[PexMethod]
		public BlockType TypeGetTest([PexAssumeUnderTest]Block target)
		{
			BlockType result = target.Type;
			return result;
			// TODO: add assertions to method BlockTest.TypeGetTest(Block)
		}
	}
}
