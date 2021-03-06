using TagLib;
using System.Collections;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Png;

namespace TagLib.Png.Tests
{
    /// <summary>This class contains parameterized unit tests for PngTag</summary>
    [TestClass]
    [PexClass(typeof(PngTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PngTagTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public PngTag ConstructorTest()
		{
			PngTag target = new PngTag();
			return target;
			// TODO: add assertions to method PngTagTest.ConstructorTest()
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]PngTag target)
		{
			target.Clear();
			// TODO: add assertions to method PngTagTest.ClearTest(PngTag)
		}

		/// <summary>Test stub for GetEnumerator()</summary>
		[PexMethod]
		public IEnumerator GetEnumeratorTest([PexAssumeUnderTest]PngTag target)
		{
			IEnumerator result = target.GetEnumerator();
			return result;
			// TODO: add assertions to method PngTagTest.GetEnumeratorTest(PngTag)
		}

		/// <summary>Test stub for GetKeyword(String)</summary>
		[PexMethod]
		public string GetKeywordTest([PexAssumeUnderTest]PngTag target, string keyword)
		{
			string result = target.GetKeyword(keyword);
			return result;
			// TODO: add assertions to method PngTagTest.GetKeywordTest(PngTag, String)
		}

		/// <summary>Test stub for SetKeyword(String, String)</summary>
		[PexMethod]
		public void SetKeywordTest(
			[PexAssumeUnderTest]PngTag target,
			string keyword,
			string value
		)
		{
			target.SetKeyword(keyword, value);
			// TODO: add assertions to method PngTagTest.SetKeywordTest(PngTag, String, String)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]PngTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method PngTagTest.CommentGetTest(PngTag)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]PngTag target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method PngTagTest.CopyrightGetTest(PngTag)
		}

		/// <summary>Test stub for get_Creator()</summary>
		[PexMethod]
		public string CreatorGetTest([PexAssumeUnderTest]PngTag target)
		{
			string result = target.Creator;
			return result;
			// TODO: add assertions to method PngTagTest.CreatorGetTest(PngTag)
		}

		/// <summary>Test stub for get_DateTime()</summary>
		[PexMethod]
		public DateTime? DateTimeGetTest([PexAssumeUnderTest]PngTag target)
		{
			DateTime? result = target.DateTime;
			return result;
			// TODO: add assertions to method PngTagTest.DateTimeGetTest(PngTag)
		}

		/// <summary>Test stub for get_Software()</summary>
		[PexMethod]
		public string SoftwareGetTest([PexAssumeUnderTest]PngTag target)
		{
			string result = target.Software;
			return result;
			// TODO: add assertions to method PngTagTest.SoftwareGetTest(PngTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]PngTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method PngTagTest.TagTypesGetTest(PngTag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]PngTag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method PngTagTest.TitleGetTest(PngTag)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]PngTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method PngTagTest.CommentSetTest(PngTag, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]PngTag target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method PngTagTest.CopyrightSetTest(PngTag, String)
		}

		/// <summary>Test stub for set_Creator(String)</summary>
		[PexMethod]
		public void CreatorSetTest([PexAssumeUnderTest]PngTag target, string value)
		{
			target.Creator = value;
			// TODO: add assertions to method PngTagTest.CreatorSetTest(PngTag, String)
		}

		/// <summary>Test stub for set_DateTime(Nullable`1&lt;DateTime&gt;)</summary>
		[PexMethod]
		public void DateTimeSetTest([PexAssumeUnderTest]PngTag target, DateTime? value)
		{
			target.DateTime = value;
			// TODO: add assertions to method PngTagTest.DateTimeSetTest(PngTag, Nullable`1<DateTime>)
		}

		/// <summary>Test stub for set_Software(String)</summary>
		[PexMethod]
		public void SoftwareSetTest([PexAssumeUnderTest]PngTag target, string value)
		{
			target.Software = value;
			// TODO: add assertions to method PngTagTest.SoftwareSetTest(PngTag, String)
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]PngTag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method PngTagTest.TitleSetTest(PngTag, String)
		}
	}
}
