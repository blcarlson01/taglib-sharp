using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IIM;

namespace TagLib.IIM.Tests
{
    /// <summary>This class contains parameterized unit tests for IIMTag</summary>
    [TestClass]
    [PexClass(typeof(IIMTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IIMTagTest
    {

		

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]IIMTag target)
		{
			target.Clear();
			// TODO: add assertions to method IIMTagTest.ClearTest(IIMTag)
		}

		/// <summary>Test stub for get_Keywords()</summary>
		[PexMethod]
		public string[] KeywordsGetTest([PexAssumeUnderTest]IIMTag target)
		{
			string[] result = target.Keywords;
			return result;
			// TODO: add assertions to method IIMTagTest.KeywordsGetTest(IIMTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]IIMTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method IIMTagTest.TagTypesGetTest(IIMTag)
		}
	}
}
