using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for ContentDescriptionObject</summary>
    [TestClass]
    [PexClass(typeof(ContentDescriptionObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ContentDescriptionObjectTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public ContentDescriptionObject ConstructorTest(File file, long position)
		{
			ContentDescriptionObject target = new ContentDescriptionObject(file, position);
			return target;
			// TODO: add assertions to method ContentDescriptionObjectTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public ContentDescriptionObject ConstructorTest01()
		{
			ContentDescriptionObject target = new ContentDescriptionObject();
			return target;
			// TODO: add assertions to method ContentDescriptionObjectTest.ConstructorTest01()
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]ContentDescriptionObject target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method ContentDescriptionObjectTest.RenderTest(ContentDescriptionObject)
		}

		/// <summary>Test stub for get_Author()</summary>
		[PexMethod]
		public string AuthorGetTest([PexAssumeUnderTest]ContentDescriptionObject target)
		{
			string result = target.Author;
			return result;
			// TODO: add assertions to method ContentDescriptionObjectTest.AuthorGetTest(ContentDescriptionObject)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]ContentDescriptionObject target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method ContentDescriptionObjectTest.CopyrightGetTest(ContentDescriptionObject)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]ContentDescriptionObject target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method ContentDescriptionObjectTest.DescriptionGetTest(ContentDescriptionObject)
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest([PexAssumeUnderTest]ContentDescriptionObject target)
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method ContentDescriptionObjectTest.IsEmptyGetTest(ContentDescriptionObject)
		}

		/// <summary>Test stub for get_Rating()</summary>
		[PexMethod]
		public string RatingGetTest([PexAssumeUnderTest]ContentDescriptionObject target)
		{
			string result = target.Rating;
			return result;
			// TODO: add assertions to method ContentDescriptionObjectTest.RatingGetTest(ContentDescriptionObject)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]ContentDescriptionObject target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method ContentDescriptionObjectTest.TitleGetTest(ContentDescriptionObject)
		}

		/// <summary>Test stub for set_Author(String)</summary>
		[PexMethod]
		public void AuthorSetTest([PexAssumeUnderTest]ContentDescriptionObject target, string value)
		{
			target.Author = value;
			// TODO: add assertions to method ContentDescriptionObjectTest.AuthorSetTest(ContentDescriptionObject, String)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]ContentDescriptionObject target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method ContentDescriptionObjectTest.CopyrightSetTest(ContentDescriptionObject, String)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]ContentDescriptionObject target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method ContentDescriptionObjectTest.DescriptionSetTest(ContentDescriptionObject, String)
		}

		/// <summary>Test stub for set_Rating(String)</summary>
		[PexMethod]
		public void RatingSetTest([PexAssumeUnderTest]ContentDescriptionObject target, string value)
		{
			target.Rating = value;
			// TODO: add assertions to method ContentDescriptionObjectTest.RatingSetTest(ContentDescriptionObject, String)
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]ContentDescriptionObject target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method ContentDescriptionObjectTest.TitleSetTest(ContentDescriptionObject, String)
		}
	}
}
