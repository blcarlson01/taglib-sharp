using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;

namespace TagLib.IFD.Tests
{
    /// <summary>This class contains parameterized unit tests for IFDRenderer</summary>
    [TestClass]
    [PexClass(typeof(IFDRenderer))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IFDRendererTest
    {

		/// <summary>Test stub for .ctor(Boolean, IFDStructure, UInt32)</summary>
		[PexMethod]
		public IFDRenderer ConstructorTest(
			bool is_bigendian,
			IFDStructure structure,
			uint ifd_offset
		)
		{
			IFDRenderer target = new IFDRenderer(is_bigendian, structure, ifd_offset);
			return target;
			// TODO: add assertions to method IFDRendererTest.ConstructorTest(Boolean, IFDStructure, UInt32)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]IFDRenderer target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method IFDRendererTest.RenderTest(IFDRenderer)
		}
	}
}
