using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for DescriptionRecord</summary>
    [TestClass]
    [PexClass(typeof(DescriptionRecord))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DescriptionRecordTest
    {

		/// <summary>Test stub for .ctor(UInt16, UInt16, String, String)</summary>
		[PexMethod]
		public DescriptionRecord ConstructorTest(
			ushort languageListIndex,
			ushort streamNumber,
			string name,
			string value
		)
		{
			DescriptionRecord target = new DescriptionRecord(languageListIndex, streamNumber, name, value);
			return target;
			// TODO: add assertions to method DescriptionRecordTest.ConstructorTest(UInt16, UInt16, String, String)
		}

		/// <summary>Test stub for .ctor(UInt16, UInt16, String, ByteVector)</summary>
		[PexMethod]
		public DescriptionRecord ConstructorTest01(
			ushort languageListIndex,
			ushort streamNumber,
			string name,
			ByteVector value
		)
		{
			DescriptionRecord target = new DescriptionRecord(languageListIndex, streamNumber, name, value);
			return target;
			// TODO: add assertions to method DescriptionRecordTest.ConstructorTest01(UInt16, UInt16, String, ByteVector)
		}

		/// <summary>Test stub for .ctor(UInt16, UInt16, String, UInt32)</summary>
		[PexMethod]
		public DescriptionRecord ConstructorTest02(
			ushort languageListIndex,
			ushort streamNumber,
			string name,
			uint value
		)
		{
			DescriptionRecord target = new DescriptionRecord(languageListIndex, streamNumber, name, value);
			return target;
			// TODO: add assertions to method DescriptionRecordTest.ConstructorTest02(UInt16, UInt16, String, UInt32)
		}

		/// <summary>Test stub for .ctor(UInt16, UInt16, String, UInt64)</summary>
		[PexMethod]
		public DescriptionRecord ConstructorTest03(
			ushort languageListIndex,
			ushort streamNumber,
			string name,
			ulong value
		)
		{
			DescriptionRecord target = new DescriptionRecord(languageListIndex, streamNumber, name, value);
			return target;
			// TODO: add assertions to method DescriptionRecordTest.ConstructorTest03(UInt16, UInt16, String, UInt64)
		}

		/// <summary>Test stub for .ctor(UInt16, UInt16, String, UInt16)</summary>
		[PexMethod]
		public DescriptionRecord ConstructorTest04(
			ushort languageListIndex,
			ushort streamNumber,
			string name,
			ushort value
		)
		{
			DescriptionRecord target = new DescriptionRecord(languageListIndex, streamNumber, name, value);
			return target;
			// TODO: add assertions to method DescriptionRecordTest.ConstructorTest04(UInt16, UInt16, String, UInt16)
		}

		/// <summary>Test stub for .ctor(UInt16, UInt16, String, Boolean)</summary>
		[PexMethod]
		public DescriptionRecord ConstructorTest05(
			ushort languageListIndex,
			ushort streamNumber,
			string name,
			bool value
		)
		{
			DescriptionRecord target = new DescriptionRecord(languageListIndex, streamNumber, name, value);
			return target;
			// TODO: add assertions to method DescriptionRecordTest.ConstructorTest05(UInt16, UInt16, String, Boolean)
		}

	

	

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method DescriptionRecordTest.RenderTest(DescriptionRecord)
		}

		/// <summary>Test stub for ToBool()</summary>
		[PexMethod]
		public bool ToBoolTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			bool result = target.ToBool();
			return result;
			// TODO: add assertions to method DescriptionRecordTest.ToBoolTest(DescriptionRecord)
		}

		/// <summary>Test stub for ToByteVector()</summary>
		[PexMethod]
		public ByteVector ToByteVectorTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			ByteVector result = target.ToByteVector();
			return result;
			// TODO: add assertions to method DescriptionRecordTest.ToByteVectorTest(DescriptionRecord)
		}

		/// <summary>Test stub for ToDWord()</summary>
		[PexMethod]
		public uint ToDWordTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			uint result = target.ToDWord();
			return result;
			// TODO: add assertions to method DescriptionRecordTest.ToDWordTest(DescriptionRecord)
		}

	

		/// <summary>Test stub for ToQWord()</summary>
		[PexMethod]
		public ulong ToQWordTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			ulong result = target.ToQWord();
			return result;
			// TODO: add assertions to method DescriptionRecordTest.ToQWordTest(DescriptionRecord)
		}

		/// <summary>Test stub for ToString()</summary>
		[PexMethod]
		public string ToStringTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			string result = target.ToString();
			return result;
			// TODO: add assertions to method DescriptionRecordTest.ToStringTest(DescriptionRecord)
		}

		/// <summary>Test stub for ToWord()</summary>
		[PexMethod]
		public ushort ToWordTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			ushort result = target.ToWord();
			return result;
			// TODO: add assertions to method DescriptionRecordTest.ToWordTest(DescriptionRecord)
		}

		/// <summary>Test stub for get_LanguageListIndex()</summary>
		[PexMethod]
		public ushort LanguageListIndexGetTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			ushort result = target.LanguageListIndex;
			return result;
			// TODO: add assertions to method DescriptionRecordTest.LanguageListIndexGetTest(DescriptionRecord)
		}

		/// <summary>Test stub for get_Name()</summary>
		[PexMethod]
		public string NameGetTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			string result = target.Name;
			return result;
			// TODO: add assertions to method DescriptionRecordTest.NameGetTest(DescriptionRecord)
		}

		/// <summary>Test stub for get_StreamNumber()</summary>
		[PexMethod]
		public ushort StreamNumberGetTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			ushort result = target.StreamNumber;
			return result;
			// TODO: add assertions to method DescriptionRecordTest.StreamNumberGetTest(DescriptionRecord)
		}

		/// <summary>Test stub for get_Type()</summary>
		[PexMethod]
		public DataType TypeGetTest([PexAssumeUnderTest]DescriptionRecord target)
		{
			DataType result = target.Type;
			return result;
			// TODO: add assertions to method DescriptionRecordTest.TypeGetTest(DescriptionRecord)
		}
	}
}
