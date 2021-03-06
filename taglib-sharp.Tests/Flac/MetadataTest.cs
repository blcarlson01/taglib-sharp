using TagLib;
using TagLib.Ogg;
using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Flac;

namespace TagLib.Flac.Tests
{
    /// <summary>This class contains parameterized unit tests for Metadata</summary>
    [TestClass]
    [PexClass(typeof(Metadata))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MetadataTest
    {

		/// <summary>Test stub for .ctor(IEnumerable`1&lt;Block&gt;)</summary>
		[PexMethod]
		public Metadata ConstructorTest(IEnumerable<Block> blocks)
		{
			Metadata target = new Metadata(blocks);
			return target;
			// TODO: add assertions to method MetadataTest.ConstructorTest(IEnumerable`1<Block>)
		}

		/// <summary>Test stub for Clear()</summary>
		[PexMethod]
		public void ClearTest([PexAssumeUnderTest]Metadata target)
		{
			target.Clear();
			// TODO: add assertions to method MetadataTest.ClearTest(Metadata)
		}

		/// <summary>Test stub for GetComment(Boolean, Tag)</summary>
		[PexMethod]
		public XiphComment GetCommentTest(
			[PexAssumeUnderTest]Metadata target,
			bool create,
			Tag copy
		)
		{
			XiphComment result = target.GetComment(create, copy);
			return result;
			// TODO: add assertions to method MetadataTest.GetCommentTest(Metadata, Boolean, Tag)
		}

		/// <summary>Test stub for RemoveComment()</summary>
		[PexMethod]
		public void RemoveCommentTest([PexAssumeUnderTest]Metadata target)
		{
			target.RemoveComment();
			// TODO: add assertions to method MetadataTest.RemoveCommentTest(Metadata)
		}

		/// <summary>Test stub for get_Pictures()</summary>
		[PexMethod]
		public IPicture[] PicturesGetTest([PexAssumeUnderTest]Metadata target)
		{
			IPicture[] result = target.Pictures;
			return result;
			// TODO: add assertions to method MetadataTest.PicturesGetTest(Metadata)
		}

		/// <summary>Test stub for get_TagTypes()</summary>
		[PexMethod]
		public TagTypes TagTypesGetTest([PexAssumeUnderTest]Metadata target)
		{
			TagTypes result = target.TagTypes;
			return result;
			// TODO: add assertions to method MetadataTest.TagTypesGetTest(Metadata)
		}

		/// <summary>Test stub for set_Pictures(IPicture[])</summary>
		[PexMethod]
		public void PicturesSetTest([PexAssumeUnderTest]Metadata target, IPicture[] value)
		{
			target.Pictures = value;
			// TODO: add assertions to method MetadataTest.PicturesSetTest(Metadata, IPicture[])
		}
	}
}
