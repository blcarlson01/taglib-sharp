using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
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

		/// <summary>Test stub for .ctor(IFileAbstraction)</summary>
		[PexMethod]
		public File ConstructorTest03(File.IFileAbstraction abstraction)
		{
			File target = new File(abstraction);
			return target;
			// TODO: add assertions to method FileTest.ConstructorTest03(IFileAbstraction)
		}

		

		/// <summary>Test stub for RemoveTags(TagTypes)</summary>
		[PexMethod]
		public void RemoveTagsTest([PexAssumeUnderTest]File target, TagTypes types)
		{
			target.RemoveTags(types);
			// TODO: add assertions to method FileTest.RemoveTagsTest(File, TagTypes)
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
