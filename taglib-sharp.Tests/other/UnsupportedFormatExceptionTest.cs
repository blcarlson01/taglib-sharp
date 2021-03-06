using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for UnsupportedFormatException</summary>
    [TestClass]
    [PexClass(typeof(UnsupportedFormatException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnsupportedFormatExceptionTest
    {

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public UnsupportedFormatException ConstructorTest(string message)
		{
			UnsupportedFormatException target = new UnsupportedFormatException(message);
			return target;
			// TODO: add assertions to method UnsupportedFormatExceptionTest.ConstructorTest(String)
		}

		/// <summary>Test stub for .ctor(String, Exception)</summary>
		[PexMethod]
		public UnsupportedFormatException ConstructorTest01(string message, Exception innerException)
		{
			UnsupportedFormatException target = new UnsupportedFormatException(message, innerException);
			return target;
			// TODO: add assertions to method UnsupportedFormatExceptionTest.ConstructorTest01(String, Exception)
		}
	}
}
