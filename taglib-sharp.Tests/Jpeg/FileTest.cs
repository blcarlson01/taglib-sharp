using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Jpeg;

namespace TagLib.Jpeg.Tests
{
    /// <summary>This class contains parameterized unit tests for File</summary>
    [TestClass]
    [PexClass(typeof(File))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class FileTest
    {

		/// <summary>Test stub for .ctor(String, ReadStyle)</summary>
		[PexMethod]
		public File ConstructorTest(string path, ReadStyle propertiesStyle)
		{
			File target = new File(path, propertiesStyle);
			return target;
			// TODO: add assertions to method FileTest.ConstructorTest(String, ReadStyle)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public File ConstructorTest01(string path)
		{
			File target = new File(path);
			return target;
			// TODO: add assertions to method FileTest.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(IFileAbstraction, ReadStyle)</summary>
		[PexMethod]
		public File ConstructorTest02(File.IFileAbstraction abstraction, ReadStyle propertiesStyle)
		{
			File target = new File(abstraction, propertiesStyle);
			return target;
			// TODO: add assertions to method FileTest.ConstructorTest02(IFileAbstraction, ReadStyle)
		}

		/// <summary>Test stub for GetTag(TagTypes, Boolean)</summary>
		[PexMethod]
		public Tag GetTagTest(
			[PexAssumeUnderTest]File target,
			TagTypes type,
			bool create
		)
		{
			Tag result = target.GetTag(type, create);
			return result;
			// TODO: add assertions to method FileTest.GetTagTest(File, TagTypes, Boolean)
		}

		/// <summary>Test stub for Save()</summary>
		[PexMethod]
		public void SaveTest([PexAssumeUnderTest]File target)
		{
			target.Save();
			// TODO: add assertions to method FileTest.SaveTest(File)
		}

		/// <summary>Test stub for get_Properties()</summary>
		[PexMethod]
		public Properties PropertiesGetTest([PexAssumeUnderTest]File target)
		{
			Properties result = target.Properties;
			return result;
			// TODO: add assertions to method FileTest.PropertiesGetTest(File)
		}
	}
}
