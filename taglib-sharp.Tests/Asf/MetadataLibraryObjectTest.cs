using TagLib;
using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Asf;

namespace TagLib.Asf.Tests
{
    /// <summary>This class contains parameterized unit tests for MetadataLibraryObject</summary>
    [TestClass]
    [PexClass(typeof(MetadataLibraryObject))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MetadataLibraryObjectTest
    {

		/// <summary>Test stub for .ctor(File, Int64)</summary>
		[PexMethod]
		public MetadataLibraryObject ConstructorTest(File file, long position)
		{
			MetadataLibraryObject target = new MetadataLibraryObject(file, position);
			return target;
			// TODO: add assertions to method MetadataLibraryObjectTest.ConstructorTest(File, Int64)
		}

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public MetadataLibraryObject ConstructorTest01()
		{
			MetadataLibraryObject target = new MetadataLibraryObject();
			return target;
			// TODO: add assertions to method MetadataLibraryObjectTest.ConstructorTest01()
		}

		/// <summary>Test stub for AddRecord(DescriptionRecord)</summary>
		[PexMethod]
		public void AddRecordTest([PexAssumeUnderTest]MetadataLibraryObject target, DescriptionRecord record)
		{
			target.AddRecord(record);
			// TODO: add assertions to method MetadataLibraryObjectTest.AddRecordTest(MetadataLibraryObject, DescriptionRecord)
		}

		/// <summary>Test stub for GetEnumerator()</summary>
		[PexMethod]
		public IEnumerator<DescriptionRecord> GetEnumeratorTest([PexAssumeUnderTest]MetadataLibraryObject target)
		{
			IEnumerator<DescriptionRecord> result = target.GetEnumerator();
			return result;
			// TODO: add assertions to method MetadataLibraryObjectTest.GetEnumeratorTest(MetadataLibraryObject)
		}

		/// <summary>Test stub for GetRecords(UInt16, UInt16, String[])</summary>
		[PexMethod]
		public IEnumerable<DescriptionRecord> GetRecordsTest(
			[PexAssumeUnderTest]MetadataLibraryObject target,
			ushort languageListIndex,
			ushort streamNumber,
			string[] names
		)
		{
			IEnumerable<DescriptionRecord> result = target.GetRecords(languageListIndex, streamNumber, names);
			return result;
			// TODO: add assertions to method MetadataLibraryObjectTest.GetRecordsTest(MetadataLibraryObject, UInt16, UInt16, String[])
		}

		/// <summary>Test stub for RemoveRecords(UInt16, UInt16, String)</summary>
		[PexMethod]
		public void RemoveRecordsTest(
			[PexAssumeUnderTest]MetadataLibraryObject target,
			ushort languageListIndex,
			ushort streamNumber,
			string name
		)
		{
			target.RemoveRecords(languageListIndex, streamNumber, name);
			// TODO: add assertions to method MetadataLibraryObjectTest.RemoveRecordsTest(MetadataLibraryObject, UInt16, UInt16, String)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]MetadataLibraryObject target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method MetadataLibraryObjectTest.RenderTest(MetadataLibraryObject)
		}

		/// <summary>Test stub for SetRecords(UInt16, UInt16, String, DescriptionRecord[])</summary>
		[PexMethod]
		public void SetRecordsTest(
			[PexAssumeUnderTest]MetadataLibraryObject target,
			ushort languageListIndex,
			ushort streamNumber,
			string name,
			DescriptionRecord[] records
		)
		{
			target.SetRecords(languageListIndex, streamNumber, name, records);
			// TODO: add assertions to method MetadataLibraryObjectTest.SetRecordsTest(MetadataLibraryObject, UInt16, UInt16, String, DescriptionRecord[])
		}

		/// <summary>Test stub for get_IsEmpty()</summary>
		[PexMethod]
		public bool IsEmptyGetTest([PexAssumeUnderTest]MetadataLibraryObject target)
		{
			bool result = target.IsEmpty;
			return result;
			// TODO: add assertions to method MetadataLibraryObjectTest.IsEmptyGetTest(MetadataLibraryObject)
		}
	}
}
