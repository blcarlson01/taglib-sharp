using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TagLib;

namespace TagLib.Tests
{
    /// <summary>This class contains parameterized unit tests for ReadOnlyByteVector</summary>
    [TestClass]
    [PexClass(typeof(ReadOnlyByteVector))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ReadOnlyByteVectorTest
    {

		/// <summary>Test stub for .ctor(Int32, Byte)</summary>
		[PexMethod]
		public ReadOnlyByteVector ConstructorTest(int size, byte value)
		{
			ReadOnlyByteVector target = new ReadOnlyByteVector(size, value);
			return target;
			// TODO: add assertions to method ReadOnlyByteVectorTest.ConstructorTest(Int32, Byte)
		}

		/// <summary>Test stub for .ctor(Int32)</summary>
		[PexMethod]
		public ReadOnlyByteVector ConstructorTest01(int size)
		{
			ReadOnlyByteVector target = new ReadOnlyByteVector(size);
			return target;
			// TODO: add assertions to method ReadOnlyByteVectorTest.ConstructorTest01(Int32)
		}

		/// <summary>Test stub for .ctor(ByteVector)</summary>
		[PexMethod]
		public ReadOnlyByteVector ConstructorTest02(ByteVector vector)
		{
			ReadOnlyByteVector target = new ReadOnlyByteVector(vector);
			return target;
			// TODO: add assertions to method ReadOnlyByteVectorTest.ConstructorTest02(ByteVector)
		}

		/// <summary>Test stub for .ctor(Byte[], Int32)</summary>
		[PexMethod]
		public ReadOnlyByteVector ConstructorTest03(byte[] data, int length)
		{
			ReadOnlyByteVector target = new ReadOnlyByteVector(data, length);
			return target;
			// TODO: add assertions to method ReadOnlyByteVectorTest.ConstructorTest03(Byte[], Int32)
		}

		/// <summary>Test stub for .ctor(Byte[])</summary>
		[PexMethod]
		public ReadOnlyByteVector ConstructorTest04(byte[] data)
		{
			ReadOnlyByteVector target = new ReadOnlyByteVector(data);
			return target;
			// TODO: add assertions to method ReadOnlyByteVectorTest.ConstructorTest04(Byte[])
		}

		/// <summary>Test stub for get_IsFixedSize()</summary>
		[PexMethod]
		public bool IsFixedSizeGetTest([PexAssumeUnderTest]ReadOnlyByteVector target)
		{
			bool result = target.IsFixedSize;
			return result;
			// TODO: add assertions to method ReadOnlyByteVectorTest.IsFixedSizeGetTest(ReadOnlyByteVector)
		}

		/// <summary>Test stub for get_IsReadOnly()</summary>
		[PexMethod]
		public bool IsReadOnlyGetTest([PexAssumeUnderTest]ReadOnlyByteVector target)
		{
			bool result = target.IsReadOnly;
			return result;
			// TODO: add assertions to method ReadOnlyByteVectorTest.IsReadOnlyGetTest(ReadOnlyByteVector)
		}

		/// <summary>Test stub for op_Implicit(Byte)</summary>
		[PexMethod]
		public ReadOnlyByteVector op_ImplicitTest(byte value)
		{
			ReadOnlyByteVector result = (ReadOnlyByteVector)value;
			return result;
			// TODO: add assertions to method ReadOnlyByteVectorTest.op_ImplicitTest(Byte)
		}

		/// <summary>Test stub for op_Implicit(Byte[])</summary>
		[PexMethod]
		public ReadOnlyByteVector op_ImplicitTest01(byte[] value)
		{
			ReadOnlyByteVector result = (ReadOnlyByteVector)value;
			return result;
			// TODO: add assertions to method ReadOnlyByteVectorTest.op_ImplicitTest01(Byte[])
		}

		/// <summary>Test stub for op_Implicit(String)</summary>
		[PexMethod]
		public ReadOnlyByteVector op_ImplicitTest02(string value)
		{
			ReadOnlyByteVector result = (ReadOnlyByteVector)value;
			return result;
			// TODO: add assertions to method ReadOnlyByteVectorTest.op_ImplicitTest02(String)
		}
	}
}
