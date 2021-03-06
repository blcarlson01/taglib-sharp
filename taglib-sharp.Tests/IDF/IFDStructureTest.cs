using TagLib.IFD.Tags;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.IFD;

namespace TagLib.IFD.Tests
{
    /// <summary>This class contains parameterized unit tests for IFDStructure</summary>
    [TestClass]
    [PexClass(typeof(IFDStructure))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class IFDStructureTest
    {

		/// <summary>Test stub for .ctor()</summary>
		[PexMethod]
		public IFDStructure ConstructorTest()
		{
			IFDStructure target = new IFDStructure();
			return target;
			// TODO: add assertions to method IFDStructureTest.ConstructorTest()
		}

		/// <summary>Test stub for AddEntry(Int32, IFDEntry)</summary>
		[PexMethod]
		public void AddEntryTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			IFDEntry entry
		)
		{
			target.AddEntry(directory, entry);
			// TODO: add assertions to method IFDStructureTest.AddEntryTest(IFDStructure, Int32, IFDEntry)
		}

		/// <summary>Test stub for ContainsTag(Int32, UInt16)</summary>
		[PexMethod]
		public bool ContainsTagTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort tag
		)
		{
			bool result = target.ContainsTag(directory, tag);
			return result;
			// TODO: add assertions to method IFDStructureTest.ContainsTagTest(IFDStructure, Int32, UInt16)
		}

		/// <summary>Test stub for GetByteValue(Int32, UInt16)</summary>
		[PexMethod]
		public byte? GetByteValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag
		)
		{
			byte? result = target.GetByteValue(directory, entry_tag);
			return result;
			// TODO: add assertions to method IFDStructureTest.GetByteValueTest(IFDStructure, Int32, UInt16)
		}

		/// <summary>Test stub for GetDateTimeValue(Int32, UInt16)</summary>
		[PexMethod]
		public DateTime? GetDateTimeValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag
		)
		{
			DateTime? result = target.GetDateTimeValue(directory, entry_tag);
			return result;
			// TODO: add assertions to method IFDStructureTest.GetDateTimeValueTest(IFDStructure, Int32, UInt16)
		}

		/// <summary>Test stub for GetEntry(Int32, UInt16)</summary>
		[PexMethod]
		public IFDEntry GetEntryTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort tag
		)
		{
			IFDEntry result = target.GetEntry(directory, tag);
			return result;
			// TODO: add assertions to method IFDStructureTest.GetEntryTest(IFDStructure, Int32, UInt16)
		}

		/// <summary>Test stub for GetEntry(Int32, IFDEntryTag)</summary>
		[PexMethod]
		public IFDEntry GetEntryTest01(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			IFDEntryTag entry_tag
		)
		{
			IFDEntry result = target.GetEntry(directory, entry_tag);
			return result;
			// TODO: add assertions to method IFDStructureTest.GetEntryTest01(IFDStructure, Int32, IFDEntryTag)
		}

		/// <summary>Test stub for GetLongValue(Int32, UInt16)</summary>
		[PexMethod]
		public uint? GetLongValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag
		)
		{
			uint? result = target.GetLongValue(directory, entry_tag);
			return result;
			// TODO: add assertions to method IFDStructureTest.GetLongValueTest(IFDStructure, Int32, UInt16)
		}

		/// <summary>Test stub for GetRationalValue(Int32, UInt16)</summary>
		[PexMethod]
		public double? GetRationalValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag
		)
		{
			double? result = target.GetRationalValue(directory, entry_tag);
			return result;
			// TODO: add assertions to method IFDStructureTest.GetRationalValueTest(IFDStructure, Int32, UInt16)
		}

		/// <summary>Test stub for GetStringValue(Int32, UInt16)</summary>
		[PexMethod]
		public string GetStringValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag
		)
		{
			string result = target.GetStringValue(directory, entry_tag);
			return result;
			// TODO: add assertions to method IFDStructureTest.GetStringValueTest(IFDStructure, Int32, UInt16)
		}

		/// <summary>Test stub for RemoveTag(Int32, UInt16)</summary>
		[PexMethod]
		public void RemoveTagTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort tag
		)
		{
			target.RemoveTag(directory, tag);
			// TODO: add assertions to method IFDStructureTest.RemoveTagTest(IFDStructure, Int32, UInt16)
		}

		/// <summary>Test stub for RemoveTag(Int32, IFDEntryTag)</summary>
		[PexMethod]
		public void RemoveTagTest01(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			IFDEntryTag entry_tag
		)
		{
			target.RemoveTag(directory, entry_tag);
			// TODO: add assertions to method IFDStructureTest.RemoveTagTest01(IFDStructure, Int32, IFDEntryTag)
		}

		/// <summary>Test stub for SetByteValue(Int32, UInt16, Byte)</summary>
		[PexMethod]
		public void SetByteValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag,
			byte value
		)
		{
			target.SetByteValue(directory, entry_tag, value);
			// TODO: add assertions to method IFDStructureTest.SetByteValueTest(IFDStructure, Int32, UInt16, Byte)
		}

		/// <summary>Test stub for SetDateTimeValue(Int32, UInt16, DateTime)</summary>
		[PexMethod]
		public void SetDateTimeValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag,
			DateTime value
		)
		{
			target.SetDateTimeValue(directory, entry_tag, value);
			// TODO: add assertions to method IFDStructureTest.SetDateTimeValueTest(IFDStructure, Int32, UInt16, DateTime)
		}

		/// <summary>Test stub for SetEntry(Int32, IFDEntry)</summary>
		[PexMethod]
		public void SetEntryTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			IFDEntry entry
		)
		{
			target.SetEntry(directory, entry);
			// TODO: add assertions to method IFDStructureTest.SetEntryTest(IFDStructure, Int32, IFDEntry)
		}

		/// <summary>Test stub for SetLongValue(Int32, UInt16, UInt32)</summary>
		[PexMethod]
		public void SetLongValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag,
			uint value
		)
		{
			target.SetLongValue(directory, entry_tag, value);
			// TODO: add assertions to method IFDStructureTest.SetLongValueTest(IFDStructure, Int32, UInt16, UInt32)
		}

		/// <summary>Test stub for SetRationalValue(Int32, UInt16, Double)</summary>
		[PexMethod]
		public void SetRationalValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag,
			double value
		)
		{
			target.SetRationalValue(directory, entry_tag, value);
			// TODO: add assertions to method IFDStructureTest.SetRationalValueTest(IFDStructure, Int32, UInt16, Double)
		}

		/// <summary>Test stub for SetStringValue(Int32, UInt16, String)</summary>
		[PexMethod]
		public void SetStringValueTest(
			[PexAssumeUnderTest]IFDStructure target,
			int directory,
			ushort entry_tag,
			string value
		)
		{
			target.SetStringValue(directory, entry_tag, value);
			// TODO: add assertions to method IFDStructureTest.SetStringValueTest(IFDStructure, Int32, UInt16, String)
		}

		/// <summary>Test stub for get_Directories()</summary>
		[PexMethod]
		public IFDDirectory[] DirectoriesGetTest([PexAssumeUnderTest]IFDStructure target)
		{
			IFDDirectory[] result = target.Directories;
			return result;
			// TODO: add assertions to method IFDStructureTest.DirectoriesGetTest(IFDStructure)
		}
	}
}
