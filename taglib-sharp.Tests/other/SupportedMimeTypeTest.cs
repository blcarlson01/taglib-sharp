using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for SupportedMimeType</summary>
    [TestClass]
    [PexClass(typeof(SupportedMimeType))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SupportedMimeTypeTest
    {

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public SupportedMimeType ConstructorTest(string mimetype)
		{
			SupportedMimeType target = new SupportedMimeType(mimetype);
			return target;
			// TODO: add assertions to method SupportedMimeTypeTest.ConstructorTest(String)
		}

		/// <summary>Test stub for .ctor(String, String)</summary>
		[PexMethod]
		public SupportedMimeType ConstructorTest01(string mimetype, string extension)
		{
			SupportedMimeType target = new SupportedMimeType(mimetype, extension);
			return target;
			// TODO: add assertions to method SupportedMimeTypeTest.ConstructorTest01(String, String)
		}

		/// <summary>Test stub for get_AllExtensions()</summary>
		[PexMethod]
		public IEnumerable<string> AllExtensionsGetTest()
		{
			IEnumerable<string> result = SupportedMimeType.AllExtensions;
			return result;
			// TODO: add assertions to method SupportedMimeTypeTest.AllExtensionsGetTest()
		}

		/// <summary>Test stub for get_AllMimeTypes()</summary>
		[PexMethod]
		public IEnumerable<string> AllMimeTypesGetTest()
		{
			IEnumerable<string> result = SupportedMimeType.AllMimeTypes;
			return result;
			// TODO: add assertions to method SupportedMimeTypeTest.AllMimeTypesGetTest()
		}

		/// <summary>Test stub for get_Extension()</summary>
		[PexMethod]
		public string ExtensionGetTest([PexAssumeUnderTest]SupportedMimeType target)
		{
			string result = target.Extension;
			return result;
			// TODO: add assertions to method SupportedMimeTypeTest.ExtensionGetTest(SupportedMimeType)
		}

		/// <summary>Test stub for get_MimeType()</summary>
		[PexMethod]
		public string MimeTypeGetTest([PexAssumeUnderTest]SupportedMimeType target)
		{
			string result = target.MimeType;
			return result;
			// TODO: add assertions to method SupportedMimeTypeTest.MimeTypeGetTest(SupportedMimeType)
		}
	}
}
