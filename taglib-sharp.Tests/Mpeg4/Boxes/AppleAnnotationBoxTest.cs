using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for AppleAnnotationBox</summary>
    [TestClass]
    [PexClass(typeof(AppleAnnotationBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AppleAnnotationBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public AppleAnnotationBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			AppleAnnotationBox target = new AppleAnnotationBox(header, file, handler);
			return target;
			// TODO: add assertions to method AppleAnnotationBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public AppleAnnotationBox ConstructorTest01(ByteVector type)
		{
			AppleAnnotationBox target = new AppleAnnotationBox(type);
			return target;
			// TODO: add assertions to method AppleAnnotationBoxTest.ConstructorTest01(ByteVector)
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public IEnumerable<Box> ChildrenGetTest([PexAssumeUnderTest]AppleAnnotationBox target)
		{
			IEnumerable<Box> result = target.Children;
			return result;
			// TODO: add assertions to method AppleAnnotationBoxTest.ChildrenGetTest(AppleAnnotationBox)
		}
	}
}
