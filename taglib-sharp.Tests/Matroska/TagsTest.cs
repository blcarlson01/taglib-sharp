using System.Collections.ObjectModel;
using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for Tags</summary>
    [TestClass]
    [PexClass(typeof(Tags))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TagsTest
    {

		/// <summary>Test stub for .ctor(List`1&lt;Track&gt;)</summary>
		[PexMethod]
		public Tags ConstructorTest(List<Track> tracks)
		{
			Tags target = new Tags(tracks);
			return target;
			// TODO: add assertions to method TagsTest.ConstructorTest(List`1<Track>)
		}

		/// <summary>Test stub for Get(TargetType, Nullable`1&lt;Boolean&gt;)</summary>
		[PexMethod]
		public Tag GetTest(
			[PexAssumeUnderTest]Tags target,
			TargetType targetType,
			bool? medium
		)
		{
			Tag result = target.Get(targetType, medium);
			return result;
			// TODO: add assertions to method TagsTest.GetTest(Tags, TargetType, Nullable`1<Boolean>)
		}

		/// <summary>Test stub for Get(IUIDElement, UInt16)</summary>
		[PexMethod]
		public Tag GetTest01(
			[PexAssumeUnderTest]Tags target,
			IUIDElement UIDelement,
			ushort targetTypeValue
		)
		{
			Tag result = target.Get(UIDelement, targetTypeValue);
			return result;
			// TODO: add assertions to method TagsTest.GetTest01(Tags, IUIDElement, UInt16)
		}

		/// <summary>Test stub for get_Album()</summary>
		[PexMethod]
		public Tag AlbumGetTest([PexAssumeUnderTest]Tags target)
		{
			Tag result = target.Album;
			return result;
			// TODO: add assertions to method TagsTest.AlbumGetTest(Tags)
		}

		/// <summary>Test stub for get_Attachments()</summary>
		[PexMethod]
		public Attachment[] AttachmentsGetTest([PexAssumeUnderTest]Tags target)
		{
			Attachment[] result = target.Attachments;
			return result;
			// TODO: add assertions to method TagsTest.AttachmentsGetTest(Tags)
		}

		/// <summary>Test stub for get_Medium()</summary>
		[PexMethod]
		public Tag MediumGetTest([PexAssumeUnderTest]Tags target)
		{
			Tag result = target.Medium;
			return result;
			// TODO: add assertions to method TagsTest.MediumGetTest(Tags)
		}

		/// <summary>Test stub for get_Tracks()</summary>
		[PexMethod]
		public ReadOnlyCollection<Track> TracksGetTest([PexAssumeUnderTest]Tags target)
		{
			ReadOnlyCollection<Track> result = target.Tracks;
			return result;
			// TODO: add assertions to method TagsTest.TracksGetTest(Tags)
		}

		/// <summary>Test stub for set_Attachments(Attachment[])</summary>
		[PexMethod]
		public void AttachmentsSetTest([PexAssumeUnderTest]Tags target, Attachment[] value)
		{
			target.Attachments = value;
			// TODO: add assertions to method TagsTest.AttachmentsSetTest(Tags, Attachment[])
		}
	}
}
