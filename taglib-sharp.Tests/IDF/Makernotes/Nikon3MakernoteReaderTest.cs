using TagLib.IFD;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD.Makernotes;

namespace TagLib.IFD.Makernotes.Tests
{
    /// <summary>This class contains parameterized unit tests for Nikon3MakernoteReader</summary>
    [TestClass]
    [PexClass(typeof(Nikon3MakernoteReader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class Nikon3MakernoteReaderTest
    {

		/// <summary>Test stub for .ctor(File, Boolean, IFDStructure, Int64, UInt32, UInt32)</summary>
		[PexMethod]
		public Nikon3MakernoteReader ConstructorTest(
			File file,
			bool is_bigendian,
			IFDStructure structure,
			long base_offset,
			uint ifd_offset,
			uint max_offset
		)
		{
			Nikon3MakernoteReader target
			   = new Nikon3MakernoteReader(file, is_bigendian, structure, base_offset, ifd_offset, max_offset);
			return target;
			// TODO: add assertions to method Nikon3MakernoteReaderTest.ConstructorTest(File, Boolean, IFDStructure, Int64, UInt32, UInt32)
		}
	}
}
