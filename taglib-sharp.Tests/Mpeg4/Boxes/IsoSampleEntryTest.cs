using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoSampleEntry</summary>
    [TestClass]
    [PexClass(typeof(IsoSampleEntry))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoSampleEntryTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoSampleEntry ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoSampleEntry target = new IsoSampleEntry(header, file, handler);
			return target;
			// TODO: add assertions to method IsoSampleEntryTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for get_DataReferenceIndex()</summary>
		[PexMethod]
		public ushort DataReferenceIndexGetTest([PexAssumeUnderTest]IsoSampleEntry target)
		{
			ushort result = target.DataReferenceIndex;
			return result;
			// TODO: add assertions to method IsoSampleEntryTest.DataReferenceIndexGetTest(IsoSampleEntry)
		}
	}
}
