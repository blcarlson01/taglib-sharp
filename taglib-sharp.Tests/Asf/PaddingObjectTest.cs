using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for PaddingObject</summary>
    [TestClass]
    [PexClass(typeof(PaddingObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class PaddingObjectTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public PaddingObject ConstructorTest(File file, long position)
		{
			PaddingObject target = new PaddingObject(file, position);
			return target;
			// TODO: add assertions to method PaddingObjectTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for .ctor(UInt32)</summary>
		[PexMethod]
		public PaddingObject ConstructorTest01(uint size)
		{
			PaddingObject target = new PaddingObject(size);
			return target;
			// TODO: add assertions to method PaddingObjectTest.ConstructorTest01(UInt32)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]PaddingObject target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method PaddingObjectTest.RenderTest(PaddingObject)
		}

		/// <summary>Test stub for get_Size()</summary>
		[PexMethod]
		public ulong SizeGetTest([PexAssumeUnderTest]PaddingObject target)
		{
			ulong result = target.Size;
			return result;
			// TODO: add assertions to method PaddingObjectTest.SizeGetTest(PaddingObject)
		}

		/// <summary>Test stub for set_Size(UInt64)</summary>
		[PexMethod]
		public void SizeSetTest([PexAssumeUnderTest]PaddingObject target, ulong value)
		{
			target.Size = value;
			// TODO: add assertions to method PaddingObjectTest.SizeSetTest(PaddingObject, UInt64)
		}
	}
}
