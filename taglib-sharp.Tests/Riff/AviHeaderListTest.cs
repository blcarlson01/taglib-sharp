using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;

namespace TagLib.Riff.Tests
{
    /// <summary>This class contains parameterized unit tests for AviHeaderList</summary>
    [TestClass]
    [PexClass(typeof(AviHeaderList))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AviHeaderListTest
    {

		/// <summary>Test stub for .ctor(File, Int64, Int32)</summary>
		[PexMethod]
		public AviHeaderList ConstructorTest(
			File file,
			long position,
			int length
		)
		{
			AviHeaderList target = new AviHeaderList(file, position, length);
			return target;
			// TODO: add assertions to method AviHeaderListTest.ConstructorTest(File, Int64, Int32)
		}

		/// <summary>Test stub for get_Codecs()</summary>
		[PexMethod]
		public ICodec[] CodecsGetTest([PexAssumeUnderTest]AviHeaderList target)
		{
			ICodec[] result = target.Codecs;
			return result;
			// TODO: add assertions to method AviHeaderListTest.CodecsGetTest(AviHeaderList)
		}

		/// <summary>Test stub for get_Header()</summary>
		[PexMethod]
		public AviHeader HeaderGetTest([PexAssumeUnderTest]AviHeaderList target)
		{
			AviHeader result = target.Header;
			return result;
			// TODO: add assertions to method AviHeaderListTest.HeaderGetTest(AviHeaderList)
		}
	}
}
