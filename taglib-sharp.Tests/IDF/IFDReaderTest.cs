using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;

namespace TagLib.IFD.Tests
{
    /// <summary>This class contains parameterized unit tests for IFDReader</summary>
    [TestClass]
    [PexClass(typeof(IFDReader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IFDReaderTest
    {

		/// <summary>Test stub for .ctor(File, Boolean, IFDStructure, Int64, UInt32, UInt32)</summary>
		[PexMethod]
		public IFDReader ConstructorTest(
			File file,
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
			// TODO: add assertions to method IFDReaderTest.ConstructorTest(File, Boolean, IFDStructure, Int64, UInt32, UInt32)
		}

		/// <summary>Test stub for Read()</summary>
		[PexMethod]
		public void ReadTest([PexAssumeUnderTest]IFDReader target)
		{
			target.Read();
			// TODO: add assertions to method IFDReaderTest.ReadTest(IFDReader)
		}

		/// <summary>Test stub for Read(Int32)</summary>
		[PexMethod]
		public void ReadTest01([PexAssumeUnderTest]IFDReader target, int count)
		{
			target.Read(count);
			// TODO: add assertions to method IFDReaderTest.ReadTest01(IFDReader, Int32)
		}

		
	}
}
