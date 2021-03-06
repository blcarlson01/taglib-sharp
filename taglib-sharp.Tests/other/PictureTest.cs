using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for Picture</summary>
    [TestClass]
    [PexClass(typeof(Picture))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PictureTest
    {

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public Picture ConstructorTest(string path)
		{
			Picture target = new Picture(path);
			return target;
			// TODO: add assertions to method PictureTest.ConstructorTest(String)
		}

		/// <summary>Test stub for .ctor(IFileAbstraction)</summary>
		[PexMethod]
		public Picture ConstructorTest01(File.IFileAbstraction abstraction)
		{
			Picture target = new Picture(abstraction);
			return target;
			// TODO: add assertions to method PictureTest.ConstructorTest01(IFileAbstraction)
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public Picture ConstructorTest02(ByteVector data)
		{
			Picture target = new Picture(data);
			return target;
			// TODO: add assertions to method PictureTest.ConstructorTest02(ByteVector)
		}

		/// <summary>Test stub for .ctor(IPicture)</summary>
		[PexMethod]
		public Picture ConstructorTest03(IPicture picture)
		{
			Picture target = new Picture(picture);
			return target;
			// TODO: add assertions to method PictureTest.ConstructorTest03(IPicture)
		}

		/// <summary>Test stub for get_Data()</summary>
		[PexMethod]
		public ByteVector DataGetTest([PexAssumeUnderTest]Picture target)
		{
			ByteVector result = target.Data;
			return result;
			// TODO: add assertions to method PictureTest.DataGetTest(Picture)
		}

		/// <summary>Test stub for get_Description()</summary>
		[PexMethod]
		public string DescriptionGetTest([PexAssumeUnderTest]Picture target)
		{
			string result = target.Description;
			return result;
			// TODO: add assertions to method PictureTest.DescriptionGetTest(Picture)
		}

		/// <summary>Test stub for get_Filename()</summary>
		[PexMethod]
		public string FilenameGetTest([PexAssumeUnderTest]Picture target)
		{
			string result = target.Filename;
			return result;
			// TODO: add assertions to method PictureTest.FilenameGetTest(Picture)
		}

		/// <summary>Test stub for get_MimeType()</summary>
		[PexMethod]
		public string MimeTypeGetTest([PexAssumeUnderTest]Picture target)
		{
			string result = target.MimeType;
			return result;
			// TODO: add assertions to method PictureTest.MimeTypeGetTest(Picture)
		}

		/// <summary>Test stub for get_Type()</summary>
		[PexMethod]
		public PictureType TypeGetTest([PexAssumeUnderTest]Picture target)
		{
			PictureType result = target.Type;
			return result;
			// TODO: add assertions to method PictureTest.TypeGetTest(Picture)
		}

		/// <summary>Test stub for set_Data(ByteVector)</summary>
		[PexMethod]
		public void DataSetTest([PexAssumeUnderTest]Picture target, ByteVector value)
		{
			target.Data = value;
			// TODO: add assertions to method PictureTest.DataSetTest(Picture, ByteVector)
		}

		/// <summary>Test stub for set_Description(String)</summary>
		[PexMethod]
		public void DescriptionSetTest([PexAssumeUnderTest]Picture target, string value)
		{
			target.Description = value;
			// TODO: add assertions to method PictureTest.DescriptionSetTest(Picture, String)
		}

		/// <summary>Test stub for set_Filename(String)</summary>
		[PexMethod]
		public void FilenameSetTest([PexAssumeUnderTest]Picture target, string value)
		{
			target.Filename = value;
			// TODO: add assertions to method PictureTest.FilenameSetTest(Picture, String)
		}

		/// <summary>Test stub for set_MimeType(String)</summary>
		[PexMethod]
		public void MimeTypeSetTest([PexAssumeUnderTest]Picture target, string value)
		{
			target.MimeType = value;
			// TODO: add assertions to method PictureTest.MimeTypeSetTest(Picture, String)
		}

		/// <summary>Test stub for set_Type(PictureType)</summary>
		[PexMethod]
		public void TypeSetTest([PexAssumeUnderTest]Picture target, PictureType value)
		{
			target.Type = value;
			// TODO: add assertions to method PictureTest.TypeSetTest(Picture, PictureType)
		}
	}
}
