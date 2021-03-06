using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Matroska;

namespace TagLib.Matroska.Tests
{
    /// <summary>This class contains parameterized unit tests for EBMLreader</summary>
    [TestClass]
    [PexClass(typeof(EBMLreader))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class EBMLreaderTest
    {

		/// <summary>Test stub for .ctor(File, UInt64)</summary>
		[PexMethod]
		public EBMLreader ConstructorTest(File _file, ulong position)
		{
			EBMLreader target = new EBMLreader(_file, position);
			return target;
			// TODO: add assertions to method EBMLreaderTest.ConstructorTest(File, UInt64)
		}

		/// <summary>Test stub for .ctor(EBMLreader, UInt64)</summary>
		[PexMethod]
		public EBMLreader ConstructorTest01(EBMLreader parent, ulong position)
		{
			EBMLreader target = new EBMLreader(parent, position);
			return target;
			// TODO: add assertions to method EBMLreaderTest.ConstructorTest01(EBMLreader, UInt64)
		}

		/// <summary>Test stub for .ctor(EBMLreader, UInt64, MatroskaID, UInt64)</summary>
		[PexMethod]
		public EBMLreader ConstructorTest02(
			EBMLreader parent,
			ulong position,
			MatroskaID ebmlid,
			ulong size
		)
		{
			EBMLreader target = new EBMLreader(parent, position, ebmlid, size);
			return target;
			// TODO: add assertions to method EBMLreaderTest.ConstructorTest02(EBMLreader, UInt64, MatroskaID, UInt64)
		}

		/// <summary>Test stub for Read(Boolean)</summary>
		[PexMethod]
		public bool ReadTest([PexAssumeUnderTest]EBMLreader target, bool throwException)
		{
			bool result = target.Read(throwException);
			return result;
			// TODO: add assertions to method EBMLreaderTest.ReadTest(EBMLreader, Boolean)
		}

		/// <summary>Test stub for ReadBool()</summary>
		[PexMethod]
		public bool ReadBoolTest([PexAssumeUnderTest]EBMLreader target)
		{
			bool result = target.ReadBool();
			return result;
			// TODO: add assertions to method EBMLreaderTest.ReadBoolTest(EBMLreader)
		}

		/// <summary>Test stub for ReadBytes()</summary>
		[PexMethod]
		public ByteVector ReadBytesTest([PexAssumeUnderTest]EBMLreader target)
		{
			ByteVector result = target.ReadBytes();
			return result;
			// TODO: add assertions to method EBMLreaderTest.ReadBytesTest(EBMLreader)
		}

		/// <summary>Test stub for ReadDouble()</summary>
		[PexMethod]
		public double ReadDoubleTest([PexAssumeUnderTest]EBMLreader target)
		{
			double result = target.ReadDouble();
			return result;
			// TODO: add assertions to method EBMLreaderTest.ReadDoubleTest(EBMLreader)
		}

		/// <summary>Test stub for ReadString()</summary>
		[PexMethod]
		public string ReadStringTest([PexAssumeUnderTest]EBMLreader target)
		{
			string result = target.ReadString();
			return result;
			// TODO: add assertions to method EBMLreaderTest.ReadStringTest(EBMLreader)
		}

		/// <summary>Test stub for ReadULong()</summary>
		[PexMethod]
		public ulong ReadULongTest([PexAssumeUnderTest]EBMLreader target)
		{
			ulong result = target.ReadULong();
			return result;
			// TODO: add assertions to method EBMLreaderTest.ReadULongTest(EBMLreader)
		}

		/// <summary>Test stub for Remove()</summary>
		[PexMethod]
		public long RemoveTest([PexAssumeUnderTest]EBMLreader target)
		{
			long result = target.Remove();
			return result;
			// TODO: add assertions to method EBMLreaderTest.RemoveTest(EBMLreader)
		}

		/// <summary>Test stub for SetVoid()</summary>
		[PexMethod]
		public void SetVoidTest([PexAssumeUnderTest]EBMLreader target)
		{
			target.SetVoid();
			// TODO: add assertions to method EBMLreaderTest.SetVoidTest(EBMLreader)
		}

		/// <summary>Test stub for WriteDataSize()</summary>
		[PexMethod]
		public long WriteDataSizeTest([PexAssumeUnderTest]EBMLreader target)
		{
			long result = target.WriteDataSize();
			return result;
			// TODO: add assertions to method EBMLreaderTest.WriteDataSizeTest(EBMLreader)
		}

		/// <summary>Test stub for WriteVoid()</summary>
		[PexMethod]
		public void WriteVoidTest([PexAssumeUnderTest]EBMLreader target)
		{
			target.WriteVoid();
			// TODO: add assertions to method EBMLreaderTest.WriteVoidTest(EBMLreader)
		}

		/// <summary>Test stub for get_Abstract()</summary>
		[PexMethod]
		public bool AbstractGetTest([PexAssumeUnderTest]EBMLreader target)
		{
			bool result = target.Abstract;
			return result;
			// TODO: add assertions to method EBMLreaderTest.AbstractGetTest(EBMLreader)
		}

		/// <summary>Test stub for get_DataOffset()</summary>
		[PexMethod]
		public ulong DataOffsetGetTest([PexAssumeUnderTest]EBMLreader target)
		{
			ulong result = target.DataOffset;
			return result;
			// TODO: add assertions to method EBMLreaderTest.DataOffsetGetTest(EBMLreader)
		}

		/// <summary>Test stub for get_DataSize()</summary>
		[PexMethod]
		public ulong DataSizeGetTest([PexAssumeUnderTest]EBMLreader target)
		{
			ulong result = target.DataSize;
			return result;
			// TODO: add assertions to method EBMLreaderTest.DataSizeGetTest(EBMLreader)
		}

		/// <summary>Test stub for get_ID()</summary>
		[PexMethod]
		public MatroskaID IDGetTest([PexAssumeUnderTest]EBMLreader target)
		{
			MatroskaID result = target.ID;
			return result;
			// TODO: add assertions to method EBMLreaderTest.IDGetTest(EBMLreader)
		}

		/// <summary>Test stub for get_Offset()</summary>
		[PexMethod]
		public ulong OffsetGetTest([PexAssumeUnderTest]EBMLreader target)
		{
			ulong result = target.Offset;
			return result;
			// TODO: add assertions to method EBMLreaderTest.OffsetGetTest(EBMLreader)
		}

		/// <summary>Test stub for get_Parent()</summary>
		[PexMethod]
		public EBMLreader ParentGetTest([PexAssumeUnderTest]EBMLreader target)
		{
			EBMLreader result = target.Parent;
			return result;
			// TODO: add assertions to method EBMLreaderTest.ParentGetTest(EBMLreader)
		}

		/// <summary>Test stub for get_Size()</summary>
		[PexMethod]
		public ulong SizeGetTest([PexAssumeUnderTest]EBMLreader target)
		{
			ulong result = target.Size;
			return result;
			// TODO: add assertions to method EBMLreaderTest.SizeGetTest(EBMLreader)
		}

		/// <summary>Test stub for set_DataSize(UInt64)</summary>
		[PexMethod]
		public void DataSizeSetTest([PexAssumeUnderTest]EBMLreader target, ulong value)
		{
			target.DataSize = value;
			// TODO: add assertions to method EBMLreaderTest.DataSizeSetTest(EBMLreader, UInt64)
		}

		/// <summary>Test stub for set_Offset(UInt64)</summary>
		[PexMethod]
		public void OffsetSetTest([PexAssumeUnderTest]EBMLreader target, ulong value)
		{
			target.Offset = value;
			// TODO: add assertions to method EBMLreaderTest.OffsetSetTest(EBMLreader, UInt64)
		}

		/// <summary>Test stub for set_Size(UInt64)</summary>
		[PexMethod]
		public void SizeSetTest([PexAssumeUnderTest]EBMLreader target, ulong value)
		{
			target.Size = value;
			// TODO: add assertions to method EBMLreaderTest.SizeSetTest(EBMLreader, UInt64)
		}
	}
}
