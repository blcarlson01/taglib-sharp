using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Metrics;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;
using TagLib.Tests;

namespace TagLib.Riff.Tests
{
    /// <summary>This class contains parameterized unit tests for DivXTag</summary>
    [TestClass]
    [PexClass(typeof(DivXTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DivXTagTest
    {
		[PexMethod(MaxRunsWithoutNewTests = 200)]
		public void FullTagClearTest([PexAssumeUnderTest]Riff.DivXTag tag, string title, 
			string[] performers, uint year, string comment, string[] genres )
		{			
			PexAssume.IsNotNullOrEmpty(title);			
			PexAssume.IsNotNull(genres);
			PexAssume.IsNotNull(performers);
			PexAssume.IsNotNullOrEmpty(comment);			

			tag.Title = title;
			tag.Performers = performers;
			tag.Comment = comment;
			tag.Genres = genres;
			tag.Year = year;

			PexAssert.AreEqual(tag.Title, title);			
			PexAssert.AreEqual(tag.Performers.Length, performers.Length);
			PexAssert.AreEqual(tag.JoinedPerformers, string.Join("; ", performers));
			PexAssert.AreEqual(tag.Comment, comment);
			PexAssert.AreEqual(tag.Genres.Length, genres.Length);
			PexAssert.AreEqual(tag.JoinedGenres, string.Join("; ", genres));
			PexAssert.AreEqual(tag.Year, year);

			//Clear
			PexAssert.AreEqual(false, tag.IsEmpty);
			tag.Clear();
			PexAssert.IsTrue(tag.IsEmpty);
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]DivXTag target)
		{
			ByteVector result = target.Render();
			PexAssert.AreEqual(128, result.Count);
			PexAssert.IsTrue(result.EndsWith(Riff.DivXTag.FileIdentifier));
			return result;			
		}

		[PexMethod]
		[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
		public DivXTag ConstructorNullData(ByteVector data)
		{
			PexAssume.IsNull(data);
			DivXTag target = new DivXTag(data);
			return target;
		}

		[PexMethod]
		[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentNullException))]
		public DivXTag ConstructorNullFile(File file, long position)
		{
			PexAssume.IsNull(file);
			DivXTag target = new DivXTag(file, position);
			return target;
		}

		[PexMethod]
		public DivXTag ConstructorNotNullData(ByteVector data)
		{
			PexAssume.IsNotNull(data);
			PexAssume.AreEqual(false,data.EndsWith("DIVXTAG"));
			PexAssume.IsTrue(data.Count <= 128);
			DivXTag target = new DivXTag(data);			
			return target;
		}

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public DivXTag ConstructorTest()
		{
			DivXTag target = new DivXTag();
			PexAssert.IsNotNull(target);
			return target;			
		}

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod(MaxBranches = 40000)]
		public DivXTag ConstructorTest01([PexAssumeUnderTest]File file, long position)
		{
			DivXTag target = new DivXTag(file, position);
			PexAssert.IsNotNull(target);
			return target;
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public DivXTag ConstructorTest02([PexAssumeUnderTest]ByteVector data)
		{			
			PexAssume.IsTrue(data.EndsWith("DIVXTAG"));
			PexAssume.IsTrue(data.Count >= 127);
			DivXTag target = new DivXTag(data);
			
			PexAssert.IsNotNull(target);
			return target;
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]DivXTag target)
		{
			PexAssume.AreEqual(false, target.IsEmpty);
			target.Clear();
			PexAssert.IsTrue(target.IsEmpty);
		}
				
		/// <summary>Test stub for get_Comment()</summary>
		[PexMethod]
		public string CommentGetTest([PexAssumeUnderTest]DivXTag target)
		{
			string result = target.Comment;
			return result;
			// TODO: add assertions to method DivXTagTest.CommentGetTest(DivXTag)
		}

		/// <summary>Test stub for get_Genres()</summary>
		[PexMethod]
		public string[] GenresGetTest([PexAssumeUnderTest]DivXTag target)
		{
			string[] result = target.Genres;
			return result;
			// TODO: add assertions to method DivXTagTest.GenresGetTest(DivXTag)
		}

		/// <summary>Test stub for get_Performers()</summary>
		[PexMethod]
		public string[] PerformersGetTest([PexAssumeUnderTest]DivXTag target)
		{
			string[] result = target.Performers;
			return result;
			// TODO: add assertions to method DivXTagTest.PerformersGetTest(DivXTag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]DivXTag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method DivXTagTest.TagTypesGetTest(DivXTag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]DivXTag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method DivXTagTest.TitleGetTest(DivXTag)
		}

		/// <summary>Test stub for get_Year()</summary>
		[PexMethod]
		public uint YearGetTest([PexAssumeUnderTest]DivXTag target)
		{
			uint result = target.Year;
			return result;
			// TODO: add assertions to method DivXTagTest.YearGetTest(DivXTag)
		}

		/// <summary>Test stub for set_Comment(String)</summary>
		[PexMethod]
		public void CommentSetTest([PexAssumeUnderTest]DivXTag target, string value)
		{
			target.Comment = value;
			// TODO: add assertions to method DivXTagTest.CommentSetTest(DivXTag, String)
		}

		/// <summary>Test stub for set_Genres(String[])</summary>
		[PexMethod]
		public void GenresSetTest([PexAssumeUnderTest]DivXTag target, string[] value)
		{
			target.Genres = value;
			// TODO: add assertions to method DivXTagTest.GenresSetTest(DivXTag, String[])
		}

		/// <summary>Test stub for set_Performers(String[])</summary>
		[PexMethod]
		public void PerformersSetTest([PexAssumeUnderTest]DivXTag target, string[] value)
		{
			target.Performers = value;
			// TODO: add assertions to method DivXTagTest.PerformersSetTest(DivXTag, String[])
		}

		/// <summary>Test stub for set_Title(String)</summary>
		[PexMethod]
		public void TitleSetTest([PexAssumeUnderTest]DivXTag target, string value)
		{
			target.Title = value;
			// TODO: add assertions to method DivXTagTest.TitleSetTest(DivXTag, String)
		}

		/// <summary>Test stub for set_Year(UInt32)</summary>
		[PexMethod]
		public void YearSetTest([PexAssumeUnderTest]DivXTag target, uint value)
		{
			target.Year = value;
			// TODO: add assertions to method DivXTagTest.YearSetTest(DivXTag, UInt32)
		}
	}
}
