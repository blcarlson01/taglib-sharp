using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for CorruptFileException</summary>
    [TestClass]
    [PexClass(typeof(CorruptFileException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CorruptFileExceptionTest
    {

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public CorruptFileException ConstructorTest(string message)
		{
			CorruptFileException target = new CorruptFileException(message);
			return target;
			// TODO: add assertions to method CorruptFileExceptionTest.ConstructorTest(String)
		}

		/// <summary>Test stub for .ctor(String, Exception)</summary>
		[PexMethod]
		public CorruptFileException ConstructorTest01(string message, Exception innerException)
		{
			CorruptFileException target = new CorruptFileException(message, innerException);
			return target;
			// TODO: add assertions to method CorruptFileExceptionTest.ConstructorTest01(String, Exception)
		}
	}
}
