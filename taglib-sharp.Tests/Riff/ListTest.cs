using System.Collections.Generic;
using TagLib;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib.Riff;

namespace TagLib.Riff.Tests
{
    /// <summary>This class contains parameterized unit tests for List</summary>
    [TestClass]
    [PexClass(typeof(List))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ListTest
    {

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public List ConstructorTest(ByteVector data)
		{
			List target = new List(data);
			return target;
			// TODO: add assertions to method ListTest.ConstructorTest(ByteVector)
		}

		/// <summary>Test stub for .ctor(File, Int64, Int32)</summary>
		[PexMethod]
		public List ConstructorTest01(
			File file,
			long position,
			int length
		)
		{
			List target = new List(file, position, length);
			return target;
			// TODO: add assertions to method ListTest.ConstructorTest01(File, Int64, Int32)
		}

		/// <summary>Test stub for GetValueAsUInt(ByteVector)</summary>
		[PexMethod]
		public uint GetValueAsUIntTest([PexAssumeUnderTest]List target, ByteVector id)
		{
			uint result = target.GetValueAsUInt(id);
			return result;
			// TODO: add assertions to method ListTest.GetValueAsUIntTest(List, ByteVector)
		}

		/// <summary>Test stub for GetValues(ByteVector)</summary>
		[PexMethod]
		public ByteVectorCollection GetValuesTest([PexAssumeUnderTest]List target, ByteVector id)
		{
			ByteVectorCollection result = target.GetValues(id);
			return result;
			// TODO: add assertions to method ListTest.GetValuesTest(List, ByteVector)
		}

		/// <summary>Test stub for GetValuesAsStrings(ByteVector)</summary>
		[PexMethod]
		public string[] GetValuesAsStringsTest([PexAssumeUnderTest]List target, ByteVector id)
		{
			string[] result = target.GetValuesAsStrings(id);
			return result;
			// TODO: add assertions to method ListTest.GetValuesAsStringsTest(List, ByteVector)
		}

		/// <summary>Test stub for RemoveValue(ByteVector)</summary>
		[PexMethod]
		public void RemoveValueTest([PexAssumeUnderTest]List target, ByteVector id)
		{
			target.RemoveValue(id);
			// TODO: add assertions to method ListTest.RemoveValueTest(List, ByteVector)
		}

		/// <summary>Test stub for Render()</summary>
		[PexMethod]
		public ByteVector RenderTest([PexAssumeUnderTest]List target)
		{
			ByteVector result = target.Render();
			return result;
			// TODO: add assertions to method ListTest.RenderTest(List)
		}

		/// <summary>Test stub for RenderEnclosed(ByteVector)</summary>
		[PexMethod]
		public ByteVector RenderEnclosedTest([PexAssumeUnderTest]List target, ByteVector id)
		{
			ByteVector result = target.RenderEnclosed(id);
			return result;
			// TODO: add assertions to method ListTest.RenderEnclosedTest(List, ByteVector)
		}

		/// <summary>Test stub for SetValue(ByteVector, IEnumerable`1&lt;ByteVector&gt;)</summary>
		[PexMethod]
		public void SetValueTest(
			[PexAssumeUnderTest]List target,
			ByteVector id,
			IEnumerable<ByteVector> values
		)
		{
			target.SetValue(id, values);
			// TODO: add assertions to method ListTest.SetValueTest(List, ByteVector, IEnumerable`1<ByteVector>)
		}

		/// <summary>Test stub for SetValue(ByteVector, ByteVector[])</summary>
		[PexMethod]
		public void SetValueTest01(
			[PexAssumeUnderTest]List target,
			ByteVector id,
			ByteVector[] values
		)
		{
			target.SetValue(id, values);
			// TODO: add assertions to method ListTest.SetValueTest01(List, ByteVector, ByteVector[])
		}

		/// <summary>Test stub for SetValue(ByteVector, UInt32)</summary>
		[PexMethod]
		public void SetValueTest02(
			[PexAssumeUnderTest]List target,
			ByteVector id,
			uint value
		)
		{
			target.SetValue(id, value);
			// TODO: add assertions to method ListTest.SetValueTest02(List, ByteVector, UInt32)
		}

		/// <summary>Test stub for SetValue(ByteVector, IEnumerable`1&lt;String&gt;)</summary>
		[PexMethod]
		public void SetValueTest03(
			[PexAssumeUnderTest]List target,
			ByteVector id,
			IEnumerable<string> values
		)
		{
			target.SetValue(id, values);
			// TODO: add assertions to method ListTest.SetValueTest03(List, ByteVector, IEnumerable`1<String>)
		}

		/// <summary>Test stub for SetValue(ByteVector, String[])</summary>
		[PexMethod]
		public void SetValueTest04(
			[PexAssumeUnderTest]List target,
			ByteVector id,
			string[] values
		)
		{
			target.SetValue(id, values);
			// TODO: add assertions to method ListTest.SetValueTest04(List, ByteVector, String[])
		}
	}
}
