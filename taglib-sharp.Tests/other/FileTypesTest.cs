using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for FileTypes</summary>
    [TestClass]
    [PexClass(typeof(FileTypes))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FileTypesTest
    {

	

		/// <summary>Test stub for Register(Type)</summary>
		[PexMethod]
		public void RegisterTest(Type type)
		{
			FileTypes.Register(type);
			// TODO: add assertions to method FileTypesTest.RegisterTest(Type)
		}

		/// <summary>Test stub for get_AvailableTypes()</summary>
		[PexMethod]
		public IDictionary<string, Type> AvailableTypesGetTest()
		{
			IDictionary<string, Type> result = FileTypes.AvailableTypes;
			return result;
			// TODO: add assertions to method FileTypesTest.AvailableTypesGetTest()
		}
	}
}
