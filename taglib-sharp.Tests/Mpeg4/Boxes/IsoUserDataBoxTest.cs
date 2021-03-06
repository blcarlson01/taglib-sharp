using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoUserDataBox</summary>
    [TestClass]
    [PexClass(typeof(IsoUserDataBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoUserDataBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoUserDataBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoUserDataBox target = new IsoUserDataBox(header, file, handler);
			return target;
			// TODO: add assertions to method IsoUserDataBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public IsoUserDataBox ConstructorTest01()
		{
			IsoUserDataBox target = new IsoUserDataBox();
			return target;
			// TODO: add assertions to method IsoUserDataBoxTest.ConstructorTest01()
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public IEnumerable<Box> ChildrenGetTest([PexAssumeUnderTest]IsoUserDataBox target)
		{
			IEnumerable<Box> result = target.Children;
			return result;
			// TODO: add assertions to method IsoUserDataBoxTest.ChildrenGetTest(IsoUserDataBox)
		}

		/// <summary>Test stub for get_ParentTree()</summary>
		[PexMethod]
		public BoxHeader[] ParentTreeGetTest([PexAssumeUnderTest]IsoUserDataBox target)
		{
			BoxHeader[] result = target.ParentTree;
			return result;
			// TODO: add assertions to method IsoUserDataBoxTest.ParentTreeGetTest(IsoUserDataBox)
		}

		/// <summary>Test stub for set_ParentTree(BoxHeader[])</summary>
		[PexMethod]
		public void ParentTreeSetTest([PexAssumeUnderTest]IsoUserDataBox target, BoxHeader[] value)
		{
			target.ParentTree = value;
			// TODO: add assertions to method IsoUserDataBoxTest.ParentTreeSetTest(IsoUserDataBox, BoxHeader[])
		}
	}
}
