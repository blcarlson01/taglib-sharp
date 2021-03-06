using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Jpeg;

namespace TagLib.Jpeg.Tests
{
    /// <summary>This class contains parameterized unit tests for JpegCommentTag</summary>
    [TestClass]
    [PexClass(typeof(JpegCommentTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class JpegCommentTagTest
    {

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public JpegCommentTag ConstructorTest(string value)
		{
			JpegCommentTag target = new JpegCommentTag(value);
			return target;
			// TODO: add assertions to method JpegCommentTagTest.ConstructorTest(String)
		}

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public JpegCommentTag ConstructorTest01()
		{
			JpegCommentTag target = new JpegCommentTag();
			return target;
			// TODO: add assertions to method JpegCommentTagTest.ConstructorTest01()
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]JpegCommentTag target)
		{
			target.Clear();
			// TODO: add assertions to method JpegCommentTagTest.ClearTest(JpegCommentTag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]JpegCommentTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method JpegCommentTagTest.CommentGetTest(JpegCommentTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]JpegCommentTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method JpegCommentTagTest.TagTypesGetTest(JpegCommentTag)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]JpegCommentTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method JpegCommentTagTest.CommentSetTest(JpegCommentTag, String)
		}
	}
}
