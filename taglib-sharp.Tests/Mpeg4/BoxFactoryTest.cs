using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for BoxFactory</summary>
    [TestClass]
    [PexClass(typeof(BoxFactory))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class BoxFactoryTest
    {

		

		/// <summary>Test stub for CreateBox(File, Int64, IsoHandlerBox)</summary>
		[PexMethod]
		public Box CreateBoxTest01(
			File file,
			long position,
			IsoHandlerBox handler
		)
		{
			Box result = BoxFactory.CreateBox(file, position, handler);
			return result;
			// TODO: add assertions to method BoxFactoryTest.CreateBoxTest01(File, Int64, IsoHandlerBox)
		}

		/// <summary>Test stub for CreateBox(File, Int64)</summary>
		[PexMethod]
		public Box CreateBoxTest02(File file, long position)
		{
			Box result = BoxFactory.CreateBox(file, position);
			return result;
			// TODO: add assertions to method BoxFactoryTest.CreateBoxTest02(File, Int64)
		}

		/// <summary>Test stub for CreateBox(File, BoxHeader, IsoHandlerBox)</summary>
		[PexMethod]
		public Box CreateBoxTest03(
			File file,
			BoxHeader header,
			IsoHandlerBox handler
		)
		{
			Box result = BoxFactory.CreateBox(file, header, handler);
			return result;
			// TODO: add assertions to method BoxFactoryTest.CreateBoxTest03(File, BoxHeader, IsoHandlerBox)
		}

		/// <summary>Test stub for CreateBox(File, BoxHeader)</summary>
		[PexMethod]
		public Box CreateBoxTest04(File file, BoxHeader header)
		{
			Box result = BoxFactory.CreateBox(file, header);
			return result;
			// TODO: add assertions to method BoxFactoryTest.CreateBoxTest04(File, BoxHeader)
		}
	}
}
