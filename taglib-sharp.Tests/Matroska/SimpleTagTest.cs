using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for SimpleTag</summary>
    [TestClass]
    [PexClass(typeof(SimpleTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SimpleTagTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public SimpleTag ConstructorTest()
		{
			SimpleTag target = new SimpleTag();
			return target;
			// TODO: add assertions to method SimpleTagTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public SimpleTag ConstructorTest01(ByteVector value)
		{
			SimpleTag target = new SimpleTag(value);
			return target;
			// TODO: add assertions to method SimpleTagTest.ConstructorTest01(ByteVector)
		}

		/// <summary>Test stub for get_TagLanguage()</summary>
		[PexMethod]
		public string TagLanguageGetTest([PexAssumeUnderTest]SimpleTag target)
		{
			string result = target.TagLanguage;
			return result;
			// TODO: add assertions to method SimpleTagTest.TagLanguageGetTest(SimpleTag)
		}

		/// <summary>Test stub for get_Value()</summary>
		[PexMethod]
		public ByteVector ValueGetTest([PexAssumeUnderTest]SimpleTag target)
		{
			ByteVector result = target.Value;
			return result;
			// TODO: add assertions to method SimpleTagTest.ValueGetTest(SimpleTag)
		}

		/// <summary>Test stub for op_Implicit(SimpleTag)</summary>
		[PexMethod]
		public string op_ImplicitTest(SimpleTag v)
		{
			string result = (string)v;
			return result;
			// TODO: add assertions to method SimpleTagTest.op_ImplicitTest(SimpleTag)
		}

		/// <summary>Test stub for set_TagLanguage(String)</summary>
		[PexMethod]
		public void TagLanguageSetTest([PexAssumeUnderTest]SimpleTag target, string value)
		{
			target.TagLanguage = value;
			// TODO: add assertions to method SimpleTagTest.TagLanguageSetTest(SimpleTag, String)
		}

		/// <summary>Test stub for set_Value(ByteVector)</summary>
		[PexMethod]
		public void ValueSetTest([PexAssumeUnderTest]SimpleTag target, ByteVector value)
		{
			target.Value = value;
			// TODO: add assertions to method SimpleTagTest.ValueSetTest(SimpleTag, ByteVector)
		}
	}
}
