using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg;

namespace TagLib.Ogg.Tests
{
    /// <summary>This class contains parameterized unit tests for Page</summary>
    [TestClass]
    [PexClass(typeof(Page))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PageTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public Page ConstructorTest(File file, long position)
		{
			Page target = new Page(file, position);
			return target;
			// TODO: add assertions to method PageTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for .ctor(ByteVectorCollection, PageHeader)</summary>
		[PexMethod]
		public Page ConstructorTest01(ByteVectorCollection packets, PageHeader header)
		{
			Page target = new Page(packets, header);
			return target;
			// TODO: add assertions to method PageTest.ConstructorTest01(ByteVectorCollection, PageHeader)
		}

		/// <summary>Test stub for OverwriteSequenceNumbers(File, Int64, IDictionary`2&lt;UInt32,Int32&gt;)</summary>
		[PexMethod]
		public void OverwriteSequenceNumbersTest(
			File file,
			long position,
			IDictionary<uint, int> shiftTable
		)
		{
			Page.OverwriteSequenceNumbers(file, position, shiftTable);
			// TODO: add assertions to method PageTest.OverwriteSequenceNumbersTest(File, Int64, IDictionary`2<UInt32,Int32>)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]Page target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method PageTest.RenderTest(Page)
		}

		/// <summary>Test stub for get_Header()</summary>
		[PexMethod]
		public PageHeader HeaderGetTest([PexAssumeUnderTest]Page target)
		{
			PageHeader result = target.Header;
			return result;
			// TODO: add assertions to method PageTest.HeaderGetTest(Page)
		}

		/// <summary>Test stub for get_Packets()</summary>
		[PexMethod]
		public ByteVector[] PacketsGetTest([PexAssumeUnderTest]Page target)
		{
			ByteVector[] result = target.Packets;
			return result;
			// TODO: add assertions to method PageTest.PacketsGetTest(Page)
		}

		/// <summary>Test stub for get_Size()</summary>
		[PexMethod]
		public uint SizeGetTest([PexAssumeUnderTest]Page target)
		{
			uint result = target.Size;
			return result;
			// TODO: add assertions to method PageTest.SizeGetTest(Page)
		}
	}
}
