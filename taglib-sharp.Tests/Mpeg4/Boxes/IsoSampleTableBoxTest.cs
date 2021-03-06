using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoSampleTableBox</summary>
    [TestClass]
    [PexClass(typeof(IsoSampleTableBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoSampleTableBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoSampleTableBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoSampleTableBox target = new IsoSampleTableBox(header, file, handler);
			return target;
			// TODO: add assertions to method IsoSampleTableBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public IEnumerable<Box> ChildrenGetTest([PexAssumeUnderTest]IsoSampleTableBox target)
		{
			IEnumerable<Box> result = target.Children;
			return result;
			// TODO: add assertions to method IsoSampleTableBoxTest.ChildrenGetTest(IsoSampleTableBox)
		}
	}
}
