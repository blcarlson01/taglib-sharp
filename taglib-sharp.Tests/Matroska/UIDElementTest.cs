using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for UIDElement</summary>
    [TestClass]
    [PexClass(typeof(UIDElement))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UIDElementTest
    {

		/// <summary>Test stub for .ctor(MatroskaID, UInt64)</summary>
		[PexMethod]
		public UIDElement ConstructorTest(MatroskaID type, ulong uid)
		{
			UIDElement target = new UIDElement(type, uid);
			return target;
			// TODO: add assertions to method UIDElementTest.ConstructorTest(MatroskaID, UInt64)
		}

		/// <summary>Test stub for GenUID(UInt64)</summary>
		[PexMethod]
		public ulong GenUIDTest(ulong ret)
		{
			ulong result = UIDElement.GenUID(ret);
			return result;
			// TODO: add assertions to method UIDElementTest.GenUIDTest(UInt64)
		}

		/// <summary>Test stub for get_UID()</summary>
		[PexMethod]
		public ulong UIDGetTest([PexAssumeUnderTest]UIDElement target)
		{
			ulong result = target.UID;
			return result;
			// TODO: add assertions to method UIDElementTest.UIDGetTest(UIDElement)
		}

		/// <summary>Test stub for get_UIDType()</summary>
		[PexMethod]
		public MatroskaID UIDTypeGetTest([PexAssumeUnderTest]UIDElement target)
		{
			MatroskaID result = target.UIDType;
			return result;
			// TODO: add assertions to method UIDElementTest.UIDTypeGetTest(UIDElement)
		}

		/// <summary>Test stub for set_UID(UInt64)</summary>
		[PexMethod]
		public void UIDSetTest([PexAssumeUnderTest]UIDElement target, ulong value)
		{
			target.UID = value;
			// TODO: add assertions to method UIDElementTest.UIDSetTest(UIDElement, UInt64)
		}
	}
}
