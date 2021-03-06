using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Ogg;

namespace TagLib.Ogg.Tests
{
    /// <summary>This class contains parameterized unit tests for Paginator</summary>
    [TestClass]
    [PexClass(typeof(Paginator))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PaginatorTest
    {

		/// <summary>Test stub for .ctor(Codec)</summary>
		[PexMethod]
		public Paginator ConstructorTest(Codec codec)
		{
			Paginator target = new Paginator(codec);
			return target;
			// TODO: add assertions to method PaginatorTest.ConstructorTest(Codec)
		}

		/// <summary>Test stub for AddPage(Page)</summary>
		[PexMethod]
		public void AddPageTest([PexAssumeUnderTest]Paginator target, Page page)
		{
			target.AddPage(page);
			// TODO: add assertions to method PaginatorTest.AddPageTest(Paginator, Page)
		}

		/// <summary>Test stub for Paginate(Int32&amp;)</summary>
		[PexMethod]
		public Page[] PaginateTest([PexAssumeUnderTest]Paginator target, out int change)
		{
			Page[] result = target.Paginate(out change);
			return result;
			// TODO: add assertions to method PaginatorTest.PaginateTest(Paginator, Int32&)
		}

		/// <summary>Test stub for SetComment(XiphComment)</summary>
		[PexMethod]
		public void SetCommentTest([PexAssumeUnderTest]Paginator target, XiphComment comment)
		{
			target.SetComment(comment);
			// TODO: add assertions to method PaginatorTest.SetCommentTest(Paginator, XiphComment)
		}
	}
}
