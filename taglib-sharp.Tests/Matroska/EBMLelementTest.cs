using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for EBMLelement</summary>
    [TestClass]
    [PexClass(typeof(EBMLelement))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EBMLelementTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public EBMLelement ConstructorTest()
		{
			EBMLelement target = new EBMLelement();
			return target;
			// TODO: add assertions to method EBMLelementTest.ConstructorTest()
		}

		/// <summary>Test stub for .ctor(MatroskaID)</summary>
		[PexMethod]
		public EBMLelement ConstructorTest01(MatroskaID ebmlid)
		{
			EBMLelement target = new EBMLelement(ebmlid);
			return target;
			// TODO: add assertions to method EBMLelementTest.ConstructorTest01(MatroskaID)
		}

		/// <summary>Test stub for .ctor(MatroskaID, ByteVector)</summary>
		[PexMethod]
		public EBMLelement ConstructorTest02(MatroskaID ebmlid, ByteVector data)
		{
			EBMLelement target = new EBMLelement(ebmlid, data);
			return target;
			// TODO: add assertions to method EBMLelementTest.ConstructorTest02(MatroskaID, ByteVector)
		}

		/// <summary>Test stub for .ctor(MatroskaID, UInt64)</summary>
		[PexMethod]
		public EBMLelement ConstructorTest03(MatroskaID ebmlid, ulong value)
		{
			EBMLelement target = new EBMLelement(ebmlid, value);
			return target;
			// TODO: add assertions to method EBMLelementTest.ConstructorTest03(MatroskaID, UInt64)
		}

		/// <summary>Test stub for EBMLByteSize(UInt64)</summary>
		[PexMethod]
		public long EBMLByteSizeTest(ulong value)
		{
			long result = EBMLelement.EBMLByteSize(value);
			return result;
			// TODO: add assertions to method EBMLelementTest.EBMLByteSizeTest(UInt64)
		}

		/// <summary>Test stub for GetBool()</summary>
		[PexMethod]
		public bool GetBoolTest([PexAssumeUnderTest]EBMLelement target)
		{
			bool result = target.GetBool();
			return result;
			// TODO: add assertions to method EBMLelementTest.GetBoolTest(EBMLelement)
		}

		/// <summary>Test stub for GetBytes()</summary>
		[PexMethod]
		public ByteVector GetBytesTest([PexAssumeUnderTest]EBMLelement target)
		{
			ByteVector result = target.GetBytes();
			return result;
			// TODO: add assertions to method EBMLelementTest.GetBytesTest(EBMLelement)
		}

		/// <summary>Test stub for GetDouble()</summary>
		[PexMethod]
		public double GetDoubleTest([PexAssumeUnderTest]EBMLelement target)
		{
			double result = target.GetDouble();
			return result;
			// TODO: add assertions to method EBMLelementTest.GetDoubleTest(EBMLelement)
		}

		/// <summary>Test stub for GetString()</summary>
		[PexMethod]
		public string GetStringTest([PexAssumeUnderTest]EBMLelement target)
		{
			string result = target.GetString();
			return result;
			// TODO: add assertions to method EBMLelementTest.GetStringTest(EBMLelement)
		}

		/// <summary>Test stub for GetULong()</summary>
		[PexMethod]
		public ulong GetULongTest([PexAssumeUnderTest]EBMLelement target)
		{
			ulong result = target.GetULong();
			return result;
			// TODO: add assertions to method EBMLelementTest.GetULongTest(EBMLelement)
		}

		/// <summary>Test stub for IncrementSize()</summary>
		[PexMethod]
		public bool IncrementSizeTest([PexAssumeUnderTest]EBMLelement target)
		{
			bool result = target.IncrementSize();
			return result;
			// TODO: add assertions to method EBMLelementTest.IncrementSizeTest(EBMLelement)
		}

		/// <summary>Test stub for SetData(String)</summary>
		[PexMethod]
		public void SetDataTest([PexAssumeUnderTest]EBMLelement target, string data)
		{
			target.SetData(data);
			// TODO: add assertions to method EBMLelementTest.SetDataTest(EBMLelement, String)
		}

		/// <summary>Test stub for SetData(UInt64)</summary>
		[PexMethod]
		public void SetDataTest01([PexAssumeUnderTest]EBMLelement target, ulong data)
		{
			target.SetData(data);
			// TODO: add assertions to method EBMLelementTest.SetDataTest01(EBMLelement, UInt64)
		}

		/// <summary>Test stub for Write(File, Int64, Int64)</summary>
		[PexMethod]
		public void WriteTest(
			[PexAssumeUnderTest]EBMLelement target,
			File file,
			long position,
			long reserved
		)
		{
			target.Write(file, position, reserved);
			// TODO: add assertions to method EBMLelementTest.WriteTest(EBMLelement, File, Int64, Int64)
		}

		/// <summary>Test stub for get_DataSize()</summary>
		[PexMethod]
		public long DataSizeGetTest([PexAssumeUnderTest]EBMLelement target)
		{
			long result = target.DataSize;
			return result;
			// TODO: add assertions to method EBMLelementTest.DataSizeGetTest(EBMLelement)
		}

		/// <summary>Test stub for get_DataSizeSize()</summary>
		[PexMethod]
		public long DataSizeSizeGetTest([PexAssumeUnderTest]EBMLelement target)
		{
			long result = target.DataSizeSize;
			return result;
			// TODO: add assertions to method EBMLelementTest.DataSizeSizeGetTest(EBMLelement)
		}

		/// <summary>Test stub for get_Header()</summary>
		[PexMethod]
		public ByteVector HeaderGetTest([PexAssumeUnderTest]EBMLelement target)
		{
			ByteVector result = target.Header;
			return result;
			// TODO: add assertions to method EBMLelementTest.HeaderGetTest(EBMLelement)
		}

		/// <summary>Test stub for get_IDSize()</summary>
		[PexMethod]
		public long IDSizeGetTest([PexAssumeUnderTest]EBMLelement target)
		{
			long result = target.IDSize;
			return result;
			// TODO: add assertions to method EBMLelementTest.IDSizeGetTest(EBMLelement)
		}

		/// <summary>Test stub for get_Size()</summary>
		[PexMethod]
		public long SizeGetTest([PexAssumeUnderTest]EBMLelement target)
		{
			long result = target.Size;
			return result;
			// TODO: add assertions to method EBMLelementTest.SizeGetTest(EBMLelement)
		}
	}
}
