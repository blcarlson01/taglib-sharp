using TagLib.IFD;
using TagLib.Tiff;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Tiff.Rw2;

namespace TagLib.Tiff.Rw2.Tests
{
    /// <summary>This class contains parameterized unit tests for IFDReader</summary>
    [TestClass]
    [PexClass(typeof(IFDReader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IFDReaderTest
    {

		/// <summary>Test stub for .ctor(BaseTiffFile, Boolean, IFDStructure, Int64, UInt32, UInt32)</summary>
		[PexMethod]
		public IFDReader ConstructorTest(
			BaseTiffFile file,
			bool is_bigendian,
			IFDStructure structure,
			long base_offset,
			uint ifd_offset,
			uint max_offset
		)
		{
			IFDReader target = new IFDReader(file, is_bigendian, structure, base_offset, ifd_offset, max_offset)
			  ;
			return target;
			// TODO: add assertions to method IFDReaderTest.ConstructorTest(BaseTiffFile, Boolean, IFDStructure, Int64, UInt32, UInt32)
		}
	}
}
