using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.MusePack;

namespace TagLib.MusePack.Tests
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
	}
}
