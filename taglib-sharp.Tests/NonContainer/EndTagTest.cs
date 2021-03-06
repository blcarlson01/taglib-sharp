using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.NonContainer;

namespace TagLib.NonContainer.Tests
{
    /// <summary>This class contains parameterized unit tests for EndTag</summary>
    [TestClass]
    [PexClass(typeof(EndTag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EndTagTest
    {

		/// <summary>Test stub for .ctor(File)</summary>
		[PexMethod]
		public EndTag ConstructorTest(File file)
		{
			EndTag target = new EndTag(file);
			return target;
			// TODO: add assertions to method EndTagTest.ConstructorTest(File)
		}

		

		/// <summary>Test stub for Read()</summary>
		[PexMethod]
		public long ReadTest([PexAssumeUnderTest]EndTag target)
		{
			long result = target.Read();
			return result;
			// TODO: add assertions to method EndTagTest.ReadTest(EndTag)
		}

		/// <summary>Test stub for RemoveTags(TagTypes)</summary>
		[PexMethod]
		public void RemoveTagsTest([PexAssumeUnderTest]EndTag target, TagTypes types)
		{
			target.RemoveTags(types);
			// TODO: add assertions to method EndTagTest.RemoveTagsTest(EndTag, TagTypes)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]EndTag target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method EndTagTest.RenderTest(EndTag)
		}

		/// <summary>Test stub for Write()</summary>
		[PexMethod]
		public long WriteTest([PexAssumeUnderTest]EndTag target)
		{
			long result = target.Write();
			return result;
			// TODO: add assertions to method EndTagTest.WriteTest(EndTag)
		}

		/// <summary>Test stub for get_TotalSize()</summary>
		[PexMethod]
		public long TotalSizeGetTest([PexAssumeUnderTest]EndTag target)
		{
			long result = target.TotalSize;
			return result;
			// TODO: add assertions to method EndTagTest.TotalSizeGetTest(EndTag)
		}
	}
}
