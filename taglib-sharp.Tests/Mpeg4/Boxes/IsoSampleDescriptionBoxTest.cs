using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoSampleDescriptionBox</summary>
    [TestClass]
    [PexClass(typeof(IsoSampleDescriptionBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoSampleDescriptionBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoSampleDescriptionBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoSampleDescriptionBox target = new IsoSampleDescriptionBox(header, file, handler);
			return target;
			// TODO: add assertions to method IsoSampleDescriptionBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_Children()</summary>
		[PexMethod]
		public IEnumerable<Box> ChildrenGetTest([PexAssumeUnderTest]IsoSampleDescriptionBox target)
		{
			IEnumerable<Box> result = target.Children;
			return result;
			// TODO: add assertions to method IsoSampleDescriptionBoxTest.ChildrenGetTest(IsoSampleDescriptionBox)
		}

		/// <summary>Test stub for get_EntryCount()</summary>
		[PexMethod]
		public uint EntryCountGetTest([PexAssumeUnderTest]IsoSampleDescriptionBox target)
		{
			uint result = target.EntryCount;
			return result;
			// TODO: add assertions to method IsoSampleDescriptionBoxTest.EntryCountGetTest(IsoSampleDescriptionBox)
		}
	}
}
