using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Gif;

namespace TagLib.Gif.Tests
{
    /// <summary>This class contains parameterized unit tests for GifCommentTag</summary>
    [TestClass]
    [PexClass(typeof(GifCommentTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GifCommentTagTest
    {

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public GifCommentTag ConstructorTest(string value)
		{
			GifCommentTag target = new GifCommentTag(value);
			return target;
			// TODO: add assertions to method GifCommentTagTest.ConstructorTest(String)
		}

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public GifCommentTag ConstructorTest01()
		{
			GifCommentTag target = new GifCommentTag();
			return target;
			// TODO: add assertions to method GifCommentTagTest.ConstructorTest01()
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]GifCommentTag target)
		{
			target.Clear();
			// TODO: add assertions to method GifCommentTagTest.ClearTest(GifCommentTag)
		}

		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]GifCommentTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method GifCommentTagTest.CommentGetTest(GifCommentTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]GifCommentTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method GifCommentTagTest.TagTypesGetTest(GifCommentTag)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]GifCommentTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method GifCommentTagTest.CommentSetTest(GifCommentTag, String)
		}
	}
}
