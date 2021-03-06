using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.NonContainer;

namespace TagLib.NonContainer.Tests
{
    /// <summary>This class contains parameterized unit tests for StartTag</summary>
    [TestClass]
    [PexClass(typeof(StartTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StartTagTest
    {

		/// <summary>Test stub for .ctor(File)</summary>
		[PexMethod]
		public StartTag ConstructorTest(File file)
		{
			StartTag target = new StartTag(file);
			return target;
			// TODO: add assertions to method StartTagTest.ConstructorTest(File)
		}

		

		/// <summary>Test stub for Read()</summary>
		[PexMethod]
		public long ReadTest([PexAssumeUnderTest]StartTag target)
		{
			long result = target.Read();
			return result;
			// TODO: add assertions to method StartTagTest.ReadTest(StartTag)
		}

		/// <summary>Test stub for RemoveTags(TagTypes)</summary>
		[PexMethod]
		public void RemoveTagsTest([PexAssumeUnderTest]StartTag target, TagTypes types)
		{
			target.RemoveTags(types);
			// TODO: add assertions to method StartTagTest.RemoveTagsTest(StartTag, TagTypes)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]StartTag target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method StartTagTest.RenderTest(StartTag)
		}

		/// <summary>Test stub for Write()</summary>
		[PexMethod]
		public long WriteTest([PexAssumeUnderTest]StartTag target)
		{
			long result = target.Write();
			return result;
			// TODO: add assertions to method StartTagTest.WriteTest(StartTag)
		}

		/// <summary>Test stub for get_TotalSize()</summary>
		[PexMethod]
		public long TotalSizeGetTest([PexAssumeUnderTest]StartTag target)
		{
			long result = target.TotalSize;
			return result;
			// TODO: add assertions to method StartTagTest.TotalSizeGetTest(StartTag)
		}
	}
}
