using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg4;

namespace TagLib.Mpeg4.Tests
{
    /// <summary>This class contains parameterized unit tests for IsoHandlerBox</summary>
    [TestClass]
    [PexClass(typeof(IsoHandlerBox))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IsoHandlerBoxTest
    {

		/// <summary>Test stub for .ctor(BoxHeader, File, IsoHandlerBox)</summary>
		[PexMethod]
		public IsoHandlerBox ConstructorTest(
			BoxHeader header,
			File file,
			IsoHandlerBox handler
		)
		{
			IsoHandlerBox target = new IsoHandlerBox(header, file, handler);
			return target;
			// TODO: add assertions to method IsoHandlerBoxTest.ConstructorTest(BoxHeader, File, IsoHandlerBox)
		}

		/// <summary>Test stub for .ctor(ByteVector, String)</summary>
		[PexMethod]
		public IsoHandlerBox ConstructorTest01(ByteVector handlerType, string name)
		{
			IsoHandlerBox target = new IsoHandlerBox(handlerType, name);
			return target;
			// TODO: add assertions to method IsoHandlerBoxTest.ConstructorTest01(ByteVector, String)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]IsoHandlerBox target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method IsoHandlerBoxTest.DataGetTest(IsoHandlerBox)
		}

		/// <summary>Test stub for get_HandlerType()</summary>
		[PexMethod]
		public ByteVector HandlerTypeGetTest([PexAssumeUnderTest]IsoHandlerBox target)
		{
			ByteVector result = target.HandlerType;
			return result;
			// TODO: add assertions to method IsoHandlerBoxTest.HandlerTypeGetTest(IsoHandlerBox)
		}

		/// <summary>Test stub for get_Name()</summary>
		[PexMethod]
		public string NameGetTest([PexAssumeUnderTest]IsoHandlerBox target)
		{
			string result = target.Name;
			return result;
			// TODO: add assertions to method IsoHandlerBoxTest.NameGetTest(IsoHandlerBox)
		}
	}
}
