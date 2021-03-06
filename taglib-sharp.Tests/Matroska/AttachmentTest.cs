using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for Attachment</summary>
    [TestClass]
    [PexClass(typeof(Attachment))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class AttachmentTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public Attachment ConstructorTest()
		{
			Attachment target = new Attachment();
			return target;
			// TODO: add assertions to method AttachmentTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(String)</summary>
		[PexMethod]
		public Attachment ConstructorTest01(string path)
		{
			Attachment target = new Attachment(path);
			return target;
			// TODO: add assertions to method AttachmentTest.ConstructorTest01(String)
		}

		/// <summary>Test stub for .ctor(IFileAbstraction)</summary>
		[PexMethod]
		public Attachment ConstructorTest02(File.IFileAbstraction abstraction)
		{
			Attachment target = new Attachment(abstraction);
			return target;
			// TODO: add assertions to method AttachmentTest.ConstructorTest02(IFileAbstraction)
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public Attachment ConstructorTest03(ByteVector data)
		{
			Attachment target = new Attachment(data);
			return target;
			// TODO: add assertions to method AttachmentTest.ConstructorTest03(ByteVector)
		}

		/// <summary>Test stub for .ctor(IPicture)</summary>
		[PexMethod]
		public Attachment ConstructorTest04(IPicture picture)
		{
			Attachment target = new Attachment(picture);
			return target;
			// TODO: add assertions to method AttachmentTest.ConstructorTest04(IPicture)
		}

		/// <summary>Test stub for SetFilenameFromType()</summary>
		[PexMethod]
		public bool SetFilenameFromTypeTest([PexAssumeUnderTest]Attachment target)
		{
			bool result = target.SetFilenameFromType();
			return result;
			// TODO: add assertions to method AttachmentTest.SetFilenameFromTypeTest(Attachment)
		}

		/// <summary>Test stub for SetTypeFromFilename()</summary>
		[PexMethod]
		public void SetTypeFromFilenameTest([PexAssumeUnderTest]Attachment target)
		{
			target.SetTypeFromFilename();
			// TODO: add assertions to method AttachmentTest.SetTypeFromFilenameTest(Attachment)
		}

		/// <summary>Test stub for get_UID()</summary>
		[PexMethod]
		public ulong UIDGetTest([PexAssumeUnderTest]Attachment target)
		{
			ulong result = target.UID;
			return result;
			// TODO: add assertions to method AttachmentTest.UIDGetTest(Attachment)
		}

		/// <summary>Test stub for get_UIDType()</summary>
		[PexMethod]
		public MatroskaID UIDTypeGetTest([PexAssumeUnderTest]Attachment target)
		{
			MatroskaID result = target.UIDType;
			return result;
			// TODO: add assertions to method AttachmentTest.UIDTypeGetTest(Attachment)
		}

		/// <summary>Test stub for set_UID(UInt64)</summary>
		[PexMethod]
		public void UIDSetTest([PexAssumeUnderTest]Attachment target, ulong value)
		{
			target.UID = value;
			// TODO: add assertions to method AttachmentTest.UIDSetTest(Attachment, UInt64)
		}
	}
}
