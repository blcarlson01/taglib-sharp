using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Audible;

namespace TagLib.Audible.Tests
{
    /// <summary>This class contains parameterized unit tests for Tag</summary>
    [TestClass]
    [PexClass(typeof(Tag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TagTest
    {
		[PexMethod]
		public void SetTagClearTest([PexAssumeUnderTest]Audible.Tag tag, string album)
		{
			//var tag = (Audible.Tag)File.Create(Path.Combine(BaseDirectory, "first.aa")).Tag;
			PexAssume.IsNotNullOrEmpty(album);
			PexAssume.IsTrue(tag.IsEmpty);

			tag.Album = album;

			PexAssert.AreEqual(tag.Album, album);
			
			tag.Clear();
			PexAssert.AreEqual(false, tag.IsEmpty);

			/*Assert.AreEqual(tag.Album, "Glyn Hughes"); // This is probably wrong. The publisher is not the album
			Assert.AreEqual(tag.Author, "Ricky Gervais, Steve Merchant, & Karl Pilkington");
			Assert.AreEqual(tag.Copyright, "&#169;2009 Ricky Gervais; (P)2009 Ricky Gervais");
			Assert.IsTrue(tag.Description.StartsWith("This is the second in a new series of definitive discourses exploring the diversity of human"));
			Assert.AreEqual(tag.Narrator, "Ricky Gervais, Steve Merchant, & Karl Pilkington");
			Assert.AreEqual(tag.Title, "The Ricky Gervais Guide to... NATURAL HISTORY (Unabridged)");*/

		}


		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public Tag ConstructorTest()
		{
			Tag target = new Tag();
			return target;
			// TODO: add assertions to method TagTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public Tag ConstructorTest01(ByteVector data)
		{
			Tag target = new Tag(data);
			return target;
			// TODO: add assertions to method TagTest.ConstructorTest01(ByteVector)
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]Tag target)
		{
			target.Clear();
			// TODO: add assertions to method TagTest.ClearTest(Tag)
		}

		/// <summary>Test stub for get_Album()</summary>
		[PexMethod]
		public string AlbumGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Album;
			return result;
			// TODO: add assertions to method TagTest.AlbumGetTest(Tag)
		}

		/// <summary>Test stub for get_AlbumArtists()</summary>
		[PexMethod]
		public string[] AlbumArtistsGetTest([PexAssumeUnderTest]Tag target)
		{
			string[] result = target.AlbumArtists;
			return result;
			// TODO: add assertions to method TagTest.AlbumArtistsGetTest(Tag)
		}

		/// <summary>Test stub for get_Author()</summary>
		[PexMethod]
		public string AuthorGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Author;
			return result;
			// TODO: add assertions to method TagTest.AuthorGetTest(Tag)
		}

		/// <summary>Test stub for get_Copyright()</summary>
		[PexMethod]
		public string CopyrightGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Copyright;
			return result;
			// TODO: add assertions to method TagTest.CopyrightGetTest(Tag)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method TagTest.DescriptionGetTest(Tag)
		}

		/// <summary>Test stub for get_Narrator()</summary>
		[PexMethod]
		public string NarratorGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Narrator;
			return result;
			// TODO: add assertions to method TagTest.NarratorGetTest(Tag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]Tag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method TagTest.TagTypesGetTest(Tag)
		}

		/// <summary>Test stub for get_Title()</summary>
		[PexMethod]
		public string TitleGetTest([PexAssumeUnderTest]Tag target)
		{
			string result = target.Title;
			return result;
			// TODO: add assertions to method TagTest.TitleGetTest(Tag)
		}

		/// <summary>Test stub for set_Copyright(String)</summary>
		[PexMethod]
		public void CopyrightSetTest([PexAssumeUnderTest]Tag target, string value)
		{
			target.Copyright = value;
			// TODO: add assertions to method TagTest.CopyrightSetTest(Tag, String)
		}
	}
}
