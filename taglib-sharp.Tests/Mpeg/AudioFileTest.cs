using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Mpeg;

namespace TagLib.Mpeg.Tests
{
    /// <summary>This class contains parameterized unit tests for AudioFile</summary>
    [TestClass]
    [PexClass(typeof(AudioFile))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AudioFileTest
    {

		/// <summary>Test stub for .ctor(String, ReadStyle)</summary>
		[PexMethod]
		public AudioFile ConstructorTest(string path, ReadStyle propertiesStyle)
		{
			AudioFile target = new AudioFile(path, propertiesStyle);
			return target;
			// TODO: add assertions to method AudioFileTest.ConstructorTest(String, ReadStyle)
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public AudioFile ConstructorTest01(string path)
		{
			AudioFile target = new AudioFile(path);
			return target;
			// TODO: add assertions to method AudioFileTest.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(IFileAbstraction, ReadStyle)</summary>
		[PexMethod]
		public AudioFile ConstructorTest02(File.IFileAbstraction abstraction, ReadStyle propertiesStyle)
		{
			AudioFile target = new AudioFile(abstraction, propertiesStyle);
			return target;
			// TODO: add assertions to method AudioFileTest.ConstructorTest02(IFileAbstraction, ReadStyle)
		}

		/// <summary>Test stub for .ctor(IFileAbstraction)</summary>
		[PexMethod]
		public AudioFile ConstructorTest03(File.IFileAbstraction abstraction)
		{
			AudioFile target = new AudioFile(abstraction);
			return target;
			// TODO: add assertions to method AudioFileTest.ConstructorTest03(IFileAbstraction)
		}

		/// <summary>Test stub for GetTag(TagTypes, Boolean)</summary>
		[PexMethod]
		public Tag GetTagTest(
			[PexAssumeUnderTest]AudioFile target,
			TagTypes type,
			bool create
		)
		{
			Tag result = target.GetTag(type, create);
			return result;
			// TODO: add assertions to method AudioFileTest.GetTagTest(AudioFile, TagTypes, Boolean)
		}
	}
}
