using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.NonContainer;

namespace TagLib.NonContainer.Tests
{
    /// <summary>This class contains parameterized unit tests for Tag</summary>
    [TestClass]
    [PexClass(typeof(Tag))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TagTest
    {

		/// <summary>Test stub for .ctor(File)</summary>
		[PexMethod]
		public Tag ConstructorTest(File file)
		{
			Tag target = new Tag(file);
			return target;
			// TODO: add assertions to method TagTest.ConstructorTest(File)
		}

		

		/// <summary>Test stub for Read(Int64&amp;, Int64&amp;)</summary>
		[PexMethod]
		public void ReadTest(
			[PexAssumeUnderTest]Tag target,
			out long start,
			out long end
		)
		{
			target.Read(out start, out end);
			// TODO: add assertions to method TagTest.ReadTest(Tag, Int64&, Int64&)
		}

		/// <summary>Test stub for ReadEnd()</summary>
		[PexMethod]
		public long ReadEndTest([PexAssumeUnderTest]Tag target)
		{
			long result = target.ReadEnd();
			return result;
			// TODO: add assertions to method TagTest.ReadEndTest(Tag)
		}

		/// <summary>Test stub for ReadStart()</summary>
		[PexMethod]
		public long ReadStartTest([PexAssumeUnderTest]Tag target)
		{
			long result = target.ReadStart();
			return result;
			// TODO: add assertions to method TagTest.ReadStartTest(Tag)
		}

		/// <summary>Test stub for RemoveTags(TagTypes)</summary>
		[PexMethod]
		public void RemoveTagsTest([PexAssumeUnderTest]Tag target, TagTypes types)
		{
			target.RemoveTags(types);
			// TODO: add assertions to method TagTest.RemoveTagsTest(Tag, TagTypes)
		}

		/// <summary>Test stub for Write(Int64&amp;, Int64&amp;)</summary>
		[PexMethod]
		public void WriteTest(
			[PexAssumeUnderTest]Tag target,
			out long start,
			out long end
		)
		{
			target.Write(out start, out end);
			// TODO: add assertions to method TagTest.WriteTest(Tag, Int64&, Int64&)
		}

		/// <summary>Test stub for get_EndTag()</summary>
		[PexMethod]
		public EndTag EndTagGetTest([PexAssumeUnderTest]Tag target)
		{
			EndTag result = target.EndTag;
			return result;
			// TODO: add assertions to method TagTest.EndTagGetTest(Tag)
		}

		/// <summary>Test stub for get_StartTag()</summary>
		[PexMethod]
		public StartTag StartTagGetTest([PexAssumeUnderTest]Tag target)
		{
			StartTag result = target.StartTag;
			return result;
			// TODO: add assertions to method TagTest.StartTagGetTest(Tag)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]Tag target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method TagTest.TagTypesGetTest(Tag)
		}


	}
}
