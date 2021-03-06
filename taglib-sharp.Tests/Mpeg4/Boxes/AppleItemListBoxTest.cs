using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for AppleItemListBox</summary>
    [TestClass]
    [PexClass(typeof(AppleItemListBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AppleItemListBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public AppleItemListBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			AppleItemListBox target = new AppleItemListBox(header, file, handler);
			return target;
			// TODO: add assertions to method AppleItemListBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public AppleItemListBox ConstructorTest01()
		{
			AppleItemListBox target = new AppleItemListBox();
			return target;
			// TODO: add assertions to method AppleItemListBoxTest.ConstructorTest01()
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public IEnumerable<Box> ChildrenGetTest([PexAssumeUnderTest]AppleItemListBox target)
		{
			IEnumerable<Box> result = target.Children;
			return result;
			// TODO: add assertions to method AppleItemListBoxTest.ChildrenGetTest(AppleItemListBox)
		}
	}
}
