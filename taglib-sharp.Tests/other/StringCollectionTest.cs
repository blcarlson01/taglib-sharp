using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for StringCollection</summary>
    [TestClass]
    [PexClass(typeof(StringCollection))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StringCollectionTest
    {

		/// <summary>Test stub for .ctor(StringCollection)</summary>
		[PexMethod]
		public StringCollection ConstructorTest(StringCollection values)
		{
			StringCollection target = new StringCollection(values);
			return target;
			// TODO: add assertions to method StringCollectionTest.ConstructorTest(StringCollection)
		}

		/// <summary>Test stub for .ctor(String[])</summary>
		[PexMethod]
		public StringCollection ConstructorTest01(string[] values)
		{
			StringCollection target = new StringCollection(values);
			return target;
			// TODO: add assertions to method StringCollectionTest.ConstructorTest01(String[])
		}

		/// <summary>Test stub for .ctor(ByteVectorCollection, StringType)</summary>
		[PexMethod]
		public StringCollection ConstructorTest02(ByteVectorCollection vectorList, StringType type)
		{
			StringCollection target = new StringCollection(vectorList, type);
			return target;
			// TODO: add assertions to method StringCollectionTest.ConstructorTest02(ByteVectorCollection, StringType)
		}

		/// <summary>Test stub for .ctor(ByteVectorCollection)</summary>
		[PexMethod]
		public StringCollection ConstructorTest03(ByteVectorCollection vectorList)
		{
			StringCollection target = new StringCollection(vectorList);
			return target;
			// TODO: add assertions to method StringCollectionTest.ConstructorTest03(ByteVectorCollection)
		}

		/// <summary>Test stub for Split(String, String)</summary>
		[PexMethod]
		public StringCollection SplitTest(string value, string pattern)
		{
			StringCollection result = StringCollection.Split(value, pattern);
			return result;
			// TODO: add assertions to method StringCollectionTest.SplitTest(String, String)
		}
	}
}
